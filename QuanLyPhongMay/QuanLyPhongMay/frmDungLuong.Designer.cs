namespace QuanLyPhongMay
{
    partial class frmDungLuong
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
            this.txtTenDungLuong = new System.Windows.Forms.TextBox();
            this.txtMaDungLuong = new System.Windows.Forms.TextBox();
            this.lblTenDungLuong = new System.Windows.Forms.Label();
            this.lblMaDungLuong = new System.Windows.Forms.Label();
            this.lblDungLuong = new System.Windows.Forms.Label();
            this.dgvDungLuong = new System.Windows.Forms.DataGridView();
            this.MaDungLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDungLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungLuong)).BeginInit();
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
            this.btnThem.Size = new System.Drawing.Size(94, 41);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(673, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 41);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(543, 30);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 41);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(424, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 41);
            this.btnLuu.TabIndex = 22;
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
            this.btnXoa.Size = new System.Drawing.Size(90, 41);
            this.btnXoa.TabIndex = 21;
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
            this.btnSua.Size = new System.Drawing.Size(84, 41);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenDungLuong);
            this.panel2.Controls.Add(this.txtMaDungLuong);
            this.panel2.Controls.Add(this.lblTenDungLuong);
            this.panel2.Controls.Add(this.lblMaDungLuong);
            this.panel2.Controls.Add(this.lblDungLuong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 132);
            this.panel2.TabIndex = 1;
            // 
            // txtTenDungLuong
            // 
            this.txtTenDungLuong.Location = new System.Drawing.Point(226, 90);
            this.txtTenDungLuong.Name = "txtTenDungLuong";
            this.txtTenDungLuong.Size = new System.Drawing.Size(100, 22);
            this.txtTenDungLuong.TabIndex = 4;
            // 
            // txtMaDungLuong
            // 
            this.txtMaDungLuong.Location = new System.Drawing.Point(226, 39);
            this.txtMaDungLuong.Name = "txtMaDungLuong";
            this.txtMaDungLuong.Size = new System.Drawing.Size(100, 22);
            this.txtMaDungLuong.TabIndex = 3;
            // 
            // lblTenDungLuong
            // 
            this.lblTenDungLuong.AutoSize = true;
            this.lblTenDungLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDungLuong.Location = new System.Drawing.Point(71, 93);
            this.lblTenDungLuong.Name = "lblTenDungLuong";
            this.lblTenDungLuong.Size = new System.Drawing.Size(109, 18);
            this.lblTenDungLuong.TabIndex = 2;
            this.lblTenDungLuong.Text = "Tên dung lượng";
            // 
            // lblMaDungLuong
            // 
            this.lblMaDungLuong.AutoSize = true;
            this.lblMaDungLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDungLuong.Location = new System.Drawing.Point(71, 39);
            this.lblMaDungLuong.Name = "lblMaDungLuong";
            this.lblMaDungLuong.Size = new System.Drawing.Size(105, 18);
            this.lblMaDungLuong.TabIndex = 1;
            this.lblMaDungLuong.Text = "Mã dung lượng";
            // 
            // lblDungLuong
            // 
            this.lblDungLuong.AutoSize = true;
            this.lblDungLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDungLuong.Location = new System.Drawing.Point(358, 13);
            this.lblDungLuong.Name = "lblDungLuong";
            this.lblDungLuong.Size = new System.Drawing.Size(153, 29);
            this.lblDungLuong.TabIndex = 0;
            this.lblDungLuong.Text = "Dung Lượng";
            // 
            // dgvDungLuong
            // 
            this.dgvDungLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDungLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDungLuong,
            this.TenDungLuong});
            this.dgvDungLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDungLuong.Location = new System.Drawing.Point(0, 132);
            this.dgvDungLuong.Name = "dgvDungLuong";
            this.dgvDungLuong.RowHeadersWidth = 51;
            this.dgvDungLuong.RowTemplate.Height = 24;
            this.dgvDungLuong.Size = new System.Drawing.Size(800, 218);
            this.dgvDungLuong.TabIndex = 2;
            this.dgvDungLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDungLuong_CellClick);
            // 
            // MaDungLuong
            // 
            this.MaDungLuong.DataPropertyName = "MaDungLuong";
            this.MaDungLuong.HeaderText = "Mã dung lượng";
            this.MaDungLuong.MinimumWidth = 6;
            this.MaDungLuong.Name = "MaDungLuong";
            this.MaDungLuong.Width = 125;
            // 
            // TenDungLuong
            // 
            this.TenDungLuong.DataPropertyName = "TenDungLuong";
            this.TenDungLuong.HeaderText = "Tên dung lượng";
            this.TenDungLuong.MinimumWidth = 6;
            this.TenDungLuong.Name = "TenDungLuong";
            this.TenDungLuong.Width = 125;
            // 
            // frmDungLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDungLuong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDungLuong";
            this.Text = "Dung Lượng";
            this.Load += new System.EventHandler(this.frmDungLuong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDungLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDungLuong;
        private System.Windows.Forms.TextBox txtTenDungLuong;
        private System.Windows.Forms.TextBox txtMaDungLuong;
        private System.Windows.Forms.Label lblTenDungLuong;
        private System.Windows.Forms.Label lblMaDungLuong;
        private System.Windows.Forms.Label lblDungLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDungLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDungLuong;
    }
}