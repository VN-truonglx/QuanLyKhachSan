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
    public partial class frmManHinh : Form
    {
        DataTable tblManhinh;
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            txtTenManHinh.Enabled = false;
            txtMaManHinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaManHinh,TenManHinh FROM tblManHinh";
            tblManhinh = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvManHinh.DataSource = tblManhinh; //Nguồn dữ liệu        
            dgvManHinh.Columns[0].HeaderText = "Mã màn hình";
            dgvManHinh.Columns[1].HeaderText = "Tên màn hình";


            dgvManHinh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvManHinh.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblManhinh.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaManHinh.Text = dgvManHinh.CurrentRow.Cells["MaManHinh"].Value.ToString();
            txtTenManHinh.Text = dgvManHinh.CurrentRow.Cells["TenManHinh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaManHinh.Enabled = false;
            txtTenManHinh.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenManHinh.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaManHinh.Enabled = true; //cho phép nhập mới
            txtTenManHinh.Focus();
        }
        private void ResetValue()
        {
            txtMaManHinh.Text = "";
            txtTenManHinh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblManhinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaManHinh.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenManHinh.Text.Trim().Length == 0) //nếu chưa nhập tên màn hình
            {
                MessageBox.Show("Bạn chưa nhập tên màn hình ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblManHinh SET TenODia=N'" + txtTenManHinh.Text.ToString() + "' WHERE MaManHinh=N'" + txtMaManHinh.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenManHinh.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblManhinh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaManHinh.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblManHinh WHERE MaManHinh=N'" + txtMaManHinh.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenManHinh.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaManHinh.Text.Trim().Length == 0) //Nếu chưa nhập mã màn hình 
            {
                MessageBox.Show("Bạn phải nhập mã màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaManHinh.Focus();
                return;
            }
            if (txtTenManHinh.Text.Trim().Length == 0) //Nếu chưa nhập tên màn hình
            {
                MessageBox.Show("Bạn phải nhập tên màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenManHinh.Focus();
                return;
            }
            sql = "Select MaManHinh From tblManHinh where MaManHinh=N'" + txtMaManHinh.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã màn hình này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaManHinh.Focus();
                return;
            }

            sql = "INSERT INTO tblManHinh VALUES(N'" +
                txtMaManHinh.Text + "',N'" + txtTenManHinh.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaManHinh.Enabled = false;
            txtTenManHinh.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaManHinh.Enabled = false;
            txtTenManHinh.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
