using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongMay_newvers
{
    class ThucThiSQL
    {
        public static bool check = false;

        static SqlConnection con;
        static string scon = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=QuanLiPhongMay_new;Integrated Security=True";

        public static void Connect()
        {
            con = new SqlConnection(scon);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public static void DisConnect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static void RunSQL(string sql)
        {
            Connect();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        //Chuyển số sang chữ
        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỷ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mươi";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mươi ", "linh ");
            //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            ThucThiSQL.Connect();
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, ThucThiSQL.con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;    // Truong gia tri
            cbo.DisplayMember = ten;    // Truong hien thi
        }

        public static string GetValue(string sql)
        {
            ThucThiSQL.Connect();
            string value = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                value = reader.GetValue(0).ToString();
            }
            reader.Close();
            return value;
        }

        //Hàm tạo khóa có dạng: TientoNgaythangnam_giophutgiay
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');

            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);//Ngày tháng năm
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');

            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);//Giờ phút giây
            key = key + d + "_" + t;
            return key;
        }

        public static string SinhMaTuDong(string table, string field, string tiento)
        {
            string hauto = "";
            string s = GetValue("select Top 1 " + field + " from " + table + " Order by " + field + " DESC");
            s = s.Replace(tiento, "");
            if (s == "") s = "0";
            int stt = int.Parse(s) + 1;
            if (stt < 10)
                hauto = "00" + stt;
            else if (stt < 100)
                hauto = "0" + stt;
            else
                hauto = stt + "";
            return tiento + hauto;
        }
    }
}
