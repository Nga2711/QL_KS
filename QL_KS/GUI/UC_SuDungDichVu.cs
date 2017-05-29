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
            txt_nvma.Text = UC_login.manv;
        }

        void HienThi_DV()
        {
            DataTable dt = dv.get_DSdichvu();
            dt.Columns.Add("Chọn");
            dgvDichVu.DataSource = dt;
            for (int i = 0; i < dgvDichVu.Columns.Count; i++)
            {
                dgvDichVu.Columns[i].ReadOnly = true;
            }
            dgvDichVu.Columns[dgvDichVu.Columns.Count - 1].ReadOnly = false;
            dgvDichVu.Columns[dgvDichVu.Columns.Count - 1].Width = dgvDichVu.Columns[2].Width;
            dgvDichVu.Columns[0].Visible = false;
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
            txtma.Text = null;
            DataTable dt = hddv.Get_HoaDonDichVu();
            if (dt != null)

            {
                List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
                if (list.Count > 0)
                    txtma.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                else txtma.Text = "0000000001";
            }
            else txtma.Text = "0000000001";
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (txtma.Text == "")
            //{
            //    MessageBox.Show("Xin mời nhập thông tin đầy đủ");
            //    return;
            //}
            try
            {
                hddv.Ma = txtma.Text;
                hddv.Khachhangma = cboKHma.Text;
                hddv.Nhanvienxacnhan = txt_nvma.Text;
                hddv.Ngaysudung = DateTime.Now;
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
            txt_nvma.Text = null;
            txtTongTien.Text = null;
            dgvGioHang.Rows.Clear();
        }

        //private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        int Row_Index = e.RowIndex;
        //        DataTable dt = new DataTable();
        //        string sql = "Select * from dichvu where ma='" + dgvGioHang.Rows[Row_Index].Cells[0].Value.ToString() + "'";
        //        dt = DBConnect.GetData(sql);
        //        if (int.Parse(dgvGioHang.Rows[Row_Index].Cells[1].Value.ToString()) < int.Parse(dt.Rows[0][2].ToString()))
        //        {
        //            decimal a = decimal.Parse(dt.Rows[0][4].ToString()) * decimal.Parse(dgvGioHang.Rows[Row_Index].Cells[1].Value.ToString());
        //            dgvGioHang.Rows[Row_Index].Cells[2].Value = a;
        //            decimal thanhtien = 0;
        //            for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
        //            {
        //                thanhtien += decimal.Parse(dgvGioHang[2, i].Value.ToString());
        //            }
        //            txtTongTien.Text = thanhtien.ToString();

        //        }
        //        else
        //        {
        //            MessageBox.Show("Trong kho không đủ hàng");
        //            dgvGioHang.Rows[Row_Index].Cells[0] = null;
        //        }
        //    }
        //    catch
        //    {

        //    }
            
        //}

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            frmDSHDDV frm = new frmDSHDDV();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvGioHang.CurrentRow.Index;
                dgvGioHang.Rows.RemoveAt(i);
                if(dgvGioHang.RowCount>0)
                {
                    capnhattongtien();
                }
            }
            catch
            {

            }
         
           
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {          
                dgvGioHang.Rows.Clear();
            txtTongTien.Text = "";
        }

        private void dgvDichVu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string ten="", soluong="",thanhtien="";
            int temp;
            decimal gia;
            if(dgvDichVu.CurrentRow!=null)
            {
                if (dgvDichVu.CurrentRow.Cells[1].Value.ToString()!="")
                ten = dgvDichVu.CurrentRow.Cells[1].Value.ToString();
                if (dgvDichVu.CurrentRow.Cells[dgvDichVu.ColumnCount-1].Value.ToString() != "")
                    soluong = dgvDichVu.CurrentCell.Value.ToString();
                bool kq = decimal.TryParse(dgvDichVu.CurrentRow.Cells[4].Value.ToString(), out gia);
                if (kq == false)
                {
                    MessageBox.Show("Giá Tiền có vấn đề");
                }
                if(dgvDichVu.CurrentRow.Cells[2].Value.ToString()!="")
                {
                    kq = int.TryParse(soluong, out temp);
                    if (kq)
                    {
                        int sumsl;
                        sumsl = int.Parse(dgvDichVu.CurrentRow.Cells[2].Value.ToString());
                        if(temp>sumsl && sumsl>0)
                        {
                            thanhtien = (sumsl * gia).ToString();
                        }
                        else if (temp > 0  )
                        {
                            thanhtien = (temp * gia).ToString();
                        }
                        else
                        {
                            dgvDichVu.CurrentRow.Cells[dgvDichVu.ColumnCount - 1].Value = "0";
                            return;
                        }
                    }
                }
                for (int i = 0; i < dgvGioHang.RowCount; i++)
                {
                    if (dgvGioHang.Rows[i].Cells[0].Value.ToString() == ten) 
                    {
                        dgvGioHang.Rows[i].Cells[dgvGioHang.ColumnCount - 1].Value = thanhtien;
                        dgvGioHang.Rows[i].Cells[dgvGioHang.ColumnCount - 2].Value = soluong;
                        return;
                    }
                }
                dgvGioHang.Rows.Add(ten,soluong,thanhtien);
                capnhattongtien();
            }

        }
        private void capnhattongtien()
        {
            decimal gia;
            gia = 0;
            for (int i = 0; i < dgvGioHang.RowCount ; i++)
            {
                gia += decimal.Parse(dgvGioHang.Rows[i].Cells[dgvGioHang.ColumnCount - 1].Value.ToString());
            }
            txtTongTien.Text = gia.ToString();
        }
    }
}
