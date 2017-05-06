using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class UC_login : UserControl
    {
        public UC_login()
        {
            InitializeComponent();
            scan = false;
        }
        private string namenv;
        public bool scan
        { get; set; }
        public delegate void Login(string username,bool login);
        public event Login LoginEvent;
        private void btn_login_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            DataTable dt = nv.get_nhanvien();
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((txt_ID.Text.CompareTo(dt.Rows[i]["ma"].ToString()) != 0 || txt_password.Text.CompareTo(dt.Rows[i]["matkhau"].ToString()) != 0)&&i==dt.Rows.Count-1)
                    {

                        lbl_error.Visible = true;
                        scan = false;
                    }
                    else if(txt_ID.Text.CompareTo(dt.Rows[i]["ma"].ToString()) == 0 && txt_password.Text.CompareTo(dt.Rows[i]["matkhau"].ToString()) == 0)
                    {
                        namenv = dt.Rows[i]["ten"].ToString();
                        scan = true;
                        
                        if (LoginEvent != null)
                        {
                            LoginEvent(namenv, scan);
                            this.Dispose();
                        }
                    }
                }
            }
            else
            scan = false;
        
        }
        private void btn_login_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UC_login_MouseLeave(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
