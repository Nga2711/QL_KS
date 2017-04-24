using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
  public  class Phong
    {
        private string ma;
        private string tinhtrang;
        private string loaiphongma;

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

        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }

        public string Loaiphongma
        {
            get
            {
                return loaiphongma;
            }

            set
            {
                loaiphongma = value;
            }
        }
        public DataTable get_phong()
        {
            return DATA.get_phong();
        }
        public int them_phong()
        {
            return DATA.them_phong(ma, tinhtrang, loaiphongma);
        }
        public int sua_phong()
        {
            return DATA.sua_phong(ma, tinhtrang, loaiphongma);
        }
        public int xoa_phong(string ma)
        {
            return DATA.xoa_phong(ma);
        }
    }
}
