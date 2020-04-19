namespace QuanLyPhongMay
{
    partial class frmOCung
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
            this.txtTenOCung = new System.Windows.Forms.TextBox();
            this.txtMaOCung = new System.Windows.Forms.TextBox();
            this.dgvOCung = new System.Windows.Forms.DataGridView();
            this.MaOCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenOCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaOCung = new System.Windows.Forms.Label();
            this.lblTenOCung = new System.Windows.Forms.Label();
            this.lblOCung = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCung)).BeginInit();
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
            this.panel2.Controls.Add(this.lblOCung);
            this.panel2.Controls.Add(this.lblTenOCung);
            this.panel2.Controls.Add(this.lblMaOCung);
            this.panel2.Controls.Add(this.txtTenOCung);
            this.panel2.Controls.Add(this.txtMaOCung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 135);
            this.panel2.TabIndex = 1;
            // 
            // txtTenOCung
            // 
            this.txtTenOCung.Location = new System.Drawing.Point(195, 92);
            this.txtTenOCung.Name = "txtTenOCung";
            this.txtTenOCung.Size = new System.Drawing.Size(100, 22);
            this.txtTenOCung.TabIndex = 4;
            // 
            // txtMaOCung
            // 
            this.txtMaOCung.Location = new System.Drawing.Point(195, 43);
            this.txtMaOCung.Name = "txtMaOCung";
            this.txtMaOCung.Size = new System.Drawing.Size(100, 22);
            this.txtMaOCung.TabIndex = 3;
            // 
            // dgvOCung
            // 
            this.dgvOCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaOCung,
            this.TenOCung});
            this.dgvOCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOCung.Location = new System.Drawing.Point(0, 135);
            this.dgvOCung.Name = "dgvOCung";
            this.dgvOCung.RowHeadersWidth = 51;
            this.dgvOCung.RowTemplate.Height = 24;
            this.dgvOCung.Size = new System.Drawing.Size(800, 215);
            this.dgvOCung.TabIndex = 2;
            this.dgvOCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOCung_CellClick);
            // 
            // MaOCung
            // 
            this.MaOCung.DataPropertyName = "MaOCung";
            this.MaOCung.HeaderText = "Mã ổ cứng";
            this.MaOCung.MinimumWidth = 6;
            this.MaOCung.Name = "MaOCung";
            this.MaOCung.Width = 125;
            // 
            // TenOCung
            // 
            this.TenOCung.DataPropertyName = "TenOCung";
            this.TenOCung.HeaderText = "Tên ổ cứng";
            this.TenOCung.MinimumWidth = 6;
            this.TenOCung.Name = "TenOCung";
            this.TenOCung.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(568, 30);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 41);
            this.btnHuy.TabIndex = 17;
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
            this.btnLuu.Size = new System.Drawing.Size(90, 41);
            this.btnLuu.TabIndex = 16;
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
            this.btnXoa.Size = new System.Drawing.Size(89, 41);
            this.btnXoa.TabIndex = 15;
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
            this.btnSua.Size = new System.Drawing.Size(81, 41);
            this.btnSua.TabIndex = 14;
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
            this.btnThem.Size = new System.Drawing.Size(100, 41);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaOCung
            // 
            this.lblMaOCung.AutoSize = true;
            this.lblMaOCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaOCung.Location = new System.Drawing.Point(71, 43);
            this.lblMaOCung.Name = "lblMaOCung";
            this.lblMaOCung.Size = new System.Drawing.Size(78, 18);
            this.lblMaOCung.TabIndex = 5;
            this.lblMaOCung.Text = "Mã ổ cứng";
            // 
            // lblTenOCung
            // 
            this.lblTenOCung.AutoSize = true;
            this.lblTenOCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenOCung.Location = new System.Drawing.Point(71, 92);
            this.lblTenOCung.Name = "lblTenOCung";
            this.lblTenOCung.Size = new System.Drawing.Size(82, 18);
            this.lblTenOCung.TabIndex = 6;
            this.lblTenOCung.Text = "Tên ổ cứng";
            // 
            // lblOCung
            // 
            this.lblOCung.AutoSize = true;
            this.lblOCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOCung.Location = new System.Drawing.Point(391, 20);
            this.lblOCung.Name = "lblOCung";
            this.lblOCung.Size = new System.Drawing.Size(101, 29);
            this.lblOCung.TabIndex = 7;
            this.lblOCung.Text = "Ổ Cứng";
            // 
            // frmOCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOCung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmOCung";
            this.Text = "Ổ cứng";
            this.Load += new System.EventHandler(this.frmOCung_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOCung;
        private System.Windows.Forms.TextBox txtTenOCung;
        private System.Windows.Forms.TextBox txtMaOCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaOCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenOCung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblOCung;
        private System.Windows.Forms.Label lblTenOCung;
        private System.Windows.Forms.Label lblMaOCung;
    }
}

