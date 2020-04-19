namespace QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh
{
    partial class frmMonThucHanh
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
            this.dataGridView_MTH = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MTH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MTH
            // 
            this.dataGridView_MTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MTH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon});
            this.dataGridView_MTH.Location = new System.Drawing.Point(38, 93);
            this.dataGridView_MTH.Name = "dataGridView_MTH";
            this.dataGridView_MTH.RowHeadersWidth = 62;
            this.dataGridView_MTH.RowTemplate.Height = 28;
            this.dataGridView_MTH.Size = new System.Drawing.Size(761, 285);
            this.dataGridView_MTH.TabIndex = 12;
            this.dataGridView_MTH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MTH_CellClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 8;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 150;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.MinimumWidth = 8;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 150;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMon.Location = new System.Drawing.Point(60, 38);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(91, 26);
            this.lblMaMon.TabIndex = 13;
            this.lblMaMon.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(157, 38);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(218, 26);
            this.txtMaMon.TabIndex = 14;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(408, 36);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(97, 26);
            this.lblTenMon.TabIndex = 15;
            this.lblTenMon.Text = "Tên môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTenMon.Location = new System.Drawing.Point(521, 38);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(218, 26);
            this.txtTenMon.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(716, 407);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 41);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(440, 407);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(99, 41);
            this.btnHuyBo.TabIndex = 22;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(302, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 41);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(576, 407);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 41);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 407);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 41);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 407);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 41);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmMonThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.dataGridView_MTH);
            this.Name = "frmMonThucHanh";
            this.Text = "frmMonThucHanh";
            this.Load += new System.EventHandler(this.frmMonThucHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}