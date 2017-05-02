using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
   public  class HoaDonDichVu
    {
        private string ma;
        private string khachhangma;
        private string nhanvienxacnhan;
        private DateTime ngaysudung;
        private decimal tongtien;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Khachhangma
        {
            get
            {
                return khachhangma;
            }

            set
            {
                khachhangma = value;
            }
        }

        public string Nhanvienxacnhan
        {
            get
            {
                return nhanvienxacnhan;
            }

            set
            {
                nhanvienxacnhan = value;
            }
        }

        public DateTime Ngaysudung
        {
            get
            {
                return ngaysudung;
            }

            set
            {
                ngaysudung = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }

        }
        public DataTable get_hoadondichvu()
        {
            return DATA.get_hoadondichvu();
        }
        public int them_hoadondichvu()
        {
            return DATA.them_hoadondichvu(ma, khachhangma,nhanvienxacnhan,ngaysudung,tongtien);
        }
        public int sua_hoadondichvu()
        {
            return DATA.sua_hoadondichvu(ma, khachhangma, nhanvienxacnhan, ngaysudung, tongtien);
        }
        public int xoa_hoadondichvu(string ma)
        {
            return DATA.xoa_hoadondichvu(ma);
        }

    }
}
