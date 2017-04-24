using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
   public class LoaiPhong
    {
        private string ma;
        private string ten;
        private decimal gia;
        private int chatluong;
        private string mota;

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

        public int Chatluong
        {
            get
            {
                return chatluong;
            }

            set
            {
                chatluong = value;
            }
        }

        public string Mota
        {
            get
            {
                return mota;
            }

            set
            {
                mota = value;
            }
        }
        public DataTable get_loaiphong()
        {
            return DATA.get_loaiphong();
        }
        public int them_loaiphong()
        {
            return DATA.them_loaiphong(ma, ten, gia, chatluong, mota);
        }
        public int sua_loaiphong()
        {
            return DATA.sua_loaiphong(ma, ten, gia, chatluong, mota);
        }
        public static int xoa_loaiphong(string ma)
        {
            return DATA.xoa_loaiphong(ma);
        }
    }
}
