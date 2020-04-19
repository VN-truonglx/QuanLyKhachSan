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
    public partial class frmOCung : Form
    {
        DataTable tblOcung;
        public frmOCung()
        {
            InitializeComponent();
        }

        private void frmOCung_Load(object sender, EventArgs e)
        {
            txtTenOCung.Enabled = false;
            txtMaOCung.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaOCung,TenOCung FROM tblOCung";
            tblOcung = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvOCung.DataSource = tblOcung; //Nguồn dữ liệu        
            dgvOCung.Columns[0].HeaderText = "Mã ram";
            dgvOCung.Columns[1].HeaderText = "Tên ram";


            dgvOCung.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvOCung.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvOCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblOcung.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaOCung.Text = dgvOCung.CurrentRow.Cells["MaOCung"].Value.ToString();
            txtTenOCung.Text = dgvOCung.CurrentRow.Cells["TenOCung"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaOCung.Enabled = false;
            txtTenOCung.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenOCung.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaOCung.Enabled = true; //cho phép nhập mới
            txtTenOCung.Focus();
        }

        private void ResetValue()
        {
            txtMaOCung.Text = "";
            txtTenOCung.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblOcung.Rows.Count == 0)
            {
                MessageBox.Show("Không còn ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaOCung.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenOCung.Text.Trim().Length == 0) //nếu chưa nhập tên ổ đĩa
            {
                MessageBox.Show("Bạn chưa nhập tên ổ cứng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblOCung SET TenODia=N'" + txtTenOCung.Text.ToString() + "' WHERE MaOCung=N'" + txtMaOCung.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenOCung.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblOcung.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaOCung.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblOCung WHERE MaOCung=N'" + txtMaOCung.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenOCung.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaOCung.Text.Trim().Length == 0) //Nếu chưa nhập mã ổ cứng
            {
                MessageBox.Show("Bạn phải nhập mã ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaOCung.Focus();
                return;
            }
            if (txtTenOCung.Text.Trim().Length == 0) //Nếu chưa nhập tên ổ cứng
            {
                MessageBox.Show("Bạn phải nhập tên ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenOCung.Focus();
                return;
            }
            sql = "Select MaOCung From tblOCung where MaOCung=N'" + txtMaOCung.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã ổ cứng này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaOCung.Focus();
                return;
            }

            sql = "INSERT INTO tblOCung VALUES(N'" +
                txtMaOCung.Text + "',N'" + txtTenOCung.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaOCung.Enabled = false;
            txtTenOCung.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaOCung.Enabled = false;
            txtTenOCung.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}