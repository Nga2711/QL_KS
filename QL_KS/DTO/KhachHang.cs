using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DAL;

namespace DTO
{
    public class KhachHang
    {
        private string ma;
        private string ten;
        private bool gioitinh;
        private string sdt;
        private string cmnd;
        private string diachi;
        private string quoctich;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public bool Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }
        public DataTable get_khachhang()
        {
            return DATA.get_khachhang();
        }
        public DataTable get_makhachhang()
        {
            return DATA.get_makhachhang();
        }

        public int them_khachhang()
        {
            return DATA.them_khachhang(ma, ten,gioitinh, sdt,cmnd,diachi,quoctich);
        }
        public int sua_khachhang()
        {
            return DATA.sua_khachhang(ma, ten, gioitinh, sdt, cmnd, diachi, quoctich);
        }
        public int xoa_khachhang(string ma)
        {
            return DATA.xoa_khachhang(ma);
        }
    }
}
