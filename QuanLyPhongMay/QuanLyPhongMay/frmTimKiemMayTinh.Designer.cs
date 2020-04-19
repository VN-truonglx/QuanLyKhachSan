namespace QuanLyPhongMay
{
    partial class frmTimKiemMayTinh
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaChip = new System.Windows.Forms.ComboBox();
            this.cboMaRam = new System.Windows.Forms.ComboBox();
            this.cboMaPhongMay = new System.Windows.Forms.ComboBox();
            this.lblMaRam = new System.Windows.Forms.Label();
            this.lblMaChip = new System.Windows.Forms.Label();
            this.lblMaPhongMay = new System.Windows.Forms.Label();
            this.lblTimKiemMayTinh = new System.Windows.Forms.Label();
            this.dgvTimKiemMayTinh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemMayTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaChip);
            this.panel1.Controls.Add(this.cboMaRam);
            this.panel1.Controls.Add(this.cboMaPhongMay);
            this.panel1.Controls.Add(this.lblMaRam);
            this.panel1.Controls.Add(this.lblMaChip);
            this.panel1.Controls.Add(this.lblMaPhongMay);
            this.panel1.Controls.Add(this.lblTimKiemMayTinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 155);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(397, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(191, 31);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaChip
            // 
            this.cboMaChip.FormattingEnabled = true;
            this.cboMaChip.Location = new System.Drawing.Point(195, 106);
            this.cboMaChip.Name = "cboMaChip";
            this.cboMaChip.Size = new System.Drawing.Size(121, 24);
            this.cboMaChip.TabIndex = 6;
            // 
            // cboMaRam
            // 
            this.cboMaRam.FormattingEnabled = true;
            this.cboMaRam.Location = new System.Drawing.Point(467, 61);
            this.cboMaRam.Name = "cboMaRam";
            this.cboMaRam.Size = new System.Drawing.Size(121, 24);
            this.cboMaRam.TabIndex = 5;
            // 
            // cboMaPhongMay
            // 
            this.cboMaPhongMay.FormattingEnabled = true;
            this.cboMaPhongMay.Location = new System.Drawing.Point(195, 61);
            this.cboMaPhongMay.Name = "cboMaPhongMay";
            this.cboMaPhongMay.Size = new System.Drawing.Size(121, 24);
            this.cboMaPhongMay.TabIndex = 4;
            // 
            // lblMaRam
            // 
            this.lblMaRam.AutoSize = true;
            this.lblMaRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaRam.Location = new System.Drawing.Point(394, 61);
            this.lblMaRam.Name = "lblMaRam";
            this.lblMaRam.Size = new System.Drawing.Size(59, 18);
            this.lblMaRam.TabIndex = 3;
            this.lblMaRam.Text = "Mã ram";
            // 
            // lblMaChip
            // 
            this.lblMaChip.AutoSize = true;
            this.lblMaChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChip.Location = new System.Drawing.Point(51, 106);
            this.lblMaChip.Name = "lblMaChip";
            this.lblMaChip.Size = new System.Drawing.Size(60, 18);
            this.lblMaChip.TabIndex = 2;
            this.lblMaChip.Text = "Mã chíp";
            // 
            // lblMaPhongMay
            // 
            this.lblMaPhongMay.AutoSize = true;
            this.lblMaPhongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhongMay.Location = new System.Drawing.Point(51, 61);
            this.lblMaPhongMay.Name = "lblMaPhongMay";
            this.lblMaPhongMay.Size = new System.Drawing.Size(106, 18);
            this.lblMaPhongMay.TabIndex = 1;
            this.lblMaPhongMay.Text = "Mã phòng máy";
            // 
            // lblTimKiemMayTinh
            // 
            this.lblTimKiemMayTinh.AutoSize = true;
            this.lblTimKiemMayTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemMayTinh.Location = new System.Drawing.Point(51, 19);
            this.lblTimKiemMayTinh.Name = "lblTimKiemMayTinh";
            this.lblTimKiemMayTinh.Size = new System.Drawing.Size(224, 29);
            this.lblTimKiemMayTinh.TabIndex = 0;
            this.lblTimKiemMayTinh.Text = "Tìm kiếm máy tính";
            // 
            // dgvTimKiemMayTinh
            // 
            this.dgvTimKiemMayTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemMayTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimKiemMayTinh.Location = new System.Drawing.Point(0, 155);
            this.dgvTimKiemMayTinh.Name = "dgvTimKiemMayTinh";
            this.dgvTimKiemMayTinh.RowHeadersWidth = 51;
            this.dgvTimKiemMayTinh.RowTemplate.Height = 24;
            this.dgvTimKiemMayTinh.Size = new System.Drawing.Size(800, 295);
            this.dgvTimKiemMayTinh.TabIndex = 1;
            // 
            // frmTimKiemMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTimKiemMayTinh);
            this.Controls.Add(this.panel1);
            this.Name = "frmTimKiemMayTinh";
            this.Text = "frmTimKiemMayTinh";
            this.Load += new System.EventHandler(this.frmTimKiemMayTinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemMayTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTimKiemMayTinh;
        private System.Windows.Forms.Label lblMaChip;
        private System.Windows.Forms.Label lblMaPhongMay;
        private System.Windows.Forms.Label lblTimKiemMayTinh;
        private System.Windows.Forms.Label lblMaRam;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaChip;
        private System.Windows.Forms.ComboBox cboMaRam;
        private System.Windows.Forms.ComboBox cboMaPhongMay;
    }
}