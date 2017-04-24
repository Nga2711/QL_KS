using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThue
    {
        private string ma;
        private DateTime ngayden;
        private string khachhangma;
        private string nhanvienxacnhan;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public DateTime Ngayden
        {
            get { return ngayden; }
            set { ngayden = value; }
        }
        public string Khachhangma
        {
            get { return khachhangma; }
            set
            {
                khachhangma = value;
            }
        }
        public string Nhanvienxacnhan
        {
            get { return nhanvienxacnhan; }
            set { nhanvienxacnhan = value; }
        }
    }
}
