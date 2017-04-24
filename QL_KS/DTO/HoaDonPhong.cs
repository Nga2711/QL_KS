using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonPhong
    {
        string phongma;
        string phieuthuema;
        DateTime ngaydi;
        int songaythue;
        decimal thanhtien;
        DateTime ngaythanhtoan;
        string nhanvienxacnhan;

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

        public string Phieuthuema
        {
            get
            {
                return phieuthuema;
            }

            set
            {
                phieuthuema = value;
            }
        }

        public DateTime Ngaydi
        {
            get
            {
                return ngaydi;
            }

            set
            {
                ngaydi = value;
            }
        }

        public int Songaythue
        {
            get
            {
                return songaythue;
            }

            set
            {
                songaythue = value;
            }
        }

        public decimal Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }

        public DateTime Ngaythanhtoan
        {
            get
            {
                return ngaythanhtoan;
            }

            set
            {
                ngaythanhtoan = value;
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

        public static int xoa_hoadonphong(string phongma, string phieuthuema)
        {
            return DAL.DATA.xoa_hoadonphong(phongma, phieuthuema);
        }

        public int sua_hoadonphong()
        {
            return DAL.DATA.sua_hoadonphong(phongma, phieuthuema, ngaydi, songaythue, thanhtien, ngaythanhtoan, nhanvienxacnhan);
        }

        public int them_hoadonphong()
        {
            return DAL.DATA.them_hoadonphong(phongma, phieuthuema, ngaydi, songaythue, thanhtien, ngaythanhtoan, nhanvienxacnhan);
        }
    }
}
