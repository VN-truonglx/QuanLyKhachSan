using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanlyPhongMay.Class;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLyPhongMay
{
    public partial class FrmPhongMay : Form
        
    {
        SqlConnection con = new SqlConnection();
        public FrmPhongMay()
        {
            InitializeComponent();
        }

        private void FrmPhongMay_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = localhost\MSSQLSERVER01; Initial Catalog = QlyPhongMay; Integrated Security = True";
            con.ConnectionString = connectionString;
            con.Open();
            loadDataGridView();
           
            if (cboMaPhongMay.Text != "")
            {
               
                btnIn.Enabled = true;
                btnThoat.Enabled = true;
            }
    
            cboMaPhongMay.DataSource = Functions.GetDataToTable("SELECT DISTINCT  MaPM FROM tblMayTinh");
            cboMaPhongMay.ValueMember = "MaPM";
            cboMaPhongMay.DisplayMember = "MaPM";
            cboMaPhongMay.SelectedIndex = -1;
            btnIn.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void loadDataGridView()
        {
            DataTable tbl;
            string sql = "SELECT * FROM tblPhongMay";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            dgvPhongMay.DataSource = tbl;
            //cboMaPhongMay.Text= tbl;
            //txtTenPhongMay.Text = tbl;
        }
        private void dgvPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaPhongMay.Text = dgvPhongMay.CurrentRow.Cells["MaPM"].Value.ToString();
            txtDiaDiem.Text = dgvPhongMay.CurrentRow.Cells["DiaDiem"].Value.ToString();
            txtTenPhongMay.Text = dgvPhongMay.CurrentRow.Cells["TenPM"].Value.ToString();
            txtSoMay.Text = dgvPhongMay.CurrentRow.Cells["SoMay"].Value.ToString();
            txtDienThoai.Text = dgvPhongMay.CurrentRow.Cells["DienThoai"].Value.ToString();
            cboMaPhongMay.Enabled = true;
            txtDiaDiem.Enabled = true;
            txtTenPhongMay.Enabled = true;
            txtSoMay.Enabled = true;
            txtDienThoai.Enabled = true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            cboMaPhongMay.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable tbl;
            string sql;
           
            if (cboMaPhongMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Mã phòng máy");
                cboMaPhongMay.Focus();
                return;
            }
            if (txtTenPhongMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Tên phòng máy");
                txtTenPhongMay.Focus();
            }
            sql = "UPDATE tblPhongMay SET TenPM ='" + txtTenPhongMay.Text + "',SoMay='" + txtSoMay.Text
                + "', DiaDiem='"+ txtDiaDiem.Text + "' where  MaPM='" + cboMaPhongMay.Text + "'" ;
             tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            loadDataGridView();
            cboMaPhongMay.Enabled = false;
            txtSoMay.Text = "";
            txtDiaDiem.Text = "";
            txtDienThoai.Text = "";


        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataTable tbl;
            string sql = "SELECT * FROM tblPhongMay";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaPhongMay.Text == "") //nếu chưa chọn cái nào
            {
                MessageBox.Show("Bạn chưa chọn cái nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblPhongMay WHERE MaPM =N'" + cboMaPhongMay.Text + "'";
                QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
                loadDataGridView();
                cboMaPhongMay.Enabled = false;
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (cboMaPhongMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập mã phòng máy");
                cboMaPhongMay.Focus();
                return;
            }
            if (txtTenPhongMay.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên phòng máy");
                txtTenPhongMay.Focus();
            }
            else
            {
                string sql = "insert into tblPhongMay values ( '" + cboMaPhongMay.Text.Trim() + "', '" + txtTenPhongMay.Text.Trim()+ "','"
                       + txtSoMay.Text.Trim()+"','"+ txtDiaDiem.Text.Trim()+"','"+ txtDienThoai.Text.Trim()+"' )" ;
                MessageBox.Show(sql);
                try
                {
                    QuanlyPhongMay.Class.Functions.RunSQL(sql);
                    loadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            cboMaPhongMay.Text = "";
            txtDiaDiem.Text = "";
            txtTenPhongMay.Text = "";
            txtSoMay.Text = "";
            txtDienThoai.Text = "";
            cboMaPhongMay.Enabled = true;
            txtTenPhongMay.Enabled = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
                  (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }



        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tVui lòng chờ...\n Đang cập nhật dữ liệu");
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblMayTinh;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Banking Acedemy Vietnam";
            exRange.Range["A2:E2"].MergeCells = true;
            exRange.Range["A2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:E2"].Value = "12 Chua Boc Street, Quang Trung Ward, Dong Da District, Hanoi, Vietnam";

            exRange.Range["F5:J5"].Font.Size = 16;
            exRange.Range["F5:J5"].Font.Bold = true;
            exRange.Range["F5:J5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["F5:J5"].MergeCells = true;
            exRange.Range["F5:J5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["F5:J5"].Value = "DANH SÁCH MÁY TÍNH THEO PHÒNG MÁY";

            sql = "SELECT * from tblMayTinh where MaPM=N'" + cboMaPhongMay.SelectedValue + "'";
            tblMayTinh = Functions.GetDataToTable(sql);
            exRange.Range["A11:O11"].Font.Bold = true;
            exRange.Range["A11:M11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A11"].ColumnWidth = 14;
            exRange.Range["C11"].ColumnWidth = 22;
            exRange.Range["D11:F11"].ColumnWidth = 18;
            exRange.Range["G11"].ColumnWidth = 16;
            exRange.Range["I11"].ColumnWidth = 16;
            exRange.Range["J11:N11"].ColumnWidth = 16;
            exRange.Range["K11"].ColumnWidth = 22;
            exRange.Range["O11"].ColumnWidth = 25;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã máy";
            exRange.Range["C11:C11"].Value = "Tên máy";
            exRange.Range["D11:D11"].Value = "Mã phòng máy";
            exRange.Range["E11:E11"].Value = "Mã ổ cứng";
            exRange.Range["F11:F11"].Value = "Mã dung lượng";
            exRange.Range["G11:G11"].Value = "Mã chip";
            exRange.Range["H11:H11"].Value = "Mã RAM";
            exRange.Range["I11:I11"].Value = "Mã tốc độ";
            exRange.Range["J11:J11"].Value = "Mã màn hình";
            exRange.Range["K11:K11"].Value = "Mã cỡ màn hình";
            exRange.Range["L11:L11"].Value = "Mã chuột";
            exRange.Range["M11:M11"].Value = "Mã bàn phím"; exRange.Range["N11:N11"].Value = "Mã ổ đĩa"; exRange.Range["O11:O11"].Value = "Ghi chú";


            for (hang = 0; hang < tblMayTinh.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblMayTinh.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblMayTinh.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblMayTinh.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exSheet.Name = "DANH SÁCH MÁY TÍNH";
            exApp.Visible = true;
        }

        private void cboMaPhongMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string sql = "Select * from tblMayTinh where MaPM =N'" + cboMaPhongMay.SelectedValue + "' ";
                DataTable tbl;

                tbl = Functions.GetDataToTable(sql);
                dgvPhongMay.DataSource = tbl;
            
        }
    }
    }



    



