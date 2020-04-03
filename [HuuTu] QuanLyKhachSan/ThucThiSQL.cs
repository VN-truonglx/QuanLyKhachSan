using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSancode
{
    class ThucThiSQL
    {
        public static bool check = false;

        static SqlConnection con;
        static string scon = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Qly_KhSan;Integrated Security=True";

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
 
    }
}
