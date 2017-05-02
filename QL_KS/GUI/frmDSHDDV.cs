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

        private void frmDSHDDV_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
