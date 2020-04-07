using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyKhachSancode
{
    public partial class frmMain : Form
    {
        DataTable tbl;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-L3MR5NP\SQLEXPRESS;Initial Catalog=Qly_KhSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            string sql = "select * from tblPhong";
            tbl = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tbl;
            txtMP.Enabled = false;
            txtTEN.Enabled = false;
            txtDG.Enabled=false;
            btnSua.Enabled = false;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void lbDonGia_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tblPhong where MaPhong='" + txtMP.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            txtMP.Enabled = false;
            txtTEN.Enabled = true;
            txtDG.Enabled = true;
            int i = dataGridView1.CurrentRow.Index;
            txtMP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTEN.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDG.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMP.Enabled = true;
            txtTEN.Enabled = true;
            txtDG.Enabled = true;
            txtMP.Text = "";
            txtTEN.Text = "";
            txtDG.Text = "";
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMP.Text=="")
            {
                MessageBox.Show("Hay nhap ma phong");
                txtMP.Focus();
                return;
            }
            string sql;
            sql = "select * from tblPhong where MaPhong='" + txtMP.Text + "'";
            if (Functions.Checkkey(sql))
            {
                MessageBox.Show("Mã phòng này đã  tồn tại");
                txtMP.Focus();
                txtMP.Text = "";
                return;
            }
            sql = "insert into tblPhong values ('" + txtMP.Text + "', '" + txtTEN.Text + "', " + txtDG.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            Functions.RunSql(sql);
            loaddata();
            /*string sql;
            sql="insert into tblPhong values ('"+txtMP.Text+"', '" + txtTEN.Text + "', " + txtDG.Text + ")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            loaddata();*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tblPhong set TenPhong='"+txtTEN.Text+"', DonGia="+txtDG.Text+"where MaPhong='"+txtMP.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
