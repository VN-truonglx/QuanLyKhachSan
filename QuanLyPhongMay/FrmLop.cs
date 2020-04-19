using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanlyPhongMay.Class;


namespace QuanLyPhongMay
{
    public partial class FrmLop : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmLop()
        {
            InitializeComponent();
        }
        private void FrmLop_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = localhost\MSSQLSERVER01; Initial Catalog = QlyPhongMay; Integrated Security = True";
            con.ConnectionString = connectionString;
            con.Open();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            DataTable tbl;
            string sql = "SELECT * FROM tblLop";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            dgvLop.DataSource = tbl;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
            txtSiSo.Text = dgvLop.CurrentRow.Cells["SiSo"].Value.ToString();
            txtMaLop.Enabled = false;
        }
       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSiSo.Text = "";
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            txtSiSo.Enabled = true;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataTable tbl;
            string sql;

            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Mã lớp");
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Tên lớp");
                txtTenLop.Focus();
            }
            sql = "UPDATE tblLop SET TenLop ='" + txtTenLop.Text + "',SiSo='" + txtSiSo.Text
                + "' where  MaLop ='" + txtMaLop.Text + "'";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            loadDataGridView();
            txtMaLop.Enabled = false;
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSiSo.Text = "";

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã lớp");
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên lớp");
                txtTenLop.Focus();
            }
            else
            {
                string sql = "insert into tblLop values ( '" + txtMaLop.Text.Trim() + "', '" + txtTenLop.Text.Trim() + "','" + txtSiSo.Text.Trim() + "' )";
                MessageBox.Show(sql);
                try
                {
                    QuanlyPhongMay.Class.Functions.RunSQL(sql);
                    loadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaLop.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

       
    }
}
    
