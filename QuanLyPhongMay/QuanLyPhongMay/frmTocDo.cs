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
    public partial class frmTocDo : Form
    {
        DataTable tblTD;
        public frmTocDo()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaTocDo,TenTocDo FROM tblTocDo";
            tblTD = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvTocDo.DataSource = tblTD; //Nguồn dữ liệu        
            dgvTocDo.Columns[0].HeaderText = "Mã tốc độ";
            dgvTocDo.Columns[1].HeaderText = "Tên tốc độ";


            dgvTocDo.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvTocDo.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtTenTocDo.Enabled = true;
            ResetValue(); //Xoá trắng các textbox
            txtMaTocDo.Enabled = true; //cho phép nhập mới
            txtTenTocDo.Focus();
        }

        private void ResetValue()
        {
            txtMaTocDo.Text = "";
            txtTenTocDo.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTocDo.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTocDo.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblTocDo SET TenTocDo=N'" + txtTenTocDo.Text.ToString() +"' WHERE MaTocDo=N'" + txtMaTocDo.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            txtTenTocDo.Enabled = false;
            btnHuy.Enabled = true;
            btnThem.Enabled = true;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTocDo.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblTocDo WHERE MaTocDo=N'" + txtMaTocDo.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
                txtTenTocDo.Enabled = false;
            }
        }


       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaTocDo.Text.Trim().Length == 0) //Nếu chưa nhập mã tốc độ
            {
                MessageBox.Show("Bạn phải nhập mã tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTocDo.Focus();
                return;
            }
            if (txtTenTocDo.Text.Trim().Length == 0) //Nếu chưa nhập tên tốc độ
            {
                MessageBox.Show("Bạn phải nhập tên tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTocDo.Focus();
                return;
            }
            sql = "Select MaTocDo From tblTocDo where MaTocDo=N'" + txtMaTocDo.Text.Trim() + "'";
            if (Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("mã tốc độ này đã có, bạn phải nhập mã khác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTocDo.Focus();
                return;
            }

            sql = "INSERT INTO tblTocDo VALUES(N'" +
                txtMaTocDo.Text + "',N'" + txtTenTocDo.Text + "')";
            Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaTocDo.Enabled = false;
            txtTenTocDo.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            ResetValue();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaTocDo.Enabled = false;
            txtTenTocDo.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTocDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (tblTD.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTocDo.Text = dgvTocDo.CurrentRow.Cells["MaTocDo"].Value.ToString();
            txtTenTocDo.Text = dgvTocDo.CurrentRow.Cells["TenTocDo"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            txtMaTocDo.Enabled = false;
            txtTenTocDo.Enabled = true;
        }

        private void frmTocDo_Load_1(object sender, EventArgs e)
        {
            txtTenTocDo.Enabled = false;
            txtMaTocDo.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            LoadDataGridView();
        }

        
    }
}
