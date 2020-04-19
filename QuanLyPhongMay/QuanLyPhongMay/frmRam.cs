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
    public partial class frmRam : Form
    {
        DataTable tblram;
        public frmRam()
        {
            InitializeComponent();
        }

        private void frmRam_Load(object sender, EventArgs e)
        {
            txtTenRam.Enabled = false;
            txtMaRam.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaRam,TenRam FROM tblRam";
            tblram = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvRam.DataSource = tblram; //Nguồn dữ liệu        
            dgvRam.Columns[0].HeaderText = "Mã ram";
            dgvRam.Columns[1].HeaderText = "Tên ram";


            dgvRam.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvRam.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvRam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblram.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaRam.Text = dgvRam.CurrentRow.Cells["MaRam"].Value.ToString();
            txtTenRam.Text = dgvRam.CurrentRow.Cells["TenRam"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaRam.Enabled = false;
            txtTenRam.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenRam.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaRam.Enabled = true; //cho phép nhập mới
            txtTenRam.Focus();
        }
        private void ResetValue()
        {
            txtMaRam.Text = "";
            txtTenRam.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblram.Rows.Count == 0)
            {
                MessageBox.Show("Không còn ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaRam.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenRam.Text.Trim().Length == 0) //nếu chưa nhập tên ram
            {
                MessageBox.Show("Bạn chưa nhập tên ram ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblRam SET TenRam=N'" + txtTenRam.Text.ToString() + "' WHERE MaRam=N'" + txtMaRam.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenRam.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblram.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaRam.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblRam WHERE MaRam=N'" + txtMaRam.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenRam.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaRam.Text.Trim().Length == 0) //Nếu chưa nhập mã ram
            {
                MessageBox.Show("Bạn phải nhập mã ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaRam.Focus();
                return;
            }
            if (txtTenRam.Text.Trim().Length == 0) //Nếu chưa nhập tên ram
            {
                MessageBox.Show("Bạn phải nhập tên ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenRam.Focus();
                return;
            }
            sql = "Select MaRam From tblRam where MaRam=N'" + txtMaRam.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã ram này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaRam.Focus();
                return;
            }

            sql = "INSERT INTO tblRam VALUES(N'" +
                txtMaRam.Text + "',N'" + txtTenRam.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaRam.Enabled = false;
            txtTenRam.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaRam.Enabled = false;
            txtTenRam.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
