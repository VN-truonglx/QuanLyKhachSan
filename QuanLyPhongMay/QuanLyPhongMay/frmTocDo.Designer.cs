namespace QuanLyPhongMay
{
    partial class frmTocDo
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
            this.txtTenTocDo = new System.Windows.Forms.TextBox();
            this.txtMaTocDo = new System.Windows.Forms.TextBox();
            this.lblTenTocDo = new System.Windows.Forms.Label();
            this.lblMaTocDo = new System.Windows.Forms.Label();
            this.lblTocDo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTocDo = new System.Windows.Forms.DataGridView();
            this.MaTocDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTocDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTocDo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenTocDo);
            this.panel1.Controls.Add(this.txtMaTocDo);
            this.panel1.Controls.Add(this.lblTenTocDo);
            this.panel1.Controls.Add(this.lblMaTocDo);
            this.panel1.Controls.Add(this.lblTocDo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 134);
            this.panel1.TabIndex = 0;
            // 
            // txtTenTocDo
            // 
            this.txtTenTocDo.Location = new System.Drawing.Point(164, 97);
            this.txtTenTocDo.Name = "txtTenTocDo";
            this.txtTenTocDo.Size = new System.Drawing.Size(100, 22);
            this.txtTenTocDo.TabIndex = 4;
            // 
            // txtMaTocDo
            // 
            this.txtMaTocDo.Location = new System.Drawing.Point(164, 48);
            this.txtMaTocDo.Name = "txtMaTocDo";
            this.txtMaTocDo.Size = new System.Drawing.Size(100, 22);
            this.txtMaTocDo.TabIndex = 3;
            // 
            // lblTenTocDo
            // 
            this.lblTenTocDo.AutoSize = true;
            this.lblTenTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTocDo.Location = new System.Drawing.Point(60, 100);
            this.lblTenTocDo.Name = "lblTenTocDo";
            this.lblTenTocDo.Size = new System.Drawing.Size(79, 18);
            this.lblTenTocDo.TabIndex = 2;
            this.lblTenTocDo.Text = "Tên tốc độ";
            // 
            // lblMaTocDo
            // 
            this.lblMaTocDo.AutoSize = true;
            this.lblMaTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTocDo.Location = new System.Drawing.Point(60, 51);
            this.lblMaTocDo.Name = "lblMaTocDo";
            this.lblMaTocDo.Size = new System.Drawing.Size(75, 18);
            this.lblMaTocDo.TabIndex = 1;
            this.lblMaTocDo.Text = "Mã tốc độ";
            // 
            // lblTocDo
            // 
            this.lblTocDo.AutoSize = true;
            this.lblTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocDo.Location = new System.Drawing.Point(365, 13);
            this.lblTocDo.Name = "lblTocDo";
            this.lblTocDo.Size = new System.Drawing.Size(98, 29);
            this.lblTocDo.TabIndex = 0;
            this.lblTocDo.Text = "Tốc Độ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // dgvTocDo
            // 
            this.dgvTocDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTocDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTocDo,
            this.TenTocDo});
            this.dgvTocDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTocDo.Location = new System.Drawing.Point(0, 134);
            this.dgvTocDo.Name = "dgvTocDo";
            this.dgvTocDo.RowHeadersWidth = 51;
            this.dgvTocDo.RowTemplate.Height = 24;
            this.dgvTocDo.Size = new System.Drawing.Size(800, 216);
            this.dgvTocDo.TabIndex = 2;
            this.dgvTocDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTocDo_CellClick);
            // 
            // MaTocDo
            // 
            this.MaTocDo.DataPropertyName = "MaTocDo";
            this.MaTocDo.HeaderText = "Mã tốc độ";
            this.MaTocDo.MinimumWidth = 6;
            this.MaTocDo.Name = "MaTocDo";
            this.MaTocDo.Width = 125;
            // 
            // TenTocDo
            // 
            this.TenTocDo.DataPropertyName = "TenTocDo";
            this.TenTocDo.HeaderText = "Tên tốc độ";
            this.TenTocDo.MinimumWidth = 6;
            this.TenTocDo.Name = "TenTocDo";
            this.TenTocDo.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyPhongMay.Properties.Resources.Thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(23, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 41);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyPhongMay.Properties.Resources.btnThoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(669, 30);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 41);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyPhongMay.Properties.Resources.btnHuy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(548, 30);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 41);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyPhongMay.Properties.Resources.btnLuu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(413, 30);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 41);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyPhongMay.Properties.Resources.btnXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(275, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 41);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyPhongMay.Properties.Resources.btnSua;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(150, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 41);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmTocDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTocDo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTocDo";
            this.Text = "Tốc Độ";
            this.Load += new System.EventHandler(this.frmTocDo_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTocDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTocDo;
        private System.Windows.Forms.TextBox txtTenTocDo;
        private System.Windows.Forms.TextBox txtMaTocDo;
        private System.Windows.Forms.Label lblTenTocDo;
        private System.Windows.Forms.Label lblMaTocDo;
        private System.Windows.Forms.Label lblTocDo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTocDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTocDo;
    }
}