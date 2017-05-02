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
    public partial class UC_SuDungDichVu : UserControl
    {
        public UC_SuDungDichVu()
        {
            InitializeComponent();
        }
        DichVu dv = new DichVu();
        KhachHang kh = new KhachHang();
        NhanVien nv = new NhanVien();
        HoaDonDichVu hddv = new HoaDonDichVu();
        ChiTiethHoaDonDichVu cthddv = new ChiTiethHoaDonDichVu();

        void HienThi_cboKHma()
        {
            DataTable dt = kh.get_makhachhang();
            cboKHma.DataSource = dt;
            cboKHma.DisplayMember = "ma";
            cboKHma.ValueMember = "ma";
        }
        void HienThi_cboNVma()
        {
            DataTable dt = nv.get_nhanvien();
            cboNVma.DataSource = dt;
            cboNVma.DisplayMember = "ma";
            cboNVma.ValueMember = "ma";
        }

        void HienThi_cboDVma()
        {
            DataTable dt = dv.get_madichvu();
            dvma.DataSource = dt;
            dvma.DisplayMember = "ma";
            dvma.ValueMember = "ma";
        }

        void HienThi_DV()
        {
            DataTable dt = dv.get_DSdichvu();
            dgvDichVu.DataSource = dt;
        }
      void  HienThiCTDV()
        {
            DataTable dt = cthddv.get_CTDV();
            dgvGioHang.DataSource = dt;
        }
        private void UC_SuDungDichVu_Load(object sender, EventArgs e)
        {
            HienThi_DV();
            HienThi_cboKHma();
            HienThi_cboNVma();
            HienThi_cboDVma();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }
            try
            {
                hddv.Ma = txtma.Text;
                hddv.Khachhangma = cboKHma.Text;
                hddv.Nhanvienxacnhan = cboNVma.Text;
                hddv.Ngaysudung = Convert.ToDateTime(dtpNgay.Text);
                hddv.Tongtien = Convert.ToDecimal(txtTongTien.Text);
                hddv.them_hoadondichvu();
                
                for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                {
                    cthddv.Hoadondichvuma = txtma.Text;
                    cthddv.Dichvuma= dgvGioHang[0, i].Value.ToString();
                    cthddv.Soluong = int.Parse(dgvGioHang[1, i].Value.ToString());
                    cthddv.Thanhtien = decimal.Parse(dgvGioHang[2, i].Value.ToString());
                }
                cthddv.them_CTHDdichvu();
                MessageBox.Show("Thêm thành công!");
  
             
            }
            catch
            {
                MessageBox.Show("Lỗi!");
                return;
            }
        }

 
        

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvGioHang_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row_Index = e.RowIndex;
                DataTable dt = new DataTable();
                string sql="Select * from dichvu where ma='"+ dgvGioHang.Rows[Row_Index].Cells[0].Value.ToString() + "'";
                dt = DBConnect.GetData(sql);
                decimal a = decimal.Parse(dt.Rows[0][4].ToString()) * decimal.Parse(dgvGioHang.Rows[Row_Index].Cells[1].Value.ToString()) ;
                dgvGioHang.Rows[Row_Index].Cells[2].Value = a;
                decimal thanhtien = 0;
                for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                {
                    thanhtien += decimal.Parse(dgvGioHang[2,i].Value.ToString());
                }
                   txtTongTien.Text = thanhtien.ToString();
               
            }
            catch
            {

            }
        }

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
