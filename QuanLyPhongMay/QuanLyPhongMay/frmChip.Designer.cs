namespace QuanLyPhongMay
{
    partial class frmChip
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
            this.txtTenChip = new System.Windows.Forms.TextBox();
            this.txtMaChip = new System.Windows.Forms.TextBox();
            this.lblTenChip = new System.Windows.Forms.Label();
            this.lblMaChip = new System.Windows.Forms.Label();
            this.lblChip = new System.Windows.Forms.Label();
            this.dgvChip = new System.Windows.Forms.DataGridView();
            this.MaChip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChip)).BeginInit();
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
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(38, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 41);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 41);
            this.btnThoat.TabIndex = 30;
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
            this.btnHuy.Size = new System.Drawing.Size(90, 41);
            this.btnHuy.TabIndex = 29;
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
            this.btnLuu.Size = new System.Drawing.Size(92, 41);
            this.btnLuu.TabIndex = 28;
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
            this.btnXoa.Size = new System.Drawing.Size(92, 41);
            this.btnXoa.TabIndex = 27;
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
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenChip);
            this.panel2.Controls.Add(this.txtMaChip);
            this.panel2.Controls.Add(this.lblTenChip);
            this.panel2.Controls.Add(this.lblMaChip);
            this.panel2.Controls.Add(this.lblChip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 136);
            this.panel2.TabIndex = 1;
            // 
            // txtTenChip
            // 
            this.txtTenChip.Location = new System.Drawing.Point(165, 92);
            this.txtTenChip.Name = "txtTenChip";
            this.txtTenChip.Size = new System.Drawing.Size(100, 22);
            this.txtTenChip.TabIndex = 4;
            // 
            // txtMaChip
            // 
            this.txtMaChip.Location = new System.Drawing.Point(165, 35);
            this.txtMaChip.Name = "txtMaChip";
            this.txtMaChip.Size = new System.Drawing.Size(100, 22);
            this.txtMaChip.TabIndex = 3;
            // 
            // lblTenChip
            // 
            this.lblTenChip.AutoSize = true;
            this.lblTenChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChip.Location = new System.Drawing.Point(74, 95);
            this.lblTenChip.Name = "lblTenChip";
            this.lblTenChip.Size = new System.Drawing.Size(64, 18);
            this.lblTenChip.TabIndex = 2;
            this.lblTenChip.Text = "Tên chip";
            // 
            // lblMaChip
            // 
            this.lblMaChip.AutoSize = true;
            this.lblMaChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChip.Location = new System.Drawing.Point(74, 38);
            this.lblMaChip.Name = "lblMaChip";
            this.lblMaChip.Size = new System.Drawing.Size(60, 18);
            this.lblMaChip.TabIndex = 1;
            this.lblMaChip.Text = "Mã chip";
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChip.Location = new System.Drawing.Point(355, 9);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(67, 29);
            this.lblChip.TabIndex = 0;
            this.lblChip.Text = "Chip";
            // 
            // dgvChip
            // 
            this.dgvChip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChip,
            this.TenChip});
            this.dgvChip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChip.Location = new System.Drawing.Point(0, 136);
            this.dgvChip.Name = "dgvChip";
            this.dgvChip.RowHeadersWidth = 51;
            this.dgvChip.RowTemplate.Height = 24;
            this.dgvChip.Size = new System.Drawing.Size(800, 214);
            this.dgvChip.TabIndex = 2;
            this.dgvChip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChip_CellClick);
            // 
            // MaChip
            // 
            this.MaChip.DataPropertyName = "MaChip";
            this.MaChip.HeaderText = "Mã Chip";
            this.MaChip.MinimumWidth = 6;
            this.MaChip.Name = "MaChip";
            this.MaChip.Width = 125;
            // 
            // TenChip
            // 
            this.TenChip.DataPropertyName = "TenChip";
            this.TenChip.HeaderText = "Tên Chip";
            this.TenChip.MinimumWidth = 6;
            this.TenChip.Name = "TenChip";
            this.TenChip.Width = 125;
            // 
            // frmChip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChip";
            this.Text = "Chip";
            this.Load += new System.EventHandler(this.frmChip_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvChip;
        private System.Windows.Forms.Label lblTenChip;
        private System.Windows.Forms.Label lblMaChip;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenChip;
        private System.Windows.Forms.TextBox txtMaChip;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChip;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChip;
    }
}