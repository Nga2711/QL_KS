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
        PhieuThue pt = new PhieuThue();

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
            txtma.Enabled = false;
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
                        DataTable dt = new DataTable();
                        string sql = @"Select soluong from dichvu where ma='" + cthddv.Dichvuma + "'";
                        dt = DBConnect.GetData(sql);
                        dv.Ma = cthddv.Dichvuma;
                        dv.Soluong = int.Parse(dt.Rows[0][0].ToString()) - int.Parse(dgvGioHang[1, i].Value.ToString());
                        dv.capnhatSL();
                    cthddv.them_CTHDdichvu();

                }
               
              
                MessageBox.Show("Thêm thành công!");            
            }
            catch
            {
                MessageBox.Show("Lỗi!");
                return;
            }
            HienThi_DV();
            txtma.Text = null;
            cboKHma.Text = null;
            cboNVma.Text = null;
            txtTongTien.Text = null;
            dgvGioHang.Rows.Clear();
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
                string sql = "Select * from dichvu where ma='" + dgvGioHang.Rows[Row_Index].Cells[0].Value.ToString() + "'";
                dt = DBConnect.GetData(sql);
                if (int.Parse(dgvGioHang.Rows[Row_Index].Cells[1].Value.ToString()) < int.Parse(dt.Rows[0][2].ToString()))
                {
                    decimal a = decimal.Parse(dt.Rows[0][4].ToString()) * decimal.Parse(dgvGioHang.Rows[Row_Index].Cells[1].Value.ToString());
                    dgvGioHang.Rows[Row_Index].Cells[2].Value = a;
                    decimal thanhtien = 0;
                    for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                    {
                        thanhtien += decimal.Parse(dgvGioHang[2, i].Value.ToString());
                    }
                    txtTongTien.Text = thanhtien.ToString();

                }
                else
                {
                    MessageBox.Show("Trong kho không đủ hàng");
                    dgvGioHang.Rows[Row_Index].Cells[0] = null;
                }
            }
            catch
            {

            }

            HienThi_cboDVma();
          
        }

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            frmDSHDDV frm = new frmDSHDDV();
            frm.ShowDialog();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    txtma.Text = null;
                    DataTable dt = hddv.Get_HoaDonDichVu();
                    if (dt != null)

                    {
                        List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
                        if (list.Count > 0) txtma.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtma.Text = "0000000001";
                    }
                    else txtma.Text = "0000000001";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvGioHang.CurrentRow.Index;
                dgvGioHang.Rows.RemoveAt(i);
            }
            catch
            {

            }
         
           
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {          
                dgvGioHang.Rows.Clear();         
        }
    }
}
