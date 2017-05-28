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
using System.Windows.Input;

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
        public static string manv; 
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
                        manv = txt_ID.Text;
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


        private void txt_ID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                EventArgs test = new EventArgs();
                btn_login_Click(sender, test);
            }
            
        }

        private void txt_password_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs test = new EventArgs();
                btn_login_Click(sender, test);
            }
        }
    }
}
