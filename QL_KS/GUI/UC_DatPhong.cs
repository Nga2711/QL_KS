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
    public partial class UC_DatPhong : UserControl
    {
        //private bool active = false;
        //private bool activeseach = false;
        //private string lastc;
        //private int lasti;
        public UC_DatPhong()
        {
            InitializeComponent();
        }
        Phong p = new Phong();
        LoaiPhong lp = new LoaiPhong();
        PhieuThue pt = new PhieuThue();
        KhachHang kh = new KhachHang();
        NhanVien nv = new NhanVien();

        void KhoaDieuKhien()
        {
            txtPhongMa.Enabled = false;
            cboKHma.Enabled = false;
            txtMa.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtGia.Enabled = false;
            txtLoaiPhong.Enabled = false;
        }

        void KhoaKH()
        {
            txtTen.Enabled = false;
            cboGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            cbb_quoctich.Enabled = false;
        }

        void MoKH()
        {
            txtTen.Enabled = true;
            cboGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            cbb_quoctich.Enabled = true;
        }

        void KhoaPT()
        {
            dtpngay.Enabled = false;
            cboNVxaclap.Enabled = false;
        }

        void MoPT()
        {
            dtpngay.Enabled = true;
            cboNVxaclap.Enabled = true;
        }
        void SetNull()
        {
            txtMa.Text = "";
            txtTinhTrang.Text = "";
            txtGia.Text = "";
            txtLoaiPhong.Text = "";
        }
        void SetNull1()
        {
            txtmaphieu.Text = "";
            cboNVxaclap.Text = "";
            cboKHma.Text = "";
            txtPhongMa.Text = "";
        }

        void SetNullKH()
        {
            txtKHma.Text = "";
            txtTen.Text = "";
            cboGioiTinh.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            cbb_quoctich.Text = "";
        }

        void HienThi_cboNVxacnhan()
        {
            DataTable dt = nv.get_nhanvien();
            cboNVxaclap.DataSource = dt;
            cboNVxaclap.DisplayMember = "ma";
            cboNVxaclap.ValueMember = "ma";
        }

        //void Phong_Ban()
        //{
        //    DataTable dt = new DataTable();
        //    string sql = "update phong set tinhtrang=N'bận' when ma='" + txtPhongMa.Text + "'";
        //    dt = DBConnect.GetData(sql);

        //}

        void HienThi()
        {
            DataTable dt = p.get_phong_loaiphong();
            dgvPhong_LoaiPhong.DataSource = dt;
            dgvPhong_LoaiPhong.Columns["Mã phòng"].Width = 100;
            dgvPhong_LoaiPhong.Columns["Mã loại phòng"].Width = 100;
            dgvPhong_LoaiPhong.Columns["Giá"].Width = 150;
            dgvPhong_LoaiPhong.Columns["Tình trạng"].Width = 140;
        }
        void HienThi_TTKH()
        {
            DataTable dt = kh.get_khachhang();
            dgvKhachHang.DataSource = dt;

        }

        private void dgvPhong_LoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvPhong_LoaiPhong.Rows[Row_Index].Cells[0].Value.ToString();
                txtLoaiPhong.Text = dgvPhong_LoaiPhong.Rows[Row_Index].Cells[1].Value.ToString();
                txtGia.Text = dgvPhong_LoaiPhong.Rows[Row_Index].Cells[2].Value.ToString();
                txtTinhTrang.Text = dgvPhong_LoaiPhong.Rows[Row_Index].Cells[3].Value.ToString();
                txtPhongMa.Text = dgvPhong_LoaiPhong.Rows[Row_Index].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void UC_DatPhong_Load(object sender, EventArgs e)
        {           
            KhoaDieuKhien();
            HienThi();
            HienThi_TTKH();
            HienThi_cboNVxacnhan();
            KhoaKH();
            KhoaPT();
          
        }

        public int TinhTrang1()
        {
            DataTable dt = new DataTable();
            string sql = "Select tinhtrang from phong where ma='" + txtPhongMa.Text + "'";
            dt = DBConnect.GetData(sql);
            string x;
            x = dt.Rows[0][0].ToString();
            if (string.Compare(x, "trống", true) == 0)
            {
                return 0;
            }
            return 1;
        }





        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmaphieu.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }
            if (TinhTrang1() == 0)
            {
                try
                {
                    pt.Ma = txtmaphieu.Text;
                    pt.Ngayden = Convert.ToDateTime(dtpngay.Text);
                    pt.Nhanvienxacnhan = cboNVxaclap.Text;
                    pt.Khachhangma = cboKHma.Text;
                    pt.Phongma = txtPhongMa.Text;
                    pt.them_phieuthue();
                    p.Ma = txtPhongMa.Text;
                    p.capnhatttphong();
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
                MessageBox.Show("Phòng này đang bận! Chọn phòng trống!");
            }
            HienThi();
            SetNull1();
        }



        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            if (txtTen.Text==""||cboGioiTinh.Text==""||txtCMND.Text=="")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }

            try
            {
                kh.Ma = txtKHma.Text;
                kh.Ten = txtTen.Text;
                if (cboGioiTinh.Text == "Nam")
                {
                    kh.Gioitinh = true;
                }
                else
                {
                    kh.Gioitinh = false;
                }
                kh.Sdt = txtSDT.Text;
                kh.Cmnd = txtCMND.Text;
                kh.Diachi = txtDiaChi.Text;
                kh.Quoctich = cbb_quoctich.Text;
                kh.them_khachhang();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi!");
                return;
            }
            HienThi_TTKH();
            SetNullKH();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row_Index = e.RowIndex;
            cboKHma.Text = dgvKhachHang.Rows[Row_Index].Cells[0].Value.ToString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmDSphieuthue frm = new frmDSphieuthue();
            frm.ShowDialog();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            
        //    if (active == false)
        //    {
        //        DataTable dt;
        //        string id = "KH";
        //        int x = 0;
        //        Random a = new Random();
        //        do
        //        {
        //            while (x == 0)
        //            {
        //                x = a.Next(0, 99999999);
        //            }

        //            if (x.ToString().Length < 8)

        //            {
        //                for (int i = 0; i < 8 - x.ToString().Length; i++)
        //                {
        //                    id += '0';
        //                }
        //            }
        //            dt = DBConnect.GetData("select ma from khachang where ma = '"+id+"'");
        //        } while (dt!=null);
        //        id += x.ToString();
        //        txtKHma.Text = id;

        //        active = true;
        //    }

        }

        private void cbb_quoctich_MouseClick(object sender, MouseEventArgs e)
        {
           
            ToolTip a = new ToolTip();
            a.SetToolTip(cbb_quoctich, cbb_quoctich.SelectedText);
        }

        //private bool scanvalue(string text, DataColumn dt)
        //{
        //    foreach(var item in dt.Table.Rows)
        //    {
        //        if(item.ToString()== text)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //private string seachtext(string text , DataColumn dt)
        //{
        //    if(text== lastc)
        //    {
        //        lasti++;
        //    }
        //    else
        //    {
        //        lasti = 0;
        //        lastc = text;
        //    }
        //    for(int i = 0;i<dt.Table.Rows.Count;i++)
        //    {
        //        if(dt.Table.Rows[i].ToString().Contains(text)&&i == lasti)
        //        {
        //            return dt.Table.Rows[i].ToString();
        //        }
        //    }
        //    return "";
        //}

        private void btnLuu_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
      
        private void btnCapNhat_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            MoKH();
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    txtKHma.Text = null;
                    DataTable dt = kh.get_khachhang();
                    if (dt != null)

                    {
                        List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
                        if (list.Count > 0) txtKHma.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtKHma.Text = "0000000001";
                    }
                    else txtKHma.Text = "0000000001";
                }
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MoPT();
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    txtmaphieu.Text = null;
                    DataTable dt = pt.get_phieuthue();
                    if (dt != null)

                    {
                        List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
                        if (list.Count > 0) txtmaphieu.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtmaphieu.Text = "0000000001";
                    }
                    else txtmaphieu.Text = "0000000001";
                }
            }
        }

        private void pnThongTinPhong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
