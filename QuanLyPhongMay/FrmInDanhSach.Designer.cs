namespace QuanLyPhongMay
{
    partial class FrmInDanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInDanhSach));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInDanhSach = new System.Windows.Forms.DataGridView();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaMay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "IN DANH SÁCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInDanhSach
            // 
            this.dgvInDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInDanhSach.Location = new System.Drawing.Point(12, 139);
            this.dgvInDanhSach.Name = "dgvInDanhSach";
            this.dgvInDanhSach.RowHeadersWidth = 51;
            this.dgvInDanhSach.RowTemplate.Height = 24;
            this.dgvInDanhSach.Size = new System.Drawing.Size(772, 200);
            this.dgvInDanhSach.TabIndex = 2;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.Image")));
            this.btnInDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInDanhSach.Location = new System.Drawing.Point(474, 363);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(160, 44);
            this.btnInDanhSach.TabIndex = 3;
            this.btnInDanhSach.Text = "  In Danh Sách";
            this.btnInDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            this.btnInDanhSach.Click += new System.EventHandler(this.btnInDanhSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(662, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 45);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn mã phòng máy";
            // 
            // cboMaMay
            // 
            this.cboMaMay.FormattingEnabled = true;
            this.cboMaMay.Location = new System.Drawing.Point(206, 93);
            this.cboMaMay.Name = "cboMaMay";
            this.cboMaMay.Size = new System.Drawing.Size(121, 24);
            this.cboMaMay.TabIndex = 7;
            this.cboMaMay.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // FrmInDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.cboMaMay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.dgvInDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInDanhSach";
            this.Text = " In Danh Sach";
            this.Load += new System.EventHandler(this.FrmInDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInDanhSach;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaMay;
    }
}