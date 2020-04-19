namespace QuanLyPhongMay_newvers.ChildForms.TimKiem
{
    partial class frmTimKiemLichThucHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaLop_TimKiem = new System.Windows.Forms.ComboBox();
            this.cboMaGiangVien_TimKiem = new System.Windows.Forms.ComboBox();
            this.cboMaPhongMay_TimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_TimKiemLTH = new System.Windows.Forms.DataGridView();
            this.MaSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TimKiemLTH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cboMaLop_TimKiem);
            this.groupBox1.Controls.Add(this.cboMaGiangVien_TimKiem);
            this.groupBox1.Controls.Add(this.cboMaPhongMay_TimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 126);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm lịch thực hành";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(443, 70);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(364, 41);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaLop_TimKiem
            // 
            this.cboMaLop_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop_TimKiem.FormattingEnabled = true;
            this.cboMaLop_TimKiem.Location = new System.Drawing.Point(194, 77);
            this.cboMaLop_TimKiem.Name = "cboMaLop_TimKiem";
            this.cboMaLop_TimKiem.Size = new System.Drawing.Size(218, 28);
            this.cboMaLop_TimKiem.TabIndex = 15;
            // 
            // cboMaGiangVien_TimKiem
            // 
            this.cboMaGiangVien_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaGiangVien_TimKiem.FormattingEnabled = true;
            this.cboMaGiangVien_TimKiem.Location = new System.Drawing.Point(589, 28);
            this.cboMaGiangVien_TimKiem.Name = "cboMaGiangVien_TimKiem";
            this.cboMaGiangVien_TimKiem.Size = new System.Drawing.Size(218, 28);
            this.cboMaGiangVien_TimKiem.TabIndex = 14;
            // 
            // cboMaPhongMay_TimKiem
            // 
            this.cboMaPhongMay_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhongMay_TimKiem.FormattingEnabled = true;
            this.cboMaPhongMay_TimKiem.Location = new System.Drawing.Point(194, 29);
            this.cboMaPhongMay_TimKiem.Name = "cboMaPhongMay_TimKiem";
            this.cboMaPhongMay_TimKiem.Size = new System.Drawing.Size(218, 28);
            this.cboMaPhongMay_TimKiem.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã phòng máy";
            // 
            // dataGridView_TimKiemLTH
            // 
            this.dataGridView_TimKiemLTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TimKiemLTH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSTT,
            this.Thu,
            this.NgayBD,
            this.NgayKT,
            this.MaPM,
            this.MaGV,
            this.MaCa,
            this.MaLop,
            this.MaMon});
            this.dataGridView_TimKiemLTH.Location = new System.Drawing.Point(12, 150);
            this.dataGridView_TimKiemLTH.Name = "dataGridView_TimKiemLTH";
            this.dataGridView_TimKiemLTH.RowHeadersWidth = 62;
            this.dataGridView_TimKiemLTH.RowTemplate.Height = 28;
            this.dataGridView_TimKiemLTH.Size = new System.Drawing.Size(836, 390);
            this.dataGridView_TimKiemLTH.TabIndex = 20;
            // 
            // MaSTT
            // 
            this.MaSTT.DataPropertyName = "MaSTT";
            this.MaSTT.HeaderText = "Mã LTH";
            this.MaSTT.MinimumWidth = 8;
            this.MaSTT.Name = "MaSTT";
            this.MaSTT.Width = 150;
            // 
            // Thu
            // 
            this.Thu.DataPropertyName = "Thu";
            this.Thu.HeaderText = "Thứ";
            this.Thu.MinimumWidth = 8;
            this.Thu.Name = "Thu";
            this.Thu.Width = 150;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.MinimumWidth = 8;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Width = 150;
            // 
            // NgayKT
            // 
            this.NgayKT.DataPropertyName = "NgayKT";
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 8;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Width = 150;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã phòng máy";
            this.MaPM.MinimumWidth = 8;
            this.MaPM.Name = "MaPM";
            this.MaPM.Width = 150;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MinimumWidth = 8;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 150;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.MinimumWidth = 8;
            this.MaCa.Name = "MaCa";
            this.MaCa.Width = 150;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 8;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 150;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 8;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 150;
            // 
            // frmTimKiemLichThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 552);
            this.Controls.Add(this.dataGridView_TimKiemLTH);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiemLichThucHanh";
            this.Text = "frmTimKiemLichThucHanh";
            this.Load += new System.EventHandler(this.frmTimKiemLichThucHanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TimKiemLTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaLop_TimKiem;
        private System.Windows.Forms.ComboBox cboMaGiangVien_TimKiem;
        private System.Windows.Forms.ComboBox cboMaPhongMay_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_TimKiemLTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
    }
}