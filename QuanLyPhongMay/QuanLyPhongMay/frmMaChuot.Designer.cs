namespace QuanLyPhongMay
{
    partial class frmMaChuot
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
            this.txtTenChuot = new System.Windows.Forms.TextBox();
            this.txtMaChuot = new System.Windows.Forms.TextBox();
            this.lblTenChuot = new System.Windows.Forms.Label();
            this.lblMaChuot = new System.Windows.Forms.Label();
            this.lbChuot = new System.Windows.Forms.Label();
            this.dgvMaChuot = new System.Windows.Forms.DataGridView();
            this.MaChuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaChuot)).BeginInit();
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
            this.panel2.Controls.Add(this.txtTenChuot);
            this.panel2.Controls.Add(this.txtMaChuot);
            this.panel2.Controls.Add(this.lblTenChuot);
            this.panel2.Controls.Add(this.lblMaChuot);
            this.panel2.Controls.Add(this.lbChuot);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 139);
            this.panel2.TabIndex = 1;
            // 
            // txtTenChuot
            // 
            this.txtTenChuot.Location = new System.Drawing.Point(189, 104);
            this.txtTenChuot.Name = "txtTenChuot";
            this.txtTenChuot.Size = new System.Drawing.Size(100, 22);
            this.txtTenChuot.TabIndex = 4;
            // 
            // txtMaChuot
            // 
            this.txtMaChuot.Location = new System.Drawing.Point(189, 62);
            this.txtMaChuot.Name = "txtMaChuot";
            this.txtMaChuot.Size = new System.Drawing.Size(100, 22);
            this.txtMaChuot.TabIndex = 3;
            // 
            // lblTenChuot
            // 
            this.lblTenChuot.AutoSize = true;
            this.lblTenChuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuot.Location = new System.Drawing.Point(67, 104);
            this.lblTenChuot.Name = "lblTenChuot";
            this.lblTenChuot.Size = new System.Drawing.Size(74, 18);
            this.lblTenChuot.TabIndex = 2;
            this.lblTenChuot.Text = "Tên chuột";
            // 
            // lblMaChuot
            // 
            this.lblMaChuot.AutoSize = true;
            this.lblMaChuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuot.Location = new System.Drawing.Point(67, 62);
            this.lblMaChuot.Name = "lblMaChuot";
            this.lblMaChuot.Size = new System.Drawing.Size(70, 18);
            this.lblMaChuot.TabIndex = 1;
            this.lblMaChuot.Text = "Mã chuột";
            // 
            // lbChuot
            // 
            this.lbChuot.AutoSize = true;
            this.lbChuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuot.Location = new System.Drawing.Point(329, 13);
            this.lbChuot.Name = "lbChuot";
            this.lbChuot.Size = new System.Drawing.Size(123, 29);
            this.lbChuot.TabIndex = 0;
            this.lbChuot.Text = "Mã Chuột";
            // 
            // dgvMaChuot
            // 
            this.dgvMaChuot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaChuot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuot,
            this.TenChuot});
            this.dgvMaChuot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaChuot.Location = new System.Drawing.Point(0, 139);
            this.dgvMaChuot.Name = "dgvMaChuot";
            this.dgvMaChuot.RowHeadersWidth = 51;
            this.dgvMaChuot.RowTemplate.Height = 24;
            this.dgvMaChuot.Size = new System.Drawing.Size(800, 211);
            this.dgvMaChuot.TabIndex = 2;
            this.dgvMaChuot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaChuot_CellClick);
            // 
            // MaChuot
            // 
            this.MaChuot.DataPropertyName = "MaChuot";
            this.MaChuot.HeaderText = "Mã chuột";
            this.MaChuot.MinimumWidth = 6;
            this.MaChuot.Name = "MaChuot";
            this.MaChuot.Width = 125;
            // 
            // TenChuot
            // 
            this.TenChuot.DataPropertyName = "TenChuot";
            this.TenChuot.HeaderText = "Tên chuột";
            this.TenChuot.MinimumWidth = 6;
            this.TenChuot.Name = "TenChuot";
            this.TenChuot.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 41);
            this.btnThoat.TabIndex = 48;
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
            this.btnHuy.TabIndex = 47;
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
            this.btnLuu.Size = new System.Drawing.Size(86, 41);
            this.btnLuu.TabIndex = 46;
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
            this.btnXoa.Size = new System.Drawing.Size(88, 41);
            this.btnXoa.TabIndex = 45;
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
            this.btnSua.Size = new System.Drawing.Size(80, 41);
            this.btnSua.TabIndex = 44;
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
            this.btnThem.Size = new System.Drawing.Size(99, 41);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmMaChuot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaChuot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMaChuot";
            this.Text = "Mã Chuột";
            this.Load += new System.EventHandler(this.frmMaChuot_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaChuot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMaChuot;
        private System.Windows.Forms.Label lblTenChuot;
        private System.Windows.Forms.Label lblMaChuot;
        private System.Windows.Forms.Label lbChuot;
        private System.Windows.Forms.TextBox txtTenChuot;
        private System.Windows.Forms.TextBox txtMaChuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}