﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class UC_dichvu : UserControl
    {
        public UC_dichvu()
        {
            InitializeComponent();
        }

        DichVu dv = new DichVu();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonViTinh.Enabled = false;
            txtGia.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtGia.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtDonViTinh.Text = "";
        }

        void HienThi()
        {
            DataTable dt = dv.get_dichvu();
            dgvDichVu.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select * from dichvu where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvDichVu.DataSource = dt;
        }


        private void UC_dichvu_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvDichVu.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvDichVu.Rows[Row_Index].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDichVu.Rows[Row_Index].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvDichVu.Rows[Row_Index].Cells[3].Value.ToString();
                txtGia.Text = dgvDichVu.Rows[Row_Index].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetNull();
                    if (dgvDichVu.DataSource != null)
                    {
                        List<string> list = ((DataTable)dgvDichVu.DataSource).AsEnumerable().Select(x => x.Field<string>(dgvDichVu.Columns[0].Name)).ToList();
                        if (list.Count > 0) txtMa.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtMa.Text = "0000000001";
                    }
                    else txtMa.Text = "0000000001";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            ThemMoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dv.Ma = txtMa.Text;
                dv.xoa_dichvu(dv.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ!");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    int a;
                    decimal b;
                    dv.Ma = txtMa.Text;
                    dv.Ten = txtTen.Text;
                    int.TryParse(txtSoLuong.Text, out a);
                    dv.Soluong = a;
                    decimal.TryParse(txtGia.Text, out b);
                    dv.Donvitinh = txtDonViTinh.Text;
                    dv.Gia = b;
                    dv.them_dichvu();
                    MessageBox.Show("Đã thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            else
            {
                try
                {
                    int a;
                    decimal b;
                    dv.Ma = txtMa.Text;
                    dv.Ten = txtTen.Text;
                    int.TryParse(txtSoLuong.Text, out a);
                    dv.Soluong = a;
                    decimal.TryParse(txtGia.Text, out b);
                    dv.Donvitinh = txtDonViTinh.Text;
                    dv.Gia = b;
                    dv.sua_dichvu();
                    MessageBox.Show("Đã sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }

            }
            SetNull();
            KhoaDieuKhien();
            HienThi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "nhập vào khóa muốn tìm kiếm...")
            {
                HienThi();

            }
            else
                TimKiem();
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_MouseLeave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.ForeColor = Color.Gray;
                txtTimKiem.Text = "nhập vào khóa muốn tìm kiếm...";
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
