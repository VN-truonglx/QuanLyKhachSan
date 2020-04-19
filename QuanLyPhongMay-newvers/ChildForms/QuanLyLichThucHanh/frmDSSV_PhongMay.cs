using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh
{
    public partial class frmDSSV_PhongMay : Form
    {
        public frmDSSV_PhongMay()
        {
            InitializeComponent();
            txtPhongMay.Text = frmLichThucHanh.SelectedItem;
        }

        private void frmDSSV_PhongMay_Load(object sender, EventArgs e)
        {
            txtPhongMay.Enabled = false;
            DataTable tbl = ThucThiSQL.GetDataToTable("SELECT MaSV, TenSV FROM tblSinhVien WHERE MaPM = N'" + txtPhongMay.Text + "'");
            dataGridView_Dssv.DataSource = tbl;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_Dssv.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_Dssv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
