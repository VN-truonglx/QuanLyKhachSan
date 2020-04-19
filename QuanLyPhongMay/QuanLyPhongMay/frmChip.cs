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
    public partial class frmChip : Form
    {
        DataTable tblchip;
        public frmChip()
        {
            InitializeComponent();
        }

        private void frmChip_Load(object sender, EventArgs e)
        {
            txtTenChip.Enabled = false;
            txtMaChip.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaChip,TenChip FROM tblChip";
            tblchip = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvChip.DataSource = tblchip; //Nguồn dữ liệu        
            dgvChip.Columns[0].HeaderText = "Mã Chip";
            dgvChip.Columns[1].HeaderText = "Tên Chip";


            dgvChip.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvChip.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvChip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblchip.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChip.Text = dgvChip.CurrentRow.Cells["MaChip"].Value.ToString();
            txtTenChip.Text = dgvChip.CurrentRow.Cells["TenCoMH"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaChip.Enabled = false;
            txtTenChip.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenChip.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaChip.Enabled = true; //cho phép nhập mới
            txtTenChip.Focus();
        }
        private void ResetValue()
        {
            txtMaChip.Text = "";
            txtTenChip.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblchip.Rows.Count == 0)
            {
                MessageBox.Show("Không còn chíp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChip.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChip.Text.Trim().Length == 0) //nếu chưa nhập tên chip
            {
                MessageBox.Show("Bạn chưa nhập tên chip ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChip SET TenChip=N'" + txtTenChip.Text.ToString() + "' WHERE MaChip=N'" + txtMaChip.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenChip.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblchip.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChip.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChip WHERE MaChip=N'" + txtMaChip.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenChip.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaChip.Text.Trim().Length == 0) //Nếu chưa nhập mã chíp
            {
                MessageBox.Show("Bạn phải nhập mã chíp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChip.Focus();
                return;
            }
            if (txtTenChip.Text.Trim().Length == 0) //Nếu chưa nhập tên chíp
            {
                MessageBox.Show("Bạn phải nhập tên chíp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChip.Focus();
                return;
            }
            sql = "Select MaChip From tblChip where MaChip=N'" + txtMaChip.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã chip này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChip.Focus();
                return;
            }

            sql = "INSERT INTO tblChip VALUES(N'" +
                txtMaChip.Text + "',N'" + txtTenChip.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChip.Enabled = false;
            txtTenChip.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaChip.Enabled = false;
            txtTenChip.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
