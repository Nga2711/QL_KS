using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DATA
    {

        #region Dich Vu
        public static DataTable get_dichvu()
        {
            return DBConnect.GetData("get_dichvu");
        }
        public static void them_dichvu(string ma, string ten, int soluong, string donvitinh, decimal gia)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@donvitinh",(donvitinh!=null && donvitinh.Trim()!="")?(object)donvitinh:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value)
            };
            DBConnect.ExecuteNonQuery("them_dichvu", para);
        }
        public static void sua_dichvu(string ma, string ten, int soluong, string donvitinh, decimal gia)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@donvitinh",(donvitinh!=null && donvitinh.Trim()!="")?(object)donvitinh:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value)
            };
            DBConnect.ExecuteNonQuery("sua_dichvu", para);
        }
        public static void xoa_dichvu(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            DBConnect.ExecuteNonQuery("xoa_dichvu", para);
        }
        #endregion
        #region LoaiPhong
        public static DataTable get_loaiphong()
        {
            return DBConnect.GetData("get_loaiphong");
        }
        public static void them_loaiphong(string ma, string ten, decimal gia, int chatluong, string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value),
                 new SqlParameter("@chatluong",(chatluong >0)?(object)chatluong:DBNull.Value),
                 new SqlParameter("@mota",(ten!=null && mota.Trim()!="")?(object)mota:DBNull.Value),
            };
            DBConnect.ExecuteNonQuery("them_loaiphong", para);
        }
        public static void sua_loaiphong(string ma, string ten, decimal gia, int chatluong, string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",ma),
                 new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                 new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value),
                 new SqlParameter("@chatluong",(chatluong >0)?(object)chatluong:DBNull.Value),
                 new SqlParameter("@mota",(ten!=null && mota.Trim()!="")?(object)mota:DBNull.Value),
            };
            DBConnect.ExecuteNonQuery("sua_loaiphong", para);
        }
        public static void xoa_loaiphong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            DBConnect.ExecuteNonQuery("xoa_loaiphong", para);
        }
        #endregion
        #region Phong
        public static DataTable get_phong()
        {
            return DBConnect.GetData("get_phong");
        }
        public static void them_phong(string ma, string loaiphongma, string tinhtrang)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@loaiphongma",(loaiphongma!=null && loaiphongma.Trim()!="")?(object)loaiphongma:DBNull.Value),
                new SqlParameter("@tinhtrang",(tinhtrang!=null && tinhtrang.Trim()!="")?(object)tinhtrang:DBNull.Value)
            };
            DBConnect.ExecuteNonQuery("them_phong", para);
        }
        public static void sua_phong(string ma, string loaiphongma, string tinhtrang)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",ma),
                new SqlParameter("@loaiphongma",(loaiphongma!=null && loaiphongma.Trim()!="")?(object)loaiphongma:DBNull.Value),
                new SqlParameter("@tinhtrang",(tinhtrang!=null && tinhtrang.Trim()!="")?(object)tinhtrang:DBNull.Value)
            };
            DBConnect.ExecuteNonQuery("sua_phong", para);
        }
        public static void xoa_phong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            DBConnect.ExecuteNonQuery("xoa_phong", para);
        }
        #endregion

        #region Khachhang
        public static DataTable get_khachhang()
        {
            return DBConnect.GetData("get_khachhang");
        }
        public static int them_khachhang(string ma, string ten, bool gioitinh, string sdt, string cmnd, string diachi, string quoctich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@cmnd", cmnd),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@quoctich", quoctich)
            };
            return DBConnect.ExecuteNonQuery("them_khachhang", para);
        }
        public static int sua_khachhang(string ma, string ten, bool gioitinh, string sdt, string cmnd, string diachi, string quoctich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@sdt", sdt),
                new SqlParameter("@cmnd", cmnd),
                new SqlParameter("@diachi", diachi),
                new SqlParameter("@quoctich", quoctich)
            };
            return DBConnect.ExecuteNonQuery("sua_khachhang", para);
        }
        public static int xoa_khachhang(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_khachhang", para);
        }
        #endregion

        #region Phieuthue
        public static DataTable get_phieuthue()
        {
            return DBConnect.GetData("get_phieuthue");
        }
        public static int them_phieuthue(string ma, DateTime ngayden, string khachhangma, string nhanvienxacnhan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ngayden",(ngayden.Year!=1000)?(object)ngayden:DBNull.Value),
                new SqlParameter("@khachhangma",khachhangma),
                new SqlParameter("@nhanvienxacnhan",nhanvienxacnhan)
            };
            return DBConnect.ExecuteNonQuery("them_phieuthue", para);
        }
        public static int sua_phieuthue(string ma, DateTime ngayden, string khachhangma, string nhanvienxacnhan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ngayden",(ngayden.Year!=1000)?(object)ngayden:DBNull.Value),
                new SqlParameter("@khachhangma",khachhangma),
                new SqlParameter("@nhanvienxacnhan",nhanvienxacnhan)
            };
            return DBConnect.ExecuteNonQuery("sua_phieuthue", para);
        }
        public static int xoa_phieuthue(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_phieuthue", para);
        }
        #endregion

        #region Nhanvien
        public static DataTable get_nhanvien()
        {
            return DBConnect.GetData("get_nhanvien");
        }
        public static int them_nhanvien(string ma, string ten, bool gioitinh, DateTime ngaysinh, string sdt, string diachi, string matkhau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@ngaysinh",(ngaysinh.Year!=1000)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@diachi",diachi),
                new SqlParameter("@matkhau",matkhau)
            };
            return DBConnect.ExecuteNonQuery("them_nhanvien",para);
        }
        public static int sua_nhanvien(string ma, string ten, bool gioitinh, DateTime ngaysinh, string sdt, string diachi, string matkhau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@ngaysinh",(ngaysinh.Year!=1000)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@diachi",diachi),
                new SqlParameter("@matkhau",matkhau)
            };
            return DBConnect.ExecuteNonQuery("sua_nhanvien", para);
        }
        public static int xoa_nhanvien(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_nhanvien", para);
        }
        #endregion
    }
}
