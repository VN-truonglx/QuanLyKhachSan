namespace QuanLyPhongMay
{
    partial class FrmCaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaHoc));
            this.lblMaCa = new System.Windows.Forms.Label();
            this.lblTenCa = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.dgvCaHoc = new System.Windows.Forms.DataGridView();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaCa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaCa
            // 
            this.lblMaCa.AutoSize = true;
            this.lblMaCa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCa.Location = new System.Drawing.Point(37, 61);
            this.lblMaCa.Name = "lblMaCa";
            this.lblMaCa.Size = new System.Drawing.Size(77, 27);
            this.lblMaCa.TabIndex = 0;
            this.lblMaCa.Text = "Mã Ca";
            // 
            // lblTenCa
            // 
            this.lblTenCa.AutoSize = true;
            this.lblTenCa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCa.Location = new System.Drawing.Point(37, 105);
            this.lblTenCa.Name = "lblTenCa";
            this.lblTenCa.Size = new System.Drawing.Size(82, 27);
            this.lblTenCa.TabIndex = 1;
            this.lblTenCa.Text = "Tên Ca";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(125, 109);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(159, 22);
            this.txtTenCa.TabIndex = 3;
            // 
            // dgvCaHoc
            // 
            this.dgvCaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.TenCa});
            this.dgvCaHoc.Location = new System.Drawing.Point(96, 176);
            this.dgvCaHoc.Name = "dgvCaHoc";
            this.dgvCaHoc.RowHeadersWidth = 51;
            this.dgvCaHoc.RowTemplate.Height = 24;
            this.dgvCaHoc.Size = new System.Drawing.Size(645, 204);
            this.dgvCaHoc.TabIndex = 4;
            this.dgvCaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaHoc_CellClick);
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.Width = 125;
            // 
            // TenCa
            // 
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Tên Ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.Width = 125;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(159, 398);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(299, 398);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "  Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(434, 398);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "  Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(566, 398);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 40);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(703, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "  Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(28, 398);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "  Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(360, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "CA HỌC";
            // 
            // cboMaCa
            // 
            this.cboMaCa.FormattingEnabled = true;
            this.cboMaCa.Location = new System.Drawing.Point(125, 61);
            this.cboMaCa.Name = "cboMaCa";
            this.cboMaCa.Size = new System.Drawing.Size(159, 24);
            this.cboMaCa.TabIndex = 16;
            // 
            // FrmCaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 536);
            this.Controls.Add(this.cboMaCa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCaHoc);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.lblTenCa);
            this.Controls.Add(this.lblMaCa);
            this.Name = "FrmCaHoc";
            this.Text = "FrmCaHoc";
            this.Load += new System.EventHandler(this.FrmCaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.Label lblTenCa;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.DataGridView dgvCaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaCa;
    }
}