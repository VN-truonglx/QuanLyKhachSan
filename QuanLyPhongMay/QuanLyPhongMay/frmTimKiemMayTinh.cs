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
    public partial class frmTimKiemMayTinh : Form
    {
        
        public frmTimKiemMayTinh()
        {
            InitializeComponent();
        }

        private void frmTimKiemMayTinh_Load(object sender, EventArgs e)
        {
            Load_comboBox();
            LoadDataGridView();
            ResetValues();
        }
        private void ResetValues()
        {
            cboMaPhongMay.Text = "";
            cboMaChip.Text = "";
            cboMaRam.Text = "";
        }

        private void Load_comboBox()
        {
            //Load cboMaPM tìm kiếm
            cboMaPhongMay.DataSource = Functions.GetDataToTable("SELECT MaPM, TenPM FROM tblPhongMay");
            cboMaPhongMay.ValueMember = "MaPM";
            cboMaPhongMay.DisplayMember = "TenPM";
            cboMaPhongMay.SelectedIndex = -1;

            //Load cboMaChip tìm kiếm
            cboMaChip.DataSource = Functions.GetDataToTable("SELECT MaChip, TenChip FROM tblChip");
            cboMaChip.ValueMember = "MaChip";
            cboMaChip.DisplayMember = "TenChip";
            cboMaChip.SelectedIndex = -1;

            //Load cboMaRam tìm kiếm
            cboMaRam.DataSource = Functions.GetDataToTable("SELECT MaRam, TenRam FROM tblRAM");
            cboMaRam.ValueMember = "MaRam";
            cboMaRam.DisplayMember = "TenRam";
            cboMaRam.SelectedIndex = -1;
        }

        public void LoadDataGridView()
        {

            DataTable tbl;
            string sql = "Select * from tblMayTinh";
            tbl = Functions.GetDataToTable(sql);

            //Load dgv
            //loadDataGridView();
            dgvTimKiemMayTinh.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvTimKiemMayTinh.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvTimKiemMayTinh.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaPhongMay.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phòng máy để tìm kiếm!");
                return;
            }
            if (cboMaRam.Text == "")
            {
                MessageBox.Show("Chưa chọn mã RAM để tìm kiếm!");
                return;
            }
            if (cboMaChip.Text == "")
            {
                MessageBox.Show("Chưa chọn mã chíp để tìm kiếm!");
                return;
            }

            DataTable tbl;
            string sql = "SELECT * FROM tblMayTinh WHERE (MaPM =N'" 
            +cboMaPhongMay.SelectedValue + "' AND MaRAM= N'" + cboMaRam.SelectedValue + "' AND MaChip = N'" + cboMaChip.SelectedValue + "')";
            tbl =Functions.GetDataToTable(sql);

            //Load dgv
            dgvTimKiemMayTinh.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvTimKiemMayTinh.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvTimKiemMayTinh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
    }
