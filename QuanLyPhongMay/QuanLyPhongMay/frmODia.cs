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
    
    public partial class frmODia : Form
    {
        DataTable tblOdia;
        public frmODia()
        {
            InitializeComponent();
        }

        private void frmODia_Load(object sender, EventArgs e)
        {
            txtTenODia.Enabled = false;
            txtMaODia.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaODia,TenODia FROM tblMaODia";
            tblOdia = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvODia.DataSource = tblOdia; //Nguồn dữ liệu        
            dgvODia.Columns[0].HeaderText = "Mã ổ đĩa";
            dgvODia.Columns[1].HeaderText = "Tên ổ đĩa";


            dgvODia.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvODia.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp

        }

        private void dgvODia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblOdia.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaODia.Text = dgvODia.CurrentRow.Cells["MaODia"].Value.ToString();
            txtTenODia.Text = dgvODia.CurrentRow.Cells["TenODia"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaODia.Enabled = false;
            txtTenODia.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenODia.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaODia.Enabled = true; //cho phép nhập mới
            txtTenODia.Focus();
        }
        private void ResetValue()
        {
            txtMaODia.Text = "";
            txtTenODia.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblOdia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn ổ đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaODia.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenODia.Text.Trim().Length == 0) //nếu chưa nhập tên ổ đĩa
            {
                MessageBox.Show("Bạn chưa nhập tên ổ đĩa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMaODia SET TenODia=N'" + txtTenODia.Text.ToString() + "' WHERE MaODia=N'" + txtMaODia.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenODia.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblOdia.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaODia.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMaODia WHERE MaODia=N'" + txtMaODia.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenODia.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaODia.Text.Trim().Length == 0) //Nếu chưa nhập mã ổ đĩa
            {
                MessageBox.Show("Bạn phải nhập mã ổ đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaODia.Focus();
                return;
            }
            if (txtTenODia.Text.Trim().Length == 0) //Nếu chưa nhập tên ổ đĩa
            {
                MessageBox.Show("Bạn phải nhập tên ổ đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenODia.Focus();
                return;
            }
            sql = "Select MaODia From tblMaODia where MaODia=N'" + txtMaODia.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã ổ đĩa này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaODia.Focus();
                return;
            }

            sql = "INSERT INTO tblMaODia VALUES(N'" +
                txtMaODia.Text + "',N'" + txtTenODia.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaODia.Enabled = false;
            txtTenODia.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaODia.Enabled = false;
            txtTenODia.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
