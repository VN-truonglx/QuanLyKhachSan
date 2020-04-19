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
    public partial class frmCoManHinh : Form
    {
        DataTable tblCoMH;
        public frmCoManHinh()
        {
            InitializeComponent();
        }

        private void frmCoManHinh_Load(object sender, EventArgs e)
        {
            txtTenCoMH.Enabled = false;
            txtMaCoMH.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaCoMH,TenCoMH FROM tblCoManHinh";
            tblCoMH = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvCoManHinh.DataSource = tblCoMH; //Nguồn dữ liệu        
            dgvCoManHinh.Columns[0].HeaderText = "Mã Cỡ MH";
            dgvCoManHinh.Columns[1].HeaderText = "Tên Cỡ MH";


            dgvCoManHinh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvCoManHinh.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvCoManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCoMH.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaCoMH.Text = dgvCoManHinh.CurrentRow.Cells["MaCoMH"].Value.ToString();
            txtTenCoMH.Text = dgvCoManHinh.CurrentRow.Cells["TenCoMH"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaCoMH.Enabled = false;
            txtTenCoMH.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenCoMH.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaCoMH.Enabled = true; //cho phép nhập mới
            txtTenCoMH.Focus();
        }
        private void ResetValue()
        {
            txtMaCoMH.Text = "";
            txtTenCoMH.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCoMH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn cỡ màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCoMH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCoMH.Text.Trim().Length == 0) //nếu chưa nhập tên cỡ màn hình
            {
                MessageBox.Show("Bạn chưa nhập tên cỡ màn hình ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblCoManHinh SET TenCoMH=N'" + txtTenCoMH.Text.ToString() + "' WHERE MaCoMH=N'" + txtMaCoMH.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenCoMH.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCoMH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaCoMH.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblCoManHinh WHERE MaCoMH=N'" + txtMaCoMH.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenCoMH.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaCoMH.Text.Trim().Length == 0) //Nếu chưa nhập mã cỡ màn hình
            {
                MessageBox.Show("Bạn phải nhập mã cỡ màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCoMH.Focus();
                return;
            }
            if (txtTenCoMH.Text.Trim().Length == 0) //Nếu chưa nhập tên cỡ màn hình
            {
                MessageBox.Show("Bạn phải nhập tên cỡ màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCoMH.Focus();
                return;
            }
            sql = "Select MaCoMH From tblCoManHinh where MaCoMH=N'" + txtMaCoMH.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã cỡ màn hình  này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCoMH.Focus();
                return;
            }

            sql = "INSERT INTO tblCoManHinh VALUES(N'" +
                txtMaCoMH.Text + "',N'" + txtTenCoMH.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaCoMH.Enabled = false;
            txtTenCoMH.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaCoMH.Enabled = false;
            txtTenCoMH.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
