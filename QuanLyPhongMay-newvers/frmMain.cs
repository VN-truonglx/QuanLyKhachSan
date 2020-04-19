using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyPhongMay_newvers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lịchThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmLichThucHanh f = new QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mônThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmMonThucHanh f = new QuanLyPhongMay_newvers.ChildForms.QuanLyLichThucHanh.frmMonThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void lịchThựcHànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay_newvers.ChildForms.TimKiem.frmTimKiemLichThucHanh f = new QuanLyPhongMay_newvers.ChildForms.TimKiem.frmTimKiemLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
