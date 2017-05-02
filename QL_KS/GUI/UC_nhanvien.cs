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
    public partial class UC_nhanvien : UserControl
    {
        public UC_nhanvien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        bool ThemMoi;

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtMatKhau.Enabled = false;
            cboGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhap.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtMatKhau.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhap.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            cboGioiTinh.Text = "";
         //   dtpNgaySinh.Format = DateTimePickerFormat.Custom;
        }

        void HienThi()
        {
            DataTable dt = nv.get_nhanvien();
            dgvNhanVien.DataSource = dt;
        }
     

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text=dgvNhanVien.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvNhanVien.Rows[Row_Index].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[Row_Index].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[Row_Index].Cells[3].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[Row_Index].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[Row_Index].Cells[5].Value.ToString();
                txtMatKhau.Text = dgvNhanVien.Rows[Row_Index].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }
        private void UC_nhanvien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
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
                nv.Ma = txtMa.Text;
                nv.xoa_nhanvien(nv.Ma);
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

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    if (cboGioiTinh.Text == "Nam")
                    {
                        nv.Gioitinh = true;
                    }
                    else
                    {
                        nv.Gioitinh = false;
                    }
                    nv.Ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
                    nv.Sdt = txtSDT.Text;
                    nv.Diachi = txtDiaChi.Text;
                    nv.Matkhau = txtMatKhau.Text;
                    nv.them_nhanvien();
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

                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    if (cboGioiTinh.Text == "Nam")
                    {
                        nv.Gioitinh = true;
                    }
                    else
                    {
                        nv.Gioitinh = false;
                    }
                    nv.Ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
                    nv.Sdt = txtSDT.Text;
                    nv.Diachi = txtDiaChi.Text;
                    nv.Matkhau = txtMatKhau.Text;
                    nv.sua_nhanvien();
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
    }
}
