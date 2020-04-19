using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyPhongMay.Class
{
    class Functions
    {
        
        public static bool check = false;

        static SqlConnection con;
        static string scon = @"Data Source=DESKTOP-5R016VP\SQLEXPRESS;Initial Catalog=QlyPhongMay;Integrated Security=True";

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
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
    }
}
