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
        public void them_phong()
        {
            DATA.them_phong(ma, tinhtrang, loaiphongma);
        }
        public void sua_phong()
        {
            DATA.sua_phong(ma, tinhtrang, loaiphongma);
        }
        public void xoa_phong(string ma)
        {
            DATA.xoa_phong(ma);
        }
    }
}
