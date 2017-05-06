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

        private void frmDSphieuthue_Load(object sender, EventArgs e)
        {
            
            HienThi();
        }
    }
}
