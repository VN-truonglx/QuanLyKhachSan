using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSancode
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MFK3I4Q\\SQLEXPRESS;Initial Catalog=Qly_KhSan;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //load data into DataGridView function
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tblPhong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaPhong.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txbMaPhong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txbDonGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txbTenPhong.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE tblPhong SET TenPhong='"+txbTenPhong.Text+"',DonGia='"+txbDonGia.Text+ "' where  MaPhong='" + txbMaPhong.Text + "'";
            command.ExecuteNonQuery();
            loadData();

        }
    }
}
