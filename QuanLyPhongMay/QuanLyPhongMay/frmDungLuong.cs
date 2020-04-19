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
    public partial class frmDungLuong : Form
    {
        DataTable tblDL;
        public frmDungLuong()
        {
            InitializeComponent();
        }

        private void frmDungLuong_Load(object sender, EventArgs e)
        {
            txtTenDungLuong.Enabled = false;
            txtMaDungLuong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaDungLuong,TenDungLuong FROM tblDungLuong";
            tblDL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvDungLuong.DataSource = tblDL; //Nguồn dữ liệu        
            dgvDungLuong.Columns[0].HeaderText = "Mã dung lượng";
            dgvDungLuong.Columns[1].HeaderText = "Tên dung lượng";


            dgvDungLuong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvDungLuong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvDungLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblDL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaDungLuong.Text = dgvDungLuong.CurrentRow.Cells["MaDungLuong"].Value.ToString();
            txtTenDungLuong.Text = dgvDungLuong.CurrentRow.Cells["TenDungLuong"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaDungLuong.Enabled = false;
            txtTenDungLuong.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenDungLuong.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaDungLuong.Enabled = true; //cho phép nhập mới
            txtTenDungLuong.Focus();
        }
        private void ResetValue()
        {
            txtMaDungLuong.Text = "";
            txtTenDungLuong.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblDL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dung lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDungLuong.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenDungLuong.Text.Trim().Length == 0) //nếu chưa nhập tên chuột
            {
                MessageBox.Show("Bạn chưa nhập tên dung lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblDungLuong SET TenDungLuong=N'" + txtTenDungLuong.Text.ToString() + "' WHERE MaChuot=N'" + txtMaDungLuong.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenDungLuong.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDungLuong.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblDungLuong WHERE MaDungLuong=N'" + txtMaDungLuong.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenDungLuong.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaDungLuong.Text.Trim().Length == 0) //Nếu chưa nhập mã dung lượng
            {
                MessageBox.Show("Bạn phải nhập mã dung lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDungLuong.Focus();
                return;
            }
            if (txtTenDungLuong.Text.Trim().Length == 0) //Nếu chưa nhập tên dung lượng
            {
                MessageBox.Show("Bạn phải nhập tên dung lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDungLuong.Focus();
                return;
            }
            sql = "Select MaDungLuong From tblDungLuong where MaDungLuong=N'" + txtMaDungLuong.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã dung lượng này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDungLuong.Focus();
                return;
            }

            sql = "INSERT INTO tblDungLuong VALUES(N'" +
                txtMaDungLuong.Text + "',N'" + txtTenDungLuong.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaDungLuong.Enabled = false;
            txtTenDungLuong.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaDungLuong.Enabled = false;
            txtTenDungLuong.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
