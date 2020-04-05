using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QliKSan.Class;

namespace QliKSan
{
    public partial class frmMain : Form
    {
        DataTable tblPhong;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtMaPhong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            LoadDataGV();


        }
        private void LoadDataGV()
        {
            string sql;
            sql = "SELECT * FROM tblPhong";
            tblPhong = Class.Functions.LayDulieuVaoBang(sql); 
            dgvPhong.DataSource = tblPhong; //Nguồn dữ liệu            
            
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhong.Focus();
                return;
            }
            if (tblPhong.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhong.Text = dgvPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dgvPhong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtDonGia.Text = dgvPhong.CurrentRow.Cells["DonGia"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ClearTextbox(); 
            txtMaPhong.Enabled = true; 
            txtMaPhong.Focus();
        }
        private void ClearTextbox()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; 
            if (txtMaPhong.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenPhong.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGia.Focus();
                return;
            }
            sql = "Select MaPhong From tblPhong where MaPhong=N'" + txtMaPhong.Text.Trim() + "'";
            if (Class.Functions.KtraKhoaChinh(sql))
            {
                MessageBox.Show("Mã phòng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }

            sql = "INSERT INTO tblPhong VALUES(N'" +
                txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + txtDonGia.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGV(); //Nạp lại DataGridView
            ClearTextbox();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn chưa nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblPhong SET TenPhong=N'" +txtTenPhong.Text.ToString() + "', DonGia=N'" + txtDonGia.Text.ToString() + "' " +
                "WHERE MaPhong=N'" + txtMaPhong.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGV();
            ClearTextbox();

            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblPhong WHERE MaPhong=N'" + txtMaPhong.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGV();
               ClearTextbox();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextbox();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;
        }
    }
}
