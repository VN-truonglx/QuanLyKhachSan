using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using QuanlyPhongMay.Class;

namespace QuanLyPhongMay
{

    public partial class FrmInDanhSach : Form

    {

        public FrmInDanhSach()
        {
            InitializeComponent();
        }
        private void FrmInDanhSach_Load(object sender, EventArgs e)
        {
            btnInDanhSach.Enabled = true;
            btnThoat.Enabled = true;

            if (cboMaMay.Text != "")
            {
                //LoadInfoHoaDon();
                btnInDanhSach.Enabled = true;
                btnThoat.Enabled = true;
            }
            LoadDataGridView();
            cboMaMay.DataSource =Functions.GetDataToTable("SELECT DISTINCT  MaPM FROM tblMayTinh");
            cboMaMay.ValueMember = "MaPM";
            cboMaMay.DisplayMember = "MaPM";
            cboMaMay.SelectedIndex = -1;
        }

        private void LoadDataGridView()
        {
            DataTable tbl;
            string sql = "select tblPhongMay.MaPM , MaMay, TenMay from tblPhongMay join tblMayTinh on tblPhongMay.MaPM=tblMayTinh.MaPM group by MaMay, TenMay , tblPhongMay.MaPM";
            tbl = QuanlyPhongMay.Class.Functions.GetDataToTable(sql);
            dgvInDanhSach.DataSource = tbl;

            dgvInDanhSach.Columns[0].HeaderText = "Mã Phòng Máy ";
            dgvInDanhSach.Columns[1].HeaderText = "Mã Máy ";
            dgvInDanhSach.Columns[2].HeaderText = "Tên Máy";
            dgvInDanhSach.Columns[0].Width = 80;
            dgvInDanhSach.Columns[1].Width = 130;
            dgvInDanhSach.Columns[2].Width = 100;
            dgvInDanhSach.AllowUserToAddRows = false;
            dgvInDanhSach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
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

            sql = "SELECT * from tblMayTinh where MaPM=N'" + cboMaMay.SelectedValue + "'";
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql = "Select * from tblMayTinh where MaPM =N'" + cboMaMay.SelectedValue + "' ";
            DataTable tbl;

            tbl = Functions.GetDataToTable(sql);
            dgvInDanhSach.DataSource = tbl;
        }
    }
}
