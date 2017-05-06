using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
    public  class DichVu
    {
        private string ma;
        private string ten;
        private int soluong;
        private string donvitinh;
        private decimal gia;

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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
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

        public string Donvitinh
        {
            get
            {
                return donvitinh;
            }

            set
            {
                donvitinh = value;
            }
        }

        public decimal Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }
        public DataTable get_dichvu()
        {
            return DATA.get_dichvu();
        }
        public DataTable get_dichvu1(string ma)
        {
            return DATA.get_dichvu1(ma);
        }
        public DataTable get_madichvu()
        {
            return DATA.get_madichvu();
        }
        public DataTable get_DSdichvu()
        {
            return DATA.get_DSdichvu();
        }
        public void them_dichvu()
        {
            DATA.them_dichvu(ma, ten, soluong, donvitinh, gia);
        }
        public void sua_dichvu()
        {
            DATA.sua_dichvu(ma, ten, soluong, donvitinh, gia);
        }
        public void capnhatSL()
        {
            DATA.capnhatSL(ma, soluong);
        }
        public void xoa_dichvu(string ma)
        {
            DATA.xoa_dichvu(ma);
        }

    }
}
