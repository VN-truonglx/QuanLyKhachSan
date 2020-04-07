using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSancode
{
    class Functions
    {
        public static SqlConnection con = new SqlConnection();
        public static string constring = @"Data Source=DESKTOP-L3MR5NP\SQLEXPRESS;Initial Catalog=Qly_KhSan;Integrated Security=True";

        public static void connect()
        {
            con = new SqlConnection(constring);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public static void disconnect()
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static void RunSql(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public static bool Checkkey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
