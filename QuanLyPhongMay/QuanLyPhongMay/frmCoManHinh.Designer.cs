namespace QuanLyPhongMay
{
    partial class frmCoManHinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenCoMH = new System.Windows.Forms.TextBox();
            this.txtMaCoMH = new System.Windows.Forms.TextBox();
            this.lblTenCoMH = new System.Windows.Forms.Label();
            this.lblMaCoMH = new System.Windows.Forms.Label();
            this.lblCoManHinh = new System.Windows.Forms.Label();
            this.dgvCoManHinh = new System.Windows.Forms.DataGridView();
            this.MaCoMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCoMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoManHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(38, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 41);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(563, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 41);
            this.btnHuy.TabIndex = 71;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(440, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 41);
            this.btnLuu.TabIndex = 70;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(301, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 41);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(165, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 41);
            this.btnSua.TabIndex = 68;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenCoMH);
            this.panel2.Controls.Add(this.txtMaCoMH);
            this.panel2.Controls.Add(this.lblTenCoMH);
            this.panel2.Controls.Add(this.lblMaCoMH);
            this.panel2.Controls.Add(this.lblCoManHinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 130);
            this.panel2.TabIndex = 1;
            // 
            // txtTenCoMH
            // 
            this.txtTenCoMH.Location = new System.Drawing.Point(140, 93);
            this.txtTenCoMH.Name = "txtTenCoMH";
            this.txtTenCoMH.Size = new System.Drawing.Size(100, 22);
            this.txtTenCoMH.TabIndex = 4;
            // 
            // txtMaCoMH
            // 
            this.txtMaCoMH.Location = new System.Drawing.Point(140, 42);
            this.txtMaCoMH.Name = "txtMaCoMH";
            this.txtMaCoMH.Size = new System.Drawing.Size(100, 22);
            this.txtMaCoMH.TabIndex = 3;
            // 
            // lblTenCoMH
            // 
            this.lblTenCoMH.AutoSize = true;
            this.lblTenCoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCoMH.Location = new System.Drawing.Point(35, 93);
            this.lblTenCoMH.Name = "lblTenCoMH";
            this.lblTenCoMH.Size = new System.Drawing.Size(85, 18);
            this.lblTenCoMH.TabIndex = 2;
            this.lblTenCoMH.Text = "Tên Cỡ MH";
            // 
            // lblMaCoMH
            // 
            this.lblMaCoMH.AutoSize = true;
            this.lblMaCoMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCoMH.Location = new System.Drawing.Point(35, 42);
            this.lblMaCoMH.Name = "lblMaCoMH";
            this.lblMaCoMH.Size = new System.Drawing.Size(81, 18);
            this.lblMaCoMH.TabIndex = 1;
            this.lblMaCoMH.Text = "Mã Cỡ MH";
            // 
            // lblCoManHinh
            // 
            this.lblCoManHinh.AutoSize = true;
            this.lblCoManHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoManHinh.Location = new System.Drawing.Point(353, 9);
            this.lblCoManHinh.Name = "lblCoManHinh";
            this.lblCoManHinh.Size = new System.Drawing.Size(162, 29);
            this.lblCoManHinh.TabIndex = 0;
            this.lblCoManHinh.Text = "Cỡ Màn Hình";
            // 
            // dgvCoManHinh
            // 
            this.dgvCoManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoManHinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCoMH,
            this.TenCoMH});
            this.dgvCoManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoManHinh.Location = new System.Drawing.Point(0, 130);
            this.dgvCoManHinh.Name = "dgvCoManHinh";
            this.dgvCoManHinh.RowHeadersWidth = 51;
            this.dgvCoManHinh.RowTemplate.Height = 24;
            this.dgvCoManHinh.Size = new System.Drawing.Size(800, 242);
            this.dgvCoManHinh.TabIndex = 2;
            this.dgvCoManHinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoManHinh_CellClick);
            // 
            // MaCoMH
            // 
            this.MaCoMH.DataPropertyName = "MaCoMH";
            this.MaCoMH.HeaderText = "Mã Cỡ MH";
            this.MaCoMH.MinimumWidth = 6;
            this.MaCoMH.Name = "MaCoMH";
            this.MaCoMH.Width = 125;
            // 
            // TenCoMH
            // 
            this.TenCoMH.DataPropertyName = "TenCoMH";
            this.TenCoMH.HeaderText = "Ten Cỡ MH";
            this.TenCoMH.MinimumWidth = 6;
            this.TenCoMH.Name = "TenCoMH";
            this.TenCoMH.Width = 125;
            // 
            // frmCoManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCoManHinh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCoManHinh";
            this.Text = "Cỡ Màn Hình";
            this.Load += new System.EventHandler(this.frmCoManHinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoManHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCoManHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenCoMH;
        private System.Windows.Forms.TextBox txtMaCoMH;
        private System.Windows.Forms.Label lblTenCoMH;
        private System.Windows.Forms.Label lblMaCoMH;
        private System.Windows.Forms.Label lblCoManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCoMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCoMH;
    }
}