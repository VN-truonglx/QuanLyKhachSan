namespace QuanLyPhongMay
{
    partial class frmRam
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenRam = new System.Windows.Forms.TextBox();
            this.txtMaRam = new System.Windows.Forms.TextBox();
            this.lblTenRam = new System.Windows.Forms.Label();
            this.lblMaRam = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.dgvRam = new System.Windows.Forms.DataGridView();
            this.MaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenRam);
            this.panel2.Controls.Add(this.txtMaRam);
            this.panel2.Controls.Add(this.lblTenRam);
            this.panel2.Controls.Add(this.lblMaRam);
            this.panel2.Controls.Add(this.lblRam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 119);
            this.panel2.TabIndex = 1;
            // 
            // txtTenRam
            // 
            this.txtTenRam.Location = new System.Drawing.Point(152, 78);
            this.txtTenRam.Name = "txtTenRam";
            this.txtTenRam.Size = new System.Drawing.Size(100, 22);
            this.txtTenRam.TabIndex = 4;
            // 
            // txtMaRam
            // 
            this.txtMaRam.Location = new System.Drawing.Point(152, 40);
            this.txtMaRam.Name = "txtMaRam";
            this.txtMaRam.Size = new System.Drawing.Size(100, 22);
            this.txtMaRam.TabIndex = 3;
            // 
            // lblTenRam
            // 
            this.lblTenRam.AutoSize = true;
            this.lblTenRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenRam.Location = new System.Drawing.Point(56, 81);
            this.lblTenRam.Name = "lblTenRam";
            this.lblTenRam.Size = new System.Drawing.Size(63, 18);
            this.lblTenRam.TabIndex = 2;
            this.lblTenRam.Text = "Tên ram";
            // 
            // lblMaRam
            // 
            this.lblMaRam.AutoSize = true;
            this.lblMaRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaRam.Location = new System.Drawing.Point(56, 43);
            this.lblMaRam.Name = "lblMaRam";
            this.lblMaRam.Size = new System.Drawing.Size(59, 18);
            this.lblMaRam.TabIndex = 1;
            this.lblMaRam.Text = "Mã ram";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(351, 9);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(66, 29);
            this.lblRam.TabIndex = 0;
            this.lblRam.Text = "Ram";
            // 
            // dgvRam
            // 
            this.dgvRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaRam,
            this.TenRam});
            this.dgvRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRam.Location = new System.Drawing.Point(0, 119);
            this.dgvRam.Name = "dgvRam";
            this.dgvRam.RowHeadersWidth = 51;
            this.dgvRam.RowTemplate.Height = 24;
            this.dgvRam.Size = new System.Drawing.Size(800, 231);
            this.dgvRam.TabIndex = 2;
            this.dgvRam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRam_CellClick);
            // 
            // MaRam
            // 
            this.MaRam.DataPropertyName = "MaRam";
            this.MaRam.HeaderText = "Mã ram";
            this.MaRam.MinimumWidth = 6;
            this.MaRam.Name = "MaRam";
            this.MaRam.Width = 125;
            // 
            // TenRam
            // 
            this.TenRam.DataPropertyName = "TenRam";
            this.TenRam.HeaderText = "Tên ram";
            this.TenRam.MinimumWidth = 6;
            this.TenRam.Name = "TenRam";
            this.TenRam.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(563, 30);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 41);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(440, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 41);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(301, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 41);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(165, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 41);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(38, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 41);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmRam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRam);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRam";
            this.Text = "Ram";
            this.Load += new System.EventHandler(this.frmRam_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRam;
        private System.Windows.Forms.Label lblTenRam;
        private System.Windows.Forms.Label lblMaRam;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.TextBox txtTenRam;
        private System.Windows.Forms.TextBox txtMaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenRam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}