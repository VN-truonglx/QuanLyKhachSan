using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSancode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDonGia.Enabled = false;
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;

            //Sua, Xoa, Luu, Huy not allow
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;


            loadDataGridView();
        }

        private void ResetValues()
        {

            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";

        }

        DataTable tbl;
        public void loadDataGridView()
        {
            string sql = "Select * from tblPhong";
            tbl = ThucThiSQL.GetDataToTable(sql);

            dataGridView_Phong.DataSource = tbl;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_Phong.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_Phong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dataGridView_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonGia.Text = dataGridView_Phong.CurrentRow.Cells["DonGia"].Value.ToString();
            txtMaPhong.Text = dataGridView_Phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dataGridView_Phong.CurrentRow.Cells["TenPhong"].Value.ToString();

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_Phong.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_Phong.EditMode = DataGridViewEditMode.EditProgrammatically;

            txtMaPhong.Enabled = false;
            txtDonGia.Enabled = true;
            txtTenPhong.Enabled = true;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;

            btnLuu.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtDonGia.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên phòng");
                txtTenPhong.Focus();
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đơn giá");
                txtDonGia.Focus();
                return;
            }

            string sql = "UPDATE tblPhong SET TenPhong = '" + txtTenPhong.Text.Trim() + "', DonGia = '" + txtDonGia.Text.Trim() + "' WHERE MaPhong = '" + txtMaPhong.Text.Trim() + "'";
            ThucThiSQL.RunSQL(sql);

            loadDataGridView();
            ResetValues();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //txtMaPhong.Enabled = false; -> Thừa vì đã có ở cellclick
            txtTenPhong.Enabled = false;
            txtDonGia.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            string sql = "DELETE from tblPhong WHERE MaPhong = '" + txtMaPhong.Text.Trim() + "' ";
            ThucThiSQL.RunSQL(sql);
            loadDataGridView();
            ResetValues();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtDonGia.Enabled = false;

            btnThem.Enabled = true;
            //Sua, Xoa, Luu, Huy not allow
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phòng");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên phòng");
                txtTenPhong.Focus();
                return;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đơn giá");
                txtDonGia.Focus();
                return;
            }

            //Kiểm tra khóa trùng
             sql = "SELECT MaPhong FROM tblPhong WHERE MaPhong=N'" + txtMaPhong.Text.Trim() + "'";
             if(ThucThiSQL.CheckKey(sql) == true)
                {
                    MessageBox.Show("Mã phòng '" +txtMaPhong.Text.Trim()+ "' đã tồn tại, vui lòng nhập mã khác!","Thông báo");
                    txtMaPhong.Focus();
                    txtMaPhong.Text = "";
                    return;
                }
            //SQL Insert into *table* values()
            sql = "INSERT INTO tblPhong(MaPhong,TenPhong,DonGia) VALUES('" + txtMaPhong.Text.Trim() + "','" + txtTenPhong.Text.Trim() + "','" + txtDonGia.Text.Trim() + "')";
            ThucThiSQL.RunSQL(sql);

            //Load lại lưới sau khi có thêm dữ liệu
            loadDataGridView();

            //Xóa các giá trị trong txtbox
            ResetValues();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtDonGia.Enabled = false;

            btnThem.Enabled = true;
            //Sua, Xoa, Luu, Huy not allow
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThucThiSQL.DisConnect();
            this.Close();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') ||
    (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
