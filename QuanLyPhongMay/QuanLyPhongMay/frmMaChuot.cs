using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyPhongMay.Class;

namespace QuanLyPhongMay
{
    public partial class frmMaChuot : Form
    {
        DataTable tblMachuot;
        public frmMaChuot()
        {
            InitializeComponent();
        }
        private void frmMaChuot_Load(object sender, EventArgs e)
        {
            txtTenChuot.Enabled = false;
            txtMaChuot.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaChuot,TenChuot FROM tblMaChuot";
            tblMachuot = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvMaChuot.DataSource = tblMachuot; //Nguồn dữ liệu        
            dgvMaChuot.Columns[0].HeaderText = "Mã chuột";
            dgvMaChuot.Columns[1].HeaderText = "Tên chuột";


            dgvMaChuot.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvMaChuot.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvMaChuot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblMachuot.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChuot.Text = dgvMaChuot.CurrentRow.Cells["MaChuot"].Value.ToString();
            txtTenChuot.Text = dgvMaChuot.CurrentRow.Cells["TenChuot"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaChuot.Enabled = false;
            txtTenChuot.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenChuot.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaChuot.Enabled = true; //cho phép nhập mới
            txtTenChuot.Focus();
        }
        private void ResetValue()
        {
            txtMaChuot.Text = "";
            txtTenChuot.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblMachuot.Rows.Count == 0)
            {
                MessageBox.Show("Không còn mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuot.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChuot.Text.Trim().Length == 0) //nếu chưa nhập tên chuột
            {
                MessageBox.Show("Bạn chưa nhập tên chuột ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMaChuot SET TenODia=N'" + txtTenChuot.Text.ToString() + "' WHERE MaChuot=N'" + txtMaChuot.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenChuot.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMachuot.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuot.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMaChuot WHERE MaChuot=N'" + txtMaChuot.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenChuot.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaChuot.Text.Trim().Length == 0) //Nếu chưa nhập mã chuột
            {
                MessageBox.Show("Bạn phải nhập mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuot.Focus();
                return;
            }
            if (txtTenChuot.Text.Trim().Length == 0) //Nếu chưa nhập tên chuột
            {
                MessageBox.Show("Bạn phải nhập tên chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChuot.Focus();
                return;
            }
            sql = "Select MaChuot From tblMaChuot where MaChuot=N'" + txtMaChuot.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã chuột này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuot.Focus();
                return;
            }

            sql = "INSERT INTO tblMaChuot VALUES(N'" +
                txtMaChuot.Text + "',N'" + txtTenChuot.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChuot.Enabled = false;
            txtTenChuot.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaChuot.Enabled = false;
            txtTenChuot.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}