using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QliKSan.Class
{
    class Functions
    {
        public static SqlConnection Con;

        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = Properties.Settings.Default.QliKhSanConnectionString;


            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                MessageBox.Show("Chào mừng bạn đến với chương trình!");
            }

            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }

        public static DataTable LayDulieuVaoBang(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql,Con);
            adp.Fill(table);
            return table;
        }
        public static bool KtraKhoaChinh(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; 
            cmd = new SqlCommand();
            cmd.Connection = Con; 
            cmd.CommandText = sql; 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
