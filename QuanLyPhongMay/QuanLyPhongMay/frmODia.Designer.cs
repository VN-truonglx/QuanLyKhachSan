namespace QuanLyPhongMay
{
    partial class frmODia
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
            this.txtTenODia = new System.Windows.Forms.TextBox();
            this.txtMaODia = new System.Windows.Forms.TextBox();
            this.lblTenODia = new System.Windows.Forms.Label();
            this.lblMaODia = new System.Windows.Forms.Label();
            this.lblODia = new System.Windows.Forms.Label();
            this.dgvODia = new System.Windows.Forms.DataGridView();
            this.MaODia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenODia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODia)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenODia);
            this.panel2.Controls.Add(this.txtMaODia);
            this.panel2.Controls.Add(this.lblTenODia);
            this.panel2.Controls.Add(this.lblMaODia);
            this.panel2.Controls.Add(this.lblODia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 126);
            this.panel2.TabIndex = 1;
            // 
            // txtTenODia
            // 
            this.txtTenODia.Location = new System.Drawing.Point(149, 86);
            this.txtTenODia.Name = "txtTenODia";
            this.txtTenODia.Size = new System.Drawing.Size(100, 22);
            this.txtTenODia.TabIndex = 4;
            // 
            // txtMaODia
            // 
            this.txtMaODia.Location = new System.Drawing.Point(149, 41);
            this.txtMaODia.Name = "txtMaODia";
            this.txtMaODia.Size = new System.Drawing.Size(100, 22);
            this.txtMaODia.TabIndex = 3;
            // 
            // lblTenODia
            // 
            this.lblTenODia.AutoSize = true;
            this.lblTenODia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenODia.Location = new System.Drawing.Point(55, 91);
            this.lblTenODia.Name = "lblTenODia";
            this.lblTenODia.Size = new System.Drawing.Size(69, 18);
            this.lblTenODia.TabIndex = 2;
            this.lblTenODia.Text = "Tên ổ đĩa";
            // 
            // lblMaODia
            // 
            this.lblMaODia.AutoSize = true;
            this.lblMaODia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaODia.Location = new System.Drawing.Point(55, 44);
            this.lblMaODia.Name = "lblMaODia";
            this.lblMaODia.Size = new System.Drawing.Size(65, 18);
            this.lblMaODia.TabIndex = 1;
            this.lblMaODia.Text = "Mã ổ đĩa";
            // 
            // lblODia
            // 
            this.lblODia.AutoSize = true;
            this.lblODia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblODia.Location = new System.Drawing.Point(363, 13);
            this.lblODia.Name = "lblODia";
            this.lblODia.Size = new System.Drawing.Size(79, 29);
            this.lblODia.TabIndex = 0;
            this.lblODia.Text = "Ổ Đĩa";
            // 
            // dgvODia
            // 
            this.dgvODia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaODia,
            this.TenODia});
            this.dgvODia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvODia.Location = new System.Drawing.Point(0, 126);
            this.dgvODia.Name = "dgvODia";
            this.dgvODia.RowHeadersWidth = 51;
            this.dgvODia.RowTemplate.Height = 24;
            this.dgvODia.Size = new System.Drawing.Size(800, 242);
            this.dgvODia.TabIndex = 2;
            this.dgvODia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvODia_CellClick);
            // 
            // MaODia
            // 
            this.MaODia.DataPropertyName = "MaODia";
            this.MaODia.HeaderText = "Mã ổ đĩa";
            this.MaODia.MinimumWidth = 6;
            this.MaODia.Name = "MaODia";
            this.MaODia.Width = 125;
            // 
            // TenODia
            // 
            this.TenODia.DataPropertyName = "TenODia";
            this.TenODia.HeaderText = "Tên ổ đĩa";
            this.TenODia.MinimumWidth = 6;
            this.TenODia.Name = "TenODia";
            this.TenODia.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(688, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(563, 21);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 41);
            this.btnHuy.TabIndex = 59;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(440, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 41);
            this.btnLuu.TabIndex = 58;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(301, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 41);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(165, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 41);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(38, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 41);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmODia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvODia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmODia";
            this.Text = "Ổ Đĩa";
            this.Load += new System.EventHandler(this.frmODia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvODia;
        private System.Windows.Forms.TextBox txtTenODia;
        private System.Windows.Forms.TextBox txtMaODia;
        private System.Windows.Forms.Label lblTenODia;
        private System.Windows.Forms.Label lblMaODia;
        private System.Windows.Forms.Label lblODia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaODia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenODia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}