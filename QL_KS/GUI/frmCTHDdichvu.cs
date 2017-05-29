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
    public partial class frmCTHDdichvu : Form
    {
        public frmCTHDdichvu()
        {
            InitializeComponent();
        }
        ChiTiethHoaDonDichVu cthddv = new ChiTiethHoaDonDichVu();
        void HienThi_cboHDDVma()
        {
            DataTable dt = cthddv.get_mahoadon();
            cboHDDVma.DataSource = dt;
            cboHDDVma.DisplayMember = "dichvuma";
            cboHDDVma.ValueMember = "dichvuma";
        }
        //void HienThi()
        //{
        //    DataTable dt = cthddv.get_CTHDdichvu();
        //    dgvCTHDdichvu.DataSource = dt;
        //}

        private void frmCTHDdichvu_Load(object sender, EventArgs e)
        {
            HienThi_cboHDDVma();
         //   HienThi();
        }



        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = @"Select dichvuma, soluong,thanhtien from chitiethoadondichvu where hoadondichvuma='" + cboHDDVma.Text + "'";
            dt = DBConnect.GetData(sql);
            dgvCTHDdichvu.DataSource = dt;
        }
    }
}
