using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class frmDSHDDV : Form
    {
        public frmDSHDDV()
        {
            InitializeComponent();
        }
        HoaDonDichVu hddv = new HoaDonDichVu();

        void HienThi()
        {
            DataTable dt = hddv.Get_HoaDonDichVu();
           dgvDSHDDV.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select * from hoadondichvu where ma like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvDSHDDV.DataSource = dt;
        }

        private void frmDSHDDV_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            frmCTHDdichvu frm = new frmCTHDdichvu();
            frm.ShowDialog();
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
