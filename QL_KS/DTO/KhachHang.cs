using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string ma;
        private string ten;
        private bool gioitinh;
        private string sdt;
        private string cmnd;
        private string diachi;
        private string quoctich;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }
    }
}
