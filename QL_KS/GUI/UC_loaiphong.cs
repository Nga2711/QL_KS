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
    public partial class UC_loaiphong : UserControl
    {
        public UC_loaiphong()
        {
            InitializeComponent();
        }
        LoaiPhong lp = new LoaiPhong();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtgia.Enabled = false;
            txtchatluong.Enabled = false;
            txtmota.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtgia.Enabled = true;
            txtchatluong.Enabled = true;
            txtmota.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;

        }

        void SetNull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtgia.Text = "";
            txtchatluong.Text = "";
            txtmota.Text = "";

        }
        void HienThi()
        {
            DataTable dt = lp.get_loaiphong();
            dgvLoaiPhong.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select * from loaiphong where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvLoaiPhong.DataSource = dt;
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtma.Text = dgvLoaiPhong.Rows[Row_Index].Cells[0].Value.ToString();
                txtten.Text = dgvLoaiPhong.Rows[Row_Index].Cells[1].Value.ToString();
                txtgia.Text = dgvLoaiPhong.Rows[Row_Index].Cells[2].Value.ToString();
                txtchatluong.Text = dgvLoaiPhong.Rows[Row_Index].Cells[3].Value.ToString();
                txtmota.Text = dgvLoaiPhong.Rows[Row_Index].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }


        private void UC_loaiphong_Load(object sender, EventArgs e)
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
            txtma.Enabled = false;
            ThemMoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lp.Ma = txtma.Text;
                lp.xoa_loaiphong(lp.Ma);
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
            if (txtma.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    lp.Ma = txtma.Text;
                    lp.Ten = txtten.Text;
                    decimal a;
                    decimal.TryParse(txtgia.Text, out a);
                    lp.Gia = a;
                    int b;
                    int.TryParse(txtchatluong.Text, out b);
                    lp.Chatluong = b;
                    lp.Mota = txtmota.Text;
                    lp.them_loaiphong();
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
                    lp.Ma = txtma.Text;
                    lp.Ten = txtten.Text;
                    decimal a;
                    decimal.TryParse(txtgia.Text, out a);
                    lp.Gia = a;
                    int b;
                    int.TryParse(txtchatluong.Text, out b);
                    lp.Chatluong = b;
                    lp.Mota = txtmota.Text;
                    lp.sua_loaiphong();
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
    }
}
