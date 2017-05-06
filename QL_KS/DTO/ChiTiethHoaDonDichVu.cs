using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class ChiTiethHoaDonDichVu
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
        public DataTable get_CTHDdichvu()
        {
            return DATA.get_CTHDdichvu();
        }
        public DataTable get_mahoadon()
        {
            return DATA.get_mahoadon();
        }
        public DataTable get_CTDV()
        {
            return DATA.get_CTDV();
        }
        public int them_CTHDdichvu()
        {
            return DATA.them_CTHDdichvu(hoadondichvuma,dichvuma,soluong,thanhtien);
        }
        public int sua_CTHDdichvu()
        {
            return DATA.sua_CTHDdichvu(hoadondichvuma, dichvuma, soluong, thanhtien);
        }
        public int xoa_CTHDdichvu(string hoadondichvuma, string dichvuma)
        {
            return DATA.xoa_CTHDdichvu(hoadondichvuma,dichvuma);
        }

    }
}
