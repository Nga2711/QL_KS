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
    public partial class UC_Phong : UserControl
    {
        public UC_Phong()
        {
            InitializeComponent();
        }
        Phong p = new Phong();
        LoaiPhong lp = new LoaiPhong();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTinhTrang.Enabled = false;
            cboLoaiPhong.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTinhTrang.Enabled = true;
            cboLoaiPhong.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
        }
        void SetNull()
        {
            txtMa.Text = "";
            cboLoaiPhong.Text = "";
            txtTinhTrang.Text = "";
        }

        void HienThi()
        {
            DataTable dt = p.get_phong();
            dgvPhong.DataSource = dt;
        }

        void HienThi_cboMaLoaiPhong()
        {
            DataTable dt = lp.get_maloaiphong();
            cboLoaiPhong.DataSource = dt;
            cboLoaiPhong.DisplayMember = "ma";
            cboLoaiPhong.ValueMember = "ma";
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma,loaiphongma,tinhtrang  from phong where ma like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvPhong.DataSource = dt;
        }
        private void UC_Phong_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
            HienThi_cboMaLoaiPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvPhong.Rows[Row_Index].Cells[0].Value.ToString();
                cboLoaiPhong.Text = dgvPhong.Rows[Row_Index].Cells[2].Value.ToString();
                txtTinhTrang.Text = dgvPhong.Rows[Row_Index].Cells[1].Value.ToString();

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
                    if (dgvPhong.DataSource != null)
                    {
                        List<string> list = ((DataTable)dgvPhong.DataSource).AsEnumerable().Select(x => x.Field<string>(dgvPhong.Columns[0].Name)).ToList();
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
                p.Ma = txtMa.Text;
                p.xoa_phong(p.Ma);
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
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    p.Ma = txtMa.Text;
                    p.Loaiphongma = cboLoaiPhong.Text;
                    p.Tinhtrang = txtTinhTrang.Text;
                    p.them_phong();
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
                    p.Ma = txtMa.Text;
                    p.Loaiphongma = cboLoaiPhong.Text;
                    p.Tinhtrang = txtTinhTrang.Text;
                    p.sua_phong();
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
