using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class PhieuThue
    {
        private string ma;
        private DateTime ngayden;
        private string khachhangma;
        private string nhanvienxacnhan;
        private string phongma;
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

        public string Phongma
        {
            get
            {
                return phongma;
            }

            set
            {
                phongma = value;
            }
        }

        public DataTable get_phieuthue()
        {
            return DATA.get_phieuthue();
        }
        public DataTable get_phieuthuema()
        {
            return DATA.get_phieuthuema();
        }
        public void them_phieuthue()
        {
            DATA.them_phieuthue(ma, ngayden,nhanvienxacnhan,khachhangma,phongma);
        }
        public void sua_phieuthue()
        {
            DATA.sua_phieuthue(ma, ngayden, nhanvienxacnhan, khachhangma,phongma);
        }
        public void xoa_phieuthue(string ma)
        {
            DATA.xoa_phieuthue(ma);
        }

    }
}
