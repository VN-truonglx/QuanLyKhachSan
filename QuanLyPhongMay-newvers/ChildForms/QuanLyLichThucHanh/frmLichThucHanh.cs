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
    public partial class frmLichThucHanh : Form
    {
        public frmLichThucHanh()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {

            txtMaLTH.Text = "";
            txtThu.Text = "";

            dtpNgayBatDau.CustomFormat = " "; //Xóa trắng
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;

            dtpNgayKetThuc.CustomFormat = " "; //Xóa trắng
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;

            cboMaPhongMay.SelectedValue = "";
            cboMaGiangVien.SelectedValue = "";
            cboMaCa.SelectedValue = "";
            cboMaLop.SelectedValue = "";
            cboMaMon.SelectedValue = "";

            dataGridView_Dssv.DataSource = false; //-> Xóa hết (name) trong dataGridView_Dssv, tự điền thủ công
        }
        private void LichThucHanh_Load(object sender, EventArgs e)
        {
            //ThucThiSQL.FillCombo("SELECT MaPM, TenPM FROM tblPhongMay", cboMaPhongMay, "MaPM", "TenPM");

            //dataGridView_LTH.Rows.Clear();
            txtMaLTH.Enabled = false;
            txtThu.Enabled = false;

            dtpNgayBatDau.Enabled = false;
            dtpNgayBatDau.CustomFormat = " "; //Xóa trắng
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Enabled = false;
            dtpNgayKetThuc.CustomFormat = " "; //Xóa trắng
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;

            cboMaPhongMay.Enabled = false;
            cboMaGiangVien.Enabled = false;
            cboMaCa.Enabled = false;
            cboMaLop.Enabled = false;
            cboMaMon.Enabled = false;


            btnXemDssv.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            Load_comboBox();
            ResetValues();

        }

        private void Load_comboBox()
        {
            //Load cboMaLichThucHanh_TimKiem
            cboMaLichThucHanh_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaSTT FROM tblLichThucHanh");
            cboMaLichThucHanh_TimKiem.ValueMember = "MaSTT";
            cboMaLichThucHanh_TimKiem.DisplayMember = "MaSTT";
            cboMaLichThucHanh_TimKiem.SelectedIndex = -1;

            //Load cboThu
            cboThu.DataSource = ThucThiSQL.GetDataToTable("SELECT Thu FROM (VALUES ('2'), ('3'), ('4'), ('5'), ('6'), ('7'), ('CN')) AS tbl(Thu)");
            cboThu.ValueMember = "Thu";
            cboThu.DisplayMember = "Thu";
            cboThu.SelectedIndex = -1;

            //Load cboMaPM
            cboMaPhongMay.DataSource = ThucThiSQL.GetDataToTable("SELECT MaPM,TenPM FROM tblPhongMay");
            cboMaPhongMay.ValueMember = "MaPM";
            cboMaPhongMay.DisplayMember = "TenPM";
            cboMaPhongMay.SelectedIndex = -1;

            //Load cboMaGiangVien
            cboMaGiangVien.DataSource = ThucThiSQL.GetDataToTable("SELECT MaGV,TenGV FROM tblGiaoVien");
            cboMaGiangVien.ValueMember = "MaGV";
            cboMaGiangVien.DisplayMember = "TenGV";
            cboMaGiangVien.SelectedIndex = -1;

            //Load cboMaCa
            cboMaCa.DataSource = ThucThiSQL.GetDataToTable("SELECT MaCa,TenCa FROM tblCaHoc");
            cboMaCa.ValueMember = "MaCa";
            cboMaCa.DisplayMember = "TenCa";
            cboMaCa.SelectedIndex = -1;

            //Load cboMaLop
            cboMaLop.DataSource = ThucThiSQL.GetDataToTable("SELECT MaLop,TenLop FROM tblLop");
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.SelectedIndex = -1;

            //Load cboMaMon
            cboMaMon.DataSource = ThucThiSQL.GetDataToTable("SELECT MaMon,TenMon FROM tblMonThucHanh");
            cboMaMon.ValueMember = "MaMon";
            cboMaMon.DisplayMember = "TenMon";
            cboMaMon.SelectedIndex = -1;
        }

        public void loadDataGridView()
        {
            DataTable tbl;
            string sql = "SELECT MaSV, TenSV FROM tblSinhVien WHERE MaPM = N'" + cboMaPhongMay.SelectedValue + "'";
            tbl = ThucThiSQL.GetDataToTable(sql);

            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy"; //Hiển thị năm/ngày/tháng
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy"; 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;

            dataGridView_Dssv.Columns[0].HeaderText = "Mã sinh viên";
            dataGridView_Dssv.Columns[1].HeaderText = "Tên sinh viên";


            dataGridView_Dssv.Columns[0].Width = 150;
            dataGridView_Dssv.Columns[1].Width = 100;

            //loadDataGridView.Datasource;
            dataGridView_Dssv.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_Dssv.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_Dssv.EditMode = DataGridViewEditMode.EditProgrammatically;

        }


        public void btnXemDssv_Click(object sender, EventArgs e)
        {
            if (cboMaPhongMay.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa có Mã phòng máy nào được chọn");
                
            }
            else
            {
                SelectedItem = cboMaPhongMay.SelectedValue.ToString();
                new frmDSSV_PhongMay().ShowDialog();
            }
        }

        private void cboMaPhongMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaPhongMay.SelectedIndex > -1)
                {
                    DataTable tbl = ThucThiSQL.GetDataToTable("SELECT MaSV, TenSV FROM tblSinhVien WHERE MaPM = N'" + cboMaPhongMay.SelectedValue + "'");
                    dataGridView_Dssv.DataSource = tbl;
                    loadDataGridView();
                }
                else
                {
                    dataGridView_Dssv.Rows.Clear();
                    //dataGridView_Dssv.DataSource = null;
                }
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaLTH.Enabled = true;
            txtThu.Enabled = true;

            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;

            cboMaPhongMay.Enabled = true;
            cboMaCa.Enabled = true;
            cboMaGiangVien.Enabled = true;
            cboMaMon.Enabled = true;
            cboMaLop.Enabled = true;

            btnXemDssv.Enabled = true;
            btnLuu.Enabled = true;
            btnHuyBo.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //loadDataGridView();
            ResetValues();

            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddDays(1);

            //Để sau ResetValues();
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy"; //Hiển thị năm/ngày/tháng
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            txtMaLTH.Enabled = false;
            txtThu.Enabled = true;

            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;

            cboMaPhongMay.Enabled = true;
            cboMaCa.Enabled = true;
            cboMaGiangVien.Enabled = true;
            cboMaMon.Enabled = true;
            cboMaLop.Enabled = true;


      //      string sql;
      //          sql = "UPDATE tblLichThucHanh SET Thu=N'" + txtThu.Text.Trim() + "' ," +
      //" NgayBD=N'" + dtpNgayBatDau.Value + "' ," +
      //" NgayKT=N'" + dtpNgayKetThuc.Value + "' ," +
      //" MaPM=N'" + cboMaPhongMay.SelectedValue + "' ," +
      //" MaCa=N'" + cboMaCa.SelectedValue + "' ," +
      //" MaGV=N'" + cboMaGiangVien.SelectedValue + "' ," +
      //" MaMon=N'" + cboMaMon.SelectedValue + "' ," +
      //" MaLop=N'" + cboMaLop.SelectedValue + "' WHERE MaSTT =N'" + txtMaLTH.Text.Trim() + "'";
      //          ThucThiSQL.RunSQL(sql);
      //          loadDataGridView();
            

            btnXemDssv.Enabled = true;
            btnLuu.Enabled = true;
            btnHuyBo.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaLTH.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Lịch thực hành");
                txtMaLTH.Focus();
                return;
            }
            if (txtThu.Text == "")
            {
                MessageBox.Show("Bạn cần nhập Thứ");
                txtThu.Focus();
                return;
            }
            if (cboMaPhongMay.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn cần chọn Mã phòng máy");
                cboMaPhongMay.Focus();
                return;
            }
            if (cboMaGiangVien.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn cần chọn Mã giảng viên");
                cboMaGiangVien.Focus();
                return;
            }
            if (cboMaCa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn cần chọn Mã ca");
                cboMaCa.Focus();
                return;
            }
            if (cboMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn cần chọn Mã lớp");
                cboMaLop.Focus();
                return;
            }
            if (cboMaMon.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn cần chọn Mã môn");
                cboMaMon.Focus();
                return;
            }

            //dtpNgayBatDau.Value = Convert.ToDateTime(dtpNgayBatDau.Value);
            //dtpNgayKetThuc.Value = Convert.ToDateTime(dtpNgayKetThuc.Value);

            string sql;
            if (txtMaLTH.Enabled == false) //TH update dữ liệu liệu
            {
                sql = "UPDATE tblLichThucHanh SET Thu=N'" + txtThu.Text.Trim() + "' ," +
      " NgayBD=N'" + Convert.ToDateTime(dtpNgayBatDau.Value) + "' ," +
      " NgayKT=N'" + Convert.ToDateTime(dtpNgayKetThuc.Value) + "' ," +
      " MaPM=N'" + cboMaPhongMay.SelectedValue + "' ," +
      " MaCa=N'" + cboMaCa.SelectedValue + "' ," +
      " MaGV=N'" + cboMaGiangVien.SelectedValue + "' ," +
      " MaMon=N'" + cboMaMon.SelectedValue + "' ," +
      " MaLop=N'" + cboMaLop.SelectedValue + "' WHERE MaSTT =N'" + txtMaLTH.Text.Trim() + "'";
                ThucThiSQL.RunSQL(sql);
                loadDataGridView();
            }
            else //TH thêm dữ liệu mới
            {
                sql = "SELECT MaSTT FROM tblLichThucHanh WHERE MaSTT=N'" + txtMaLTH.Text.Trim() + "'";
                if (ThucThiSQL.CheckKey(sql) == true)
                {
                    MessageBox.Show("Mã lịch thực hành '" + txtMaLTH.Text.Trim() + "' đã tồn tại, vui lòng nhập mã khác!", "Thông báo");
                    txtMaLTH.Text = "";
                    txtMaLTH.Focus();
                    return;
                }

                //1 lớp không được thực hành 2 môn trong cùng một lịch thực hành:
                //Kiểm tra Lớp, Môn, Ca, Thứ, Ngày BD có trùng?
                sql = "SELECT MaLop,MaMon,MaCa,Thu,NgayBD_FORMATTED FROM tblLichThucHanh WHERE MaLop=N'" + cboMaLop.SelectedValue + "' AND MaMon=N'" + cboMaMon.SelectedValue + "' AND MaCa=N'" + cboMaCa.SelectedValue + "' AND Thu=N'" + txtThu.Text + "' AND NgayBD_FORMATTED=N'" + dtpNgayBatDau.Text + "'";
                if (ThucThiSQL.CheckKey(sql) == true)
                {
                    MessageBox.Show("Lớp '" + cboMaLop.SelectedValue + "' đang tồn tại lịch thực hành môn '" + cboMaMon.SelectedValue + "'!", "Thông báo");
                    txtMaLTH.Text = "";
                    txtMaLTH.Focus();
                    return;
                }

                // 1 GV không được dậy 2 lớp trong cùng 1 lịch:
                //Kiểm tra GV, Lớp, Ca, Thứ, Ngày BD có trùng
                sql = "SELECT MaGV,MaLop,MaCa,Thu,NgayBD_FORMATTED FROM tblLichThucHanh WHERE MaGV=N'" + cboMaGiangVien.SelectedValue + "' AND MaLop=N'" + cboMaLop.SelectedValue + "' AND MaCa=N'" + cboMaCa.SelectedValue + "' AND Thu=N'" + txtThu.Text + "' AND NgayBD_FORMATTED=N'" + dtpNgayBatDau.Text + "'";
                if (ThucThiSQL.CheckKey(sql) == true)
                {
                    MessageBox.Show("GV '" + cboMaLop.SelectedValue + "' đang tồn lại lịch dạy lớp '" + cboMaLop.SelectedValue + "'!", "Thông báo");
                    txtMaLTH.Text = "";
                    txtMaLTH.Focus();
                    return;
                }
                else
                {

                    //SQL Insert into tblLichThucHanh values()
                    sql = "INSERT INTO tblLichThucHanh(MaSTT,Thu,NgayBD,NgayKT,MaPM,MaCa,MaGV,MaMon,MaLop) VALUES(N'" + txtMaLTH.Text.Trim() + "',N'" 
                        + txtThu.Text.Trim() + "',N'" 
                        + Convert.ToDateTime(dtpNgayBatDau.Value) + "',N'" 
                        + Convert.ToDateTime(dtpNgayKetThuc.Value) + "',N'" 
                        + cboMaPhongMay.SelectedValue + "',N'" 
                        + cboMaCa.SelectedValue + "',N'" 
                        + cboMaGiangVien.SelectedValue + "',N'" 
                        + cboMaMon.SelectedValue + "',N'" 
                        + cboMaLop.SelectedValue + "') ";
                    ThucThiSQL.RunSQL(sql);
                    loadDataGridView();

                }
            }

            txtMaLTH.Enabled = false;
            txtThu.Enabled = false;

            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;

            cboMaPhongMay.Enabled = false;
            cboMaGiangVien.Enabled = false;
            cboMaCa.Enabled = false;
            cboMaLop.Enabled = false;
            cboMaMon.Enabled = false;

            btnXemDssv.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            //Load_comboBox();
            cboMaLichThucHanh_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaSTT FROM tblLichThucHanh");
            ResetValues();

        }

        public static string SelectedItem;

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

            //loadDataGridView();
            dataGridView_Dssv.DataSource = false;
            txtMaLTH.Enabled = false;
            txtThu.Enabled = false;

            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;


            cboMaPhongMay.Enabled = false;
            cboMaCa.Enabled = false;
            cboMaGiangVien.Enabled = false;
            cboMaMon.Enabled = false;
            cboMaLop.Enabled = false;

            btnXemDssv.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Load_comboBox();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from tblLichThucHanh WHERE MaSTT = '" + txtMaLTH.Text.Trim() + "' ";
            ThucThiSQL.RunSQL(sql);

            ResetValues();
            cboMaLichThucHanh_TimKiem.DataSource = ThucThiSQL.GetDataToTable("SELECT MaSTT FROM tblLichThucHanh");
            txtMaLTH.Enabled = false;
            txtThu.Enabled = false;

            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;

            cboMaPhongMay.Enabled = false;
            cboMaGiangVien.Enabled = false;
            cboMaCa.Enabled = false;
            cboMaLop.Enabled = false;
            cboMaMon.Enabled = false;

            btnXemDssv.Enabled = false;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dataGridView_LTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLTH.Enabled = false;
            txtThu.Enabled = true;

            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;

            cboMaPhongMay.Enabled = true;
            cboMaCa.Enabled = true;
            cboMaGiangVien.Enabled = true;
            cboMaMon.Enabled = true;
            cboMaLop.Enabled = true;

            btnXemDssv.Enabled = true;
            btnLuu.Enabled = false;
            btnHuyBo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ThucThiSQL.DisConnect();
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaLichThucHanh_TimKiem.Text == "")
            {
                MessageBox.Show("Chưa chọn mã lịch thực hành để tìm kiếm!");
                return;
            }

            DataTable tbl;
            //Hiển thị thông tin lịch thực hành
            string sql = "SELECT MaSTT,Thu,NgayBD_FORMATTED,NgayKT_FORMATTED,MaPM,MaGV,MaCa,MaLop,MaMon FROM tblLichThucHanh WHERE MaSTT =N'" + cboMaLichThucHanh_TimKiem.Text + "'";
            tbl = ThucThiSQL.GetDataToTable(sql);

            //Mã lịch thực hành
            txtMaLTH.Text = tbl.Rows[0][0].ToString();

            //Thứ
            txtThu.Text = tbl.Rows[0][1].ToString();

            //Ngày bắt đầu
            dtpNgayBatDau.Value = DateTime.ParseExact(tbl.Rows[0][2].ToString(),"dd/MM/yyyy", null);

            //Ngày kết thúc
            dtpNgayKetThuc.Value = DateTime.ParseExact(tbl.Rows[0][3].ToString(), "dd/MM/yyyy", null);

            //combobox tham chiếu
            cboMaPhongMay.SelectedValue = tbl.Rows[0][4];
            cboMaGiangVien.SelectedValue = tbl.Rows[0][5].ToString();
            cboMaCa.SelectedValue = tbl.Rows[0][6].ToString();
            cboMaLop.SelectedValue = tbl.Rows[0][7].ToString();
            cboMaMon.SelectedValue = tbl.Rows[0][8].ToString();

            btnThem.Enabled = true;
            btnSua.Enabled = true;

        }
        //Disable default cell selection in datagridView
        private void dataGridView_Dssv_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Dssv.ClearSelection();
        }

    }
}
