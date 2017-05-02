using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace DTO
{
    public class HoaDonDichVu
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

        //
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

        public DataTable Get_HoaDonDichVu()
        {
            return DATA.get_hoadondichvu();
        }
        public void them_hoadondichvu()
        {
            DATA.them_hoadondichvu(ma, khachhangma, nhanvienxacnhan, ngaysudung, tongtien);
        }
        public void Sua()
        {
            DATA.sua_hoadondichvu(ma, khachhangma, nhanvienxacnhan, ngaysudung, tongtien);
        }
        public static void Xoa(string ma)
        {
            DATA.xoa_hoadondichvu(ma);
        }
    }
}
