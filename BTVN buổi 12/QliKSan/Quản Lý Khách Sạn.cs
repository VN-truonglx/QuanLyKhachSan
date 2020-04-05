using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class Quản_Lý_Khách_Sạn : Form

    {
        SqlConnection con = new SqlConnection();

        public Quản_Lý_Khách_Sạn()
        {
            InitializeComponent();
        }

        private void Quản_Lý_Khách_Sạn_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=Qly_KhSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string sql = "Select * FROM tblPhong";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tableQLKhachSan = new DataTable();
            adp.Fill(tableQLKhachSan);
            dataGridView1.DataSource = tableQLKhachSan;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonGia.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
            txtMaPhong.Text = dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtDonGia.Enabled = true;
        }

            private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Ban can nhap ma phong");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Ban can nhap ten phong");
                txtTenPhong.Focus();
            }
            else
            {
                string sql = "insert into tblPhong values ( '" + txtMaPhong.Text + "', '" + txtTenPhong.Text + "'";

                if (txtDonGia.Text != "")
                    sql = sql + "," + txtDonGia.Text.Trim();
                sql = sql + ")";
                MessageBox.Show(sql);
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    loadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete  From tblPhong  where MaPhong = '" + txtMaPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            sql = "Select * From tblPhong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tableQLKhachSan = new DataTable();
            adp.Fill(tableQLKhachSan);
            dataGridView1.DataSource = tableQLKhachSan;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.') ||
               (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; 

            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Ban can nhap ma phong");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Ban can nhap ten phong");
                txtTenPhong.Focus();
            }
            sql = "UPDATE tblPhong SET TenPhong='" + txtTenPhong.Text + "',DonGia='" + txtDonGia.Text 
                + "' where  MaPhong='" + txtMaPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataGridView();
            txtMaPhong.Enabled = false;
        }

       
    }
}

