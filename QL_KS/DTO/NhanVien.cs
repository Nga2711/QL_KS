using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class NhanVien
    {
        private string ma;
        private string ten;
        private bool gioitinh;
        private DateTime ngaysinh;
        private string sdt;
        private string diachi;
        private string matkhau;
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
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set
            {
                ngaysinh = value;
            }

        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }

        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public DataTable get_nhanvien()
        {
            return DATA.get_nhanvien();
        }
        public void them_nhanvien()
        {
            DATA.them_nhanvien(ma, ten, gioitinh,ngaysinh,sdt,diachi,matkhau);
        }
        public void sua_nhanvien()
        {
            DATA.sua_nhanvien(ma, ten, gioitinh, ngaysinh, sdt, diachi, matkhau);
        }
        public void xoa_nhanvien(string ma)
        {
            DATA.xoa_nhanvien(ma);
        }
    }
}
