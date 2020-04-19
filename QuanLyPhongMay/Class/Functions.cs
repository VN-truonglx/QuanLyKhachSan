using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;   


namespace QuanlyPhongMay.Class
{
    class Functions
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static string connString;   //Khai báo biến chứa chuỗi kết nối

        public static void Connect()
        {
            //Thiết lập giá trị cho chuỗi kết nối
            connString = "Data Source = localhost\\MSSQLSERVER01; Initial Catalog = QlyPhongMay; Integrated Security = True";

            Conn = new SqlConnection();         		
            Conn.ConnectionString = connString; 		
            Conn.Open();                        		
        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose(); 	//Giải phóng tài nguyên
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }


    }
}
