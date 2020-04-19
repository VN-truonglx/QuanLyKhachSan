namespace QuanLyPhongMay
{
    partial class FrmPhongMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongMay));
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoMay = new System.Windows.Forms.TextBox();
            this.lblTenPhongMay = new System.Windows.Forms.Label();
            this.lblSoMay = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaPhongMay = new System.Windows.Forms.Label();
            this.dgvPhongMay = new System.Windows.Forms.DataGridView();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhongMay = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.cboMaPhongMay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(494, 105);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 22);
            this.txtDienThoai.TabIndex = 18;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtSoMay
            // 
            this.txtSoMay.Location = new System.Drawing.Point(494, 56);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.Size = new System.Drawing.Size(150, 22);
            this.txtSoMay.TabIndex = 17;
            this.txtSoMay.Text = "0";
            // 
            // lblTenPhongMay
            // 
            this.lblTenPhongMay.AutoSize = true;
            this.lblTenPhongMay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhongMay.Location = new System.Drawing.Point(6, 106);
            this.lblTenPhongMay.Name = "lblTenPhongMay";
            this.lblTenPhongMay.Size = new System.Drawing.Size(130, 21);
            this.lblTenPhongMay.TabIndex = 14;
            this.lblTenPhongMay.Text = "Tên Phòng Máy";
            // 
            // lblSoMay
            // 
            this.lblSoMay.AutoSize = true;
            this.lblSoMay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMay.Location = new System.Drawing.Point(405, 57);
            this.lblSoMay.Name = "lblSoMay";
            this.lblSoMay.Size = new System.Drawing.Size(69, 21);
            this.lblSoMay.TabIndex = 13;
            this.lblSoMay.Text = "Số Máy";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaDiem.Location = new System.Drawing.Point(35, 156);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(81, 21);
            this.lblDiaDiem.TabIndex = 12;
            this.lblDiaDiem.Text = "Địa Điểm";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(395, 103);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(93, 21);
            this.lblDienThoai.TabIndex = 11;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblMaPhongMay
            // 
            this.lblMaPhongMay.AutoSize = true;
            this.lblMaPhongMay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhongMay.Location = new System.Drawing.Point(11, 60);
            this.lblMaPhongMay.Name = "lblMaPhongMay";
            this.lblMaPhongMay.Size = new System.Drawing.Size(125, 21);
            this.lblMaPhongMay.TabIndex = 10;
            this.lblMaPhongMay.Text = "Mã Phòng Máy";
            // 
            // dgvPhongMay
            // 
            this.dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPM,
            this.TenPM,
            this.SoMay,
            this.DienThoai,
            this.DiaDiem});
            this.dgvPhongMay.Location = new System.Drawing.Point(87, 210);
            this.dgvPhongMay.Name = "dgvPhongMay";
            this.dgvPhongMay.RowHeadersWidth = 51;
            this.dgvPhongMay.RowTemplate.Height = 24;
            this.dgvPhongMay.Size = new System.Drawing.Size(633, 194);
            this.dgvPhongMay.TabIndex = 20;
            this.dgvPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongMay_CellClick);
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã Phòng Máy";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.Width = 125;
            // 
            // TenPM
            // 
            this.TenPM.DataPropertyName = "TenPM";
            this.TenPM.HeaderText = "Tên Phòng Máy";
            this.TenPM.MinimumWidth = 6;
            this.TenPM.Name = "TenPM";
            this.TenPM.Width = 125;
            // 
            // SoMay
            // 
            this.SoMay.DataPropertyName = "SoMay";
            this.SoMay.HeaderText = "Số Máy";
            this.SoMay.MinimumWidth = 6;
            this.SoMay.Name = "SoMay";
            this.SoMay.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 125;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(131, 435);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(248, 435);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(363, 435);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(481, 435);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "  Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(601, 435);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(16, 435);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(145, 155);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(150, 22);
            this.txtDiaDiem.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(301, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "PHÒNG MÁY";
            // 
            // txtTenPhongMay
            // 
            this.txtTenPhongMay.Location = new System.Drawing.Point(145, 106);
            this.txtTenPhongMay.Name = "txtTenPhongMay";
            this.txtTenPhongMay.Size = new System.Drawing.Size(150, 22);
            this.txtTenPhongMay.TabIndex = 30;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(719, 435);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(97, 39);
            this.btnIn.TabIndex = 31;
            this.btnIn.Text = "In ";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cboMaPhongMay
            // 
            this.cboMaPhongMay.FormattingEnabled = true;
            this.cboMaPhongMay.Location = new System.Drawing.Point(145, 54);
            this.cboMaPhongMay.Name = "cboMaPhongMay";
            this.cboMaPhongMay.Size = new System.Drawing.Size(150, 24);
            this.cboMaPhongMay.TabIndex = 32;
            // 
            // FrmPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 505);
            this.Controls.Add(this.cboMaPhongMay);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtTenPhongMay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhongMay);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtSoMay);
            this.Controls.Add(this.lblTenPhongMay);
            this.Controls.Add(this.lblSoMay);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.lblDienThoai);
            this.Controls.Add(this.lblMaPhongMay);
            this.Name = "FrmPhongMay";
            this.Text = "FrmPhongMay";
            this.Load += new System.EventHandler(this.FrmPhongMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtSoMay;
        private System.Windows.Forms.Label lblTenPhongMay;
        private System.Windows.Forms.Label lblSoMay;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaPhongMay;
        private System.Windows.Forms.DataGridView dgvPhongMay;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhongMay;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cboMaPhongMay;
    }
}