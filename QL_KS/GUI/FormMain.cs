using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace GUI
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
         
        }

        public void showControl(System.Windows.Forms.Control obj)
        {
            pnND.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            pnND.Controls.Add(obj);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pnND_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            UserControl us = new UC_DatPhong();
            showControl(us);
        }

        private void txtSuDung_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_SuDungDichVu();
            showControl(us);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_HoadonPhong();
            showControl(us);
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_loaiphong();
            showControl(us);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_Phong();
            showControl(us);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_dichvu();
            showControl(us);
        }

        private void ntnNhanVien_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_nhanvien();
            showControl(us);
        }

        private void btnSoLuongKhach_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                User32.ReleaseCapture();
                User32.SendMessage(this.Handle, User32.WM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
            }
        }
    }
    class User32
    {
        public static int HT_CAPTION = 0x2;
        public static int WM_NCLBUTTONDOWN = 0x00A1;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
