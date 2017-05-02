using System;
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
    public partial class UC_HoadonPhong : UserControl
    {
        public UC_HoadonPhong()
        {
            InitializeComponent();
        }
        PhieuThue pt = new PhieuThue();
        NhanVien nv = new NhanVien();
        HoaDonPhong hdp = new HoaDonPhong();
        Phong p = new Phong();

        void SetNull()
        {
            cboPTma.Text = "";
            txtPhongma.Text = "";
            txtSongay.Text = "";
            txtThanhTien.Text = "";
            dtpngaytt.Text = "";
            dtpngaydi.Text = "";
        }

        void HienThi_cboPTma()
        {
            DataTable dt = pt.get_phieuthuema();
            cboPTma.DataSource = dt;
            cboPTma.DisplayMember = "ma";
            cboPTma.ValueMember = "ma";
            
        }

        void HienThi_cboNVma()
        {
            DataTable dt = nv.get_nhanvien();
            cboNVma.DataSource = dt;
            cboNVma.DisplayMember = "ma";
            cboNVma.ValueMember = "ma";
        }
        void Phong_roi()
        {
            DataTable dt = new DataTable();
            string sql="update phong set tinhtrang=N'trống' when ma='"+ txtPhongma.Text + "'";
            dt = DBConnect.GetData(sql);
        }

        void HienThi()
        {
            DataTable dt = hdp.get_HDP();
            dgvhoadon.DataSource = dt;
        }


       
        private void UC_HoadonPhong_Load(object sender, EventArgs e)
        {
            txtPhongma.Enabled = false;
            txtSongay.Enabled = false;
            txtThanhTien.Enabled = false;
            HienThi_cboPTma();
            HienThi_cboNVma();
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                hdp.Phieuthuema = cboPTma.Text;
                hdp.Phongma = txtPhongma.Text;
                hdp.Ngaydi = Convert.ToDateTime(dtpngaydi.Text);
                hdp.Ngaythanhtoan = Convert.ToDateTime(dtpngaytt.Text);
                int k;
                int.TryParse(txtSongay.Text, out k);
                hdp.Songaythue = k;
                hdp.Nhanvienxacnhan = cboNVma.Text;
                hdp.Thanhtien = Convert.ToDecimal(txtThanhTien.Text);
                hdp.them_hoadonphong();
                p.Ma = txtPhongma.Text;
                p.capnhatttphongroi();
                MessageBox.Show("Thành công!");
               // SetNull();
                HienThi();
                Phong_roi();
                SetNull();
            }
            catch
            {

            }
            
            
        }

        private void btnXong_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            string sql = @"Select phongma from phieuthue where ma='" + cboPTma.Text + "'";
            dt = DBConnect.GetData(sql);
            txtPhongma.Text = dt.Rows[0][0].ToString();
            string sql1 = @"Select ngayden from phieuthue where ma='" + cboPTma.Text + "'";
            dt1 = DBConnect.GetData(sql1);
            DateTime ngayden = Convert.ToDateTime(dt1.Rows[0][0].ToString());
            TimeSpan ts;
            ts = Convert.ToDateTime(dtpngaydi.Text) - ngayden;
            txtSongay.Text = Convert.ToString(ts.TotalDays);
            string sql2 = @"Select gia from loaiphong, phong where phong.ma='" + txtPhongma.Text + "'and phong.loaiphongma=loaiphong.ma ";
            dt2 = DBConnect.GetData(sql2);
            int a;
            int.TryParse(txtSongay.Text, out a);
            decimal gia = Convert.ToDecimal(dt2.Rows[0][0].ToString());
            txtThanhTien.Text = Convert.ToString(a * gia);
        }

        private void cboPTma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            //DataTable dt2 = new DataTable();
            //string sql = @"Select phongma from phieuthue where ma='" + cboPTma.Text + "'";
            //dt = DBConnect.GetData(sql);
            //txtPhongma.Text = dt.Rows[0][0].ToString();
            //string sql1 = @"Select ngayden from phieuthue where ma='" + cboPTma.Text + "'";
            //dt1 = DBConnect.GetData(sql1);
            //DateTime ngayden = Convert.ToDateTime(dt1.Rows[0][0].ToString());
            //TimeSpan ts;
            //ts = Convert.ToDateTime(dtpngaydi.Text) - ngayden;
            //txtSongay.Text = Convert.ToString(ts.TotalDays);
            //string sql2 = @"Select gia from loaiphong, phong where phong.ma='" + txtPhongma.Text + "'and phong.loaiphongma=loaiphong.ma ";
            //dt2 = DBConnect.GetData(sql2);
            //int a;
            //int.TryParse(txtSongay.Text, out a);
            //decimal gia = Convert.ToDecimal(dt2.Rows[0][0].ToString());
            //txtThanhTien.Text = Convert.ToString(a * gia);
        }
    }
}
