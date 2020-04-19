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
   
    public partial class frmBanPhim : Form
    {
        DataTable tblMaBP;
        public frmBanPhim()
        {
            InitializeComponent();
        }
        

        private void frmBanPhim_Load(object sender, EventArgs e)
        {
            txtTenBanPhim.Enabled = false;
            txtMaBanPhim.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaBanPhim,TenBanPhim FROM tblMaBanPhim";
            tblMaBP = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvBanPhim.DataSource = tblMaBP; //Nguồn dữ liệu        
            dgvBanPhim.Columns[0].HeaderText = "Mã Bàn Phím";
            dgvBanPhim.Columns[1].HeaderText = "Tên Bàn Phím";


            dgvBanPhim.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvBanPhim.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvBanPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblMaBP.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaBanPhim.Text = dgvBanPhim.CurrentRow.Cells["MaBanPhim"].Value.ToString();
            txtTenBanPhim.Text = dgvBanPhim.CurrentRow.Cells["TenBanPhim"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaBanPhim.Enabled = false;
            txtTenBanPhim.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenBanPhim.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaBanPhim.Enabled = true; //cho phép nhập mới
            txtTenBanPhim.Focus();
        }
        private void ResetValue()
        {
            txtMaBanPhim.Text = "";
            txtTenBanPhim.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblMaBP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBanPhim.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBanPhim.Text.Trim().Length == 0) //nếu chưa nhập tên bàn phím
            {
                MessageBox.Show("Bạn chưa nhập tên bàn phím ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMaBanPhim SET TenBanPhim=N'" + txtTenBanPhim.Text.ToString() + "' WHERE MaBanPhim=N'" + txtMaBanPhim.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenBanPhim.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMaBP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBanPhim.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMaBanPhim WHERE MaBanPhim=N'" + txtMaBanPhim.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenBanPhim.Enabled = false;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaBanPhim.Text.Trim().Length == 0) //Nếu chưa nhập mã bàn phím
            {
                MessageBox.Show("Bạn phải nhập mã bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBanPhim.Focus();
                return;
            }
            if (txtTenBanPhim.Text.Trim().Length == 0) //Nếu chưa nhập tên bàn phím
            {
                MessageBox.Show("Bạn phải nhập tên bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBanPhim.Focus();
                return;
            }
            sql = "Select MaBanPhim From tblMaBanPhim where MaBanPhim=N'" + txtMaBanPhim.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã bàn phím này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBanPhim.Focus();
                return;
            }

            sql = "INSERT INTO tblMaBanPhim VALUES(N'" +
                txtMaBanPhim.Text + "',N'" + txtTenBanPhim.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaBanPhim.Enabled = false;
            txtTenBanPhim.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBanPhim.Enabled = false;
            txtTenBanPhim.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
