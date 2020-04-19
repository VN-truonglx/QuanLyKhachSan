using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh
{
    public partial class frmMonThucHanh : Form
    {
        public frmMonThucHanh()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
        }

        private void frmMonThucHanh_Load(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;
            loadDataGridView();
        }

        public void loadDataGridView()
        {
            DataTable tbl;
            string sql = "Select MaMon,TenMon from tblMonThucHanh";
            tbl = ThucThiSQL.GetDataToTable(sql);
            dataGridView_MTH.DataSource = tbl;

            //txt hiện thị mã môn và tên môn ở dòng đầu tiên
            txtMaMon.Text = tbl.Rows[0][0].ToString();
            txtTenMon.Text = tbl.Rows[0][1].ToString();
            //dataGridView_MTH.Columns[0].HeaderText = "";
            //dataGridView_MTH.Columns[1].HeaderText = "";
            dataGridView_MTH.Columns[0].Width = 80;
            dataGridView_MTH.Columns[1].Width = 120;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_MTH.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_MTH.EditMode = DataGridViewEditMode.EditProgrammatically;



        }

        private void dataGridView_MTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMon.Text = dataGridView_MTH.CurrentRow.Cells["MaMon"].Value.ToString();
            txtTenMon.Text = dataGridView_MTH.CurrentRow.Cells["TenMon"].Value.ToString();
            txtTenMon.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMon.Enabled = true;
            txtTenMon.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;

            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            if (txtTenMon.Text == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống!","Thông báo");
                txtTenMon.Focus();
                return;
            }

            string sql = "UPDATE tblMonThucHanh SET TenMon = N'" + txtTenMon.Text.Trim() + "' WHERE MaMon = N'" + txtMaMon.Text.Trim() + "'";
            ThucThiSQL.RunSQL(sql);

            loadDataGridView();

            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;

            btnThem.Enabled = true;
            btnHuyBo.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            if (txtMaMon.Text == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống!", "Thông báo");
                txtMaMon.Focus();
                return;
            }
            if (txtTenMon.Text == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống!", "Thông báo");
                txtTenMon.Focus();
                return;
            }
            string sql = "SELECT MaMon FROM tblMonThucHanh WHERE MaMon=N'" + txtMaMon.Text.Trim() + "'";
            if (ThucThiSQL.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã môn '" + txtMaMon.Text.Trim() + "' đã tồn tại, vui lòng nhập mã khác!", "Thông báo");
                txtMaMon.Focus();
                txtMaMon.Text = "";
                return;
            }
            sql = "INSERT INTO tblMonThucHanh(MaMon,TenMon) VALUES(N'" + txtMaMon.Text.Trim() + "',N'" + txtTenMon.Text.Trim() + "')";
            ThucThiSQL.RunSQL(sql);

            //Load lại lưới sau khi có thêm dữ liệu
            loadDataGridView();


            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;


        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            loadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from tblMonThucHanh WHERE MaMon = N'" + txtMaMon.Text.Trim() + "' ";
            ThucThiSQL.RunSQL(sql);
            loadDataGridView();

            txtMaMon.Enabled = false;
            txtTenMon.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThucThiSQL.DisConnect();
            this.Close();
        }
    }
}
