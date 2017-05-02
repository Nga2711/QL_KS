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
            txtMa.Enabled = false;
            txtTinhTrang.Enabled = false;
            txtGia.Enabled = false;
            txtLoaiPhong.Enabled = false;
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

        void HienThi_cboNVxacnhan()
        {
            DataTable dt =nv.get_nhanvien();
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
        }

        public int TinhTrang1()
        {
            DataTable dt = new DataTable();
            string sql = "Select tinhtrang from phong where ma='" + txtPhongMa.Text + "'";
            dt = DBConnect.GetData(sql);
            string x;
            x= dt.Rows[0][0].ToString();
            if (x == "trống")
            {
                return 1;
            }
            return 0;
        }
 

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if (TinhTrang1()==1)
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
            if (txtKHma.Text == "")
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
                kh.Quoctich = txtQuocTich.Text;
                kh.them_khachhang();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Lỗi!");
                return;
            }
            HienThi_TTKH();
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
    }
}
