namespace QuanLyPhongMay
{
    partial class frmBanPhim
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
            this.txtTenBanPhim = new System.Windows.Forms.TextBox();
            this.txtMaBanPhim = new System.Windows.Forms.TextBox();
            this.lblTenBanPhim = new System.Windows.Forms.Label();
            this.lblMaBanPhim = new System.Windows.Forms.Label();
            this.lblBanPhim = new System.Windows.Forms.Label();
            this.dgvBanPhim = new System.Windows.Forms.DataGridView();
            this.MaBanPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBanPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanPhim)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(38, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(563, 27);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 41);
            this.btnHuy.TabIndex = 53;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(440, 27);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 41);
            this.btnLuu.TabIndex = 52;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(301, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 41);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(165, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 41);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenBanPhim);
            this.panel2.Controls.Add(this.txtMaBanPhim);
            this.panel2.Controls.Add(this.lblTenBanPhim);
            this.panel2.Controls.Add(this.lblMaBanPhim);
            this.panel2.Controls.Add(this.lblBanPhim);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 135);
            this.panel2.TabIndex = 1;
            // 
            // txtTenBanPhim
            // 
            this.txtTenBanPhim.Location = new System.Drawing.Point(227, 95);
            this.txtTenBanPhim.Name = "txtTenBanPhim";
            this.txtTenBanPhim.Size = new System.Drawing.Size(100, 22);
            this.txtTenBanPhim.TabIndex = 4;
            // 
            // txtMaBanPhim
            // 
            this.txtMaBanPhim.Location = new System.Drawing.Point(227, 51);
            this.txtMaBanPhim.Name = "txtMaBanPhim";
            this.txtMaBanPhim.Size = new System.Drawing.Size(100, 22);
            this.txtMaBanPhim.TabIndex = 3;
            // 
            // lblTenBanPhim
            // 
            this.lblTenBanPhim.AutoSize = true;
            this.lblTenBanPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBanPhim.Location = new System.Drawing.Point(70, 95);
            this.lblTenBanPhim.Name = "lblTenBanPhim";
            this.lblTenBanPhim.Size = new System.Drawing.Size(101, 18);
            this.lblTenBanPhim.TabIndex = 2;
            this.lblTenBanPhim.Text = "Tên Bàn Phím";
            // 
            // lblMaBanPhim
            // 
            this.lblMaBanPhim.AutoSize = true;
            this.lblMaBanPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBanPhim.Location = new System.Drawing.Point(70, 51);
            this.lblMaBanPhim.Name = "lblMaBanPhim";
            this.lblMaBanPhim.Size = new System.Drawing.Size(97, 18);
            this.lblMaBanPhim.TabIndex = 1;
            this.lblMaBanPhim.Text = "Mã Bàn Phím";
            // 
            // lblBanPhim
            // 
            this.lblBanPhim.AutoSize = true;
            this.lblBanPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanPhim.Location = new System.Drawing.Point(369, 24);
            this.lblBanPhim.Name = "lblBanPhim";
            this.lblBanPhim.Size = new System.Drawing.Size(124, 29);
            this.lblBanPhim.TabIndex = 0;
            this.lblBanPhim.Text = "Bàn Phím";
            // 
            // dgvBanPhim
            // 
            this.dgvBanPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBanPhim,
            this.TenBanPhim});
            this.dgvBanPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanPhim.Location = new System.Drawing.Point(0, 135);
            this.dgvBanPhim.Name = "dgvBanPhim";
            this.dgvBanPhim.RowHeadersWidth = 51;
            this.dgvBanPhim.RowTemplate.Height = 24;
            this.dgvBanPhim.Size = new System.Drawing.Size(800, 221);
            this.dgvBanPhim.TabIndex = 2;
            this.dgvBanPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanPhim_CellClick);
            // 
            // MaBanPhim
            // 
            this.MaBanPhim.DataPropertyName = "MaBanPhim";
            this.MaBanPhim.HeaderText = "Mã bàn phím";
            this.MaBanPhim.MinimumWidth = 6;
            this.MaBanPhim.Name = "MaBanPhim";
            this.MaBanPhim.Width = 125;
            // 
            // TenBanPhim
            // 
            this.TenBanPhim.DataPropertyName = "TenBanPhim";
            this.TenBanPhim.HeaderText = "Tên bàn phím";
            this.TenBanPhim.MinimumWidth = 6;
            this.TenBanPhim.Name = "TenBanPhim";
            this.TenBanPhim.Width = 125;
            // 
            // frmBanPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBanPhim);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBanPhim";
            this.Text = "Bàn Phím";
            this.Load += new System.EventHandler(this.frmBanPhim_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBanPhim;
        private System.Windows.Forms.Label lblMaBanPhim;
        private System.Windows.Forms.Label lblBanPhim;
        private System.Windows.Forms.TextBox txtTenBanPhim;
        private System.Windows.Forms.TextBox txtMaBanPhim;
        private System.Windows.Forms.Label lblTenBanPhim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBanPhim;
    }
}