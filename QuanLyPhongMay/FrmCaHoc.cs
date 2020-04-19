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
    public partial class FrmCaHoc : Form
    {
        SqlConnection con = new SqlConnection();

        public FrmCaHoc()
        {
            InitializeComponent();
        }

        private void FrmCaHoc_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = localhost\MSSQLSERVER01; Initial Catalog = QlyPhongMay; Integrated Security = True";
            con.ConnectionString = connectionString;
            con.Open();
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            DataTable tbl;
            string sql = "SELECT * FROM tblCaHoc";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            dgvCaHoc.DataSource = tbl;
        }

        private void dgvCaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenCa.Text = dgvCaHoc.CurrentRow.Cells["TenCa"].Value.ToString();
            cboMaCa.Text = dgvCaHoc.CurrentRow.Cells["MaCa"].Value.ToString();
            cboMaCa.Enabled = false;
            txtTenCa.Enabled = true;
            
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            cboMaCa.Text = "";
            txtTenCa.Text = "";
            cboMaCa.Enabled = true;
            txtTenCa.Enabled = true;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataTable tbl;
            string sql;
            if (cboMaCa.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Mã ca");
                cboMaCa.Focus();
                return;
            }
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Tên phòng máy");
                txtTenCa.Focus();
            }
            sql = "UPDATE tblCaHoc SET TenCa ='" + txtTenCa.Text + "' where  MaCa ='" + cboMaCa.Text + "'";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            loadDataGridView();
            cboMaCa.Enabled = false;
            txtTenCa.Text = "";
            cboMaCa.Text = "";
            txtTenCa.Text = "";
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (cboMaCa.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã ca");
                cboMaCa.Focus();
                return;
            }
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên ca");
                txtTenCa.Focus();
            }
            else
            {
                string sql = "insert into tblCaHoc values ( '" + cboMaCa.Text.Trim() + "', '" + txtTenCa.Text.Trim() + "' )";
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


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable tbl;
            string sql = "SELECT * FROM tblCaHoc";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaCa.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn mã ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblCaHoc WHERE MaCa =N'" + cboMaCa.Text + "'";
                QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
                loadDataGridView();
                cboMaCa.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            cboMaCa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
    }
}
