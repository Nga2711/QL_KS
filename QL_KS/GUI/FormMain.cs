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
using DTO;
namespace GUI
{

    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            DTO.Connect.SetConnectString(Application.StartupPath.Replace(@"bin\Debug", @"data\DB_KhachSan.mdf"));
            while (!DTO.Connect.Open() && MessageBox.Show("Can not connect DataBase", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ;
            MessageBox.Show(DTO.Connect.GetSqlConnection().State.ToString());
            InitializeComponent();
           
        }
        private bool scanfrmlogin = false;
        private bool scanlogin = false;
        public void showControlND(System.Windows.Forms.Control obj)
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
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_DatPhong();
                showControlND(us);
            }
           
        }

        private void txtSuDung_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_SuDungDichVu();
                showControlND(us);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            UserControl us = new UC_HoadonPhong();
            showControlND(us);
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_loaiphong();
                showControlND(us);
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_Phong();
                showControlND(us);
            }

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_dichvu();
                showControlND(us);
            }

        }

        private void ntnNhanVien_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin==true)
            {
                UserControl us = new UC_nhanvien();
                showControlND(us);
            }
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(btnDangNhap.Text.CompareTo("Đăng Nhập")==0)
            {
                UC_login lg = new UC_login();
                if (scanlogin == false)
                {
                    showControlND(lg);
                    lg.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
                    lg.LoginEvent += _LoginEvent;
                }

                else
                {
                    lg.Dispose();
                    pnND.Controls.Clear();
                }
                if (scanlogin == false)
                {
                    scanlogin = true;
                }
                else
                {
                    scanlogin = false;
                }
            }
        }
        private void _LoginEvent(string username, bool scan)
        {
            if (scan == true)
            {
                btnDangNhap.Text = "Xin chào "+username;
                scanfrmlogin = true;
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if(scanfrmlogin ==true)
            {
                UC_DoanhThu Doanhthu = new UC_DoanhThu();
                showControlND(Doanhthu);
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
