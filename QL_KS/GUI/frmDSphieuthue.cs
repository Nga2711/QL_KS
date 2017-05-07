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
    public partial class frmDSphieuthue : Form
    {
        public frmDSphieuthue()
        {
            InitializeComponent();
        }
        PhieuThue pt = new PhieuThue();

        
        void HienThi()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma, khachhangma,phongma,nhanvienxacnhan,ngayden from phieuthue where phieuthue.ma not in (select hoadonphong.phieuthuema from hoadonphong ) ";
            dt=DBConnect.GetData(sql);
          //  DataTable dt = pt.get_phieuthue();
            dgvPT.DataSource = dt;
        }
        void TimKiem()
        {
            DataTable dt = new DataTable();
            string sql = @"Select ma, khachhangma,phongma,nhanvienxacnhan,ngayden from phieuthue where phieuthue.ma not in (select hoadonphong.phieuthuema from hoadonphong ) and phieuthue.ma like '%" + txtTimKiem.Text.Trim() + "%'  ";
         //   string sql = @"Select * from dichvu where ten like '%" + txtTimKiem.Text.Trim() + "%'";
            dt = DBConnect.GetData(sql);
            dgvPT.DataSource = dt;
        }
        private void frmDSphieuthue_Load(object sender, EventArgs e)
        {
            
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
