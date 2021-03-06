﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using QuanlyKhSan.Class;

namespace QuanlyKhSan
{
    public partial class Form1 : Form
    {
        DataTable tblPhong;
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtMaPhong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
           loadDataGridView();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
           Application.Exit();
        }
        private void loadDataGridView()
        {
        string sql;
        sql = "SELECT * FROM tblPhong";
        tblPhong = Class.Functions.GetDataIntoTable(sql);
        dataGridView1.DataSource = tblPhong; //Nguồn dữ liệu            

        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dataGridView1.CurrentRow.Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text =dataGridView1.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Enabled = true;
            txtMaPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblPhong SET TenPhong=N'" + txtTenPhong.Text.ToString() + "', DonGia=N'" + txtDonGia.Text.ToString() + "' " +
                "WHERE MaPhong=N'" + txtMaPhong.Text + "'";
            Class.Functions.RunSQL(sql);
            loadDataGridView();
            
           
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            {
                sql = "DELETE tblPhong WHERE MaPhong=N'" + txtMaPhong.Text + "'";
                Class.Functions.RunSqlDel(sql);
                loadDataGridView();
                txtMaPhong.Text = "";
                txtTenPhong.Text = "";
                txtDonGia.Text = "";

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenPhong.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGia.Focus();
                return;
            }
            sql = "Select MaPhong From tblPhong where MaPhong=N'" + txtMaPhong.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }

            sql = "INSERT INTO tblPhong VALUES(N'" +
                txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + txtDonGia.Text + "')";
            Class.Functions.RunSQL(sql); 
            loadDataGridView(); 
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;

    }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtDonGia.Text = "";
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhong.Enabled = false;
        }
    }
}
