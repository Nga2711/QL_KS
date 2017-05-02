using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
    class ChiTietHoaDonDichVu
    {
        private string hoadondichvuma;
        private string dichvuma;
        private int soluong;
        private decimal thanhtien;

        public string Hoadondichvuma
        {
            get
            {
                return hoadondichvuma;
            }

            set
            {
                hoadondichvuma = value;
            }
        }

        public string Dichvuma
        {
            get
            {
                return dichvuma;
            }

            set
            {
                dichvuma = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
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
        public static DataTable Get_ChiTietHoaDonDichVu()
        {
            return DATA.get_chitiethoadondichvu();
        }
        public void Them()
        {
            DATA.them_chitiethoadondichvu(hoadondichvuma, dichvuma, soluong, thanhtien);
        }
        public void Sua()
        {
            DATA.sua_chitiethoadondichvu(hoadondichvuma, dichvuma, soluong, thanhtien);
        }
        public static void Xoa(string hoadondichvuma, string dichvuma)
        {
            DATA.xoa_chitiethoadondichvu(hoadondichvuma, dichvuma);
        }
    }
}
