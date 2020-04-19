using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongMay_newvers.ChildForms.TimKiem
{
    public partial class frmTimKiemLichThucHanh : Form
    {
        public frmTimKiemLichThucHanh()
        {
            InitializeComponent();
        }

        private void ResetValues()
        {
            cboMaPhongMay_TimKiem.Text = "";
            cboMaGiangVien_TimKiem.Text = "";
            cboMaLop_TimKiem.Text = "";

        }

        private void frmTimKiemLichThucHanh_Load(object sender, EventArgs e)
        {

            Load_comboBox();
            loadDataGridView();
            ResetValues();
        }

        private void Load_comboBox()
        {
            //Load cboMaPM tìm kiếm
            cboMaPhongMay_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaPM, TenPM FROM tblPhongMay");
            cboMaPhongMay_TimKiem.ValueMember = "MaPM";
            cboMaPhongMay_TimKiem.DisplayMember = "TenPM";
            cboMaPhongMay_TimKiem.SelectedIndex = -1;

            //Load cboMaGV tìm kiếm
            cboMaGiangVien_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaGV, TenGV FROM tblGiaoVien");
            cboMaGiangVien_TimKiem.ValueMember = "MaGV";
            cboMaGiangVien_TimKiem.DisplayMember = "TenGV";
            cboMaGiangVien_TimKiem.SelectedIndex = -1;

            //Load cboMaLop tìm kiếm
            cboMaLop_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaLop, TenLop FROM tblLop");
            cboMaLop_TimKiem.ValueMember = "MaLop";
            cboMaLop_TimKiem.DisplayMember = "TenLop";
            cboMaLop_TimKiem.SelectedIndex = -1;
        }

        public void loadDataGridView()
        {
            DataTable tbl;
            string sql = "Select MaSTT,Thu,NgayBD,NgayKT,MaPM,MaGV,MaCa,MaLop,MaMon from tblLichThucHanh";
            tbl = ThucThiSQL.GetDataToTable(sql);

            //Load dgv
            //loadDataGridView();
            dataGridView_TimKiemLTH.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLTH.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLTH.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Width columns
            dataGridView_TimKiemLTH.Columns[0].Width = 45; //MaLTH
            dataGridView_TimKiemLTH.Columns[1].Width = 78; //Thu
            dataGridView_TimKiemLTH.Columns[2].Width = 72; //NgayBD
            dataGridView_TimKiemLTH.Columns[3].Width = 72; //NgayKT
            dataGridView_TimKiemLTH.Columns[4].Width = 45; //MaPM
            dataGridView_TimKiemLTH.Columns[5].Width = 45; //MaGV
            dataGridView_TimKiemLTH.Columns[6].Width = 45; //MaCa
            dataGridView_TimKiemLTH.Columns[7].Width = 45; //MaLop
            dataGridView_TimKiemLTH.Columns[8].Width = 45; //MaMon

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaPhongMay_TimKiem.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phòng máy để tìm kiếm!");
                return;
            }
            if (cboMaGiangVien_TimKiem.Text == "")
            {
                MessageBox.Show("Chưa chọn mã giảng viên để tìm kiếm!");
                return;
            }
            if (cboMaLop_TimKiem.Text == "")
            {
                MessageBox.Show("Chưa chọn mã lớp để tìm kiếm!");
                return;
            }

            DataTable tbl;
            string sql = "SELECT MaSTT,Thu,NgayBD,NgayKT,MaPM,MaGV,MaCa,MaLop,MaMon FROM tblLichThucHanh WHERE (MaPM =N'" + cboMaPhongMay_TimKiem.SelectedValue + "' AND MaGV = N'" + cboMaGiangVien_TimKiem.SelectedValue + "' AND MaLop = N'" + cboMaLop_TimKiem.SelectedValue + "')";
            tbl = ThucThiSQL.GetDataToTable(sql);

            //Load dgv
            dataGridView_TimKiemLTH.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLTH.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLTH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
