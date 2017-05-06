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

        public static DataTable get_dichvu1(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.GetData("get_dichvu1");
        }
        public static DataTable get_madichvu()
        {
            return DBConnect.GetData("get_maDV");
        }
        public static DataTable get_DSdichvu()
        {
            return DBConnect.GetData("get_DSDV");
        }
        public static int them_dichvu(string ma, string ten, int soluong, string donvitinh, decimal gia)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@donvitinh",(donvitinh!=null && donvitinh.Trim()!="")?(object)donvitinh:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_dichvu", para);
        }
        
        public static int sua_dichvu(string ma, string ten, int soluong, string donvitinh, decimal gia)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@donvitinh",(donvitinh!=null && donvitinh.Trim()!="")?(object)donvitinh:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_dichvu", para);
        }

        public static int capnhatSL(string ma, int soluong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                  new SqlParameter("@ma",ma),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value)               
            };
            return DBConnect.ExecuteNonQuery("capnhatsoluong1", para);
        }
        public static int xoa_dichvu(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_dichvu", para);
        }
        #endregion

        #region LoaiPhong
        public static DataTable get_loaiphong()
        {
            return DBConnect.GetData("get_loaiphong");
        }
        public static DataTable get_maloaiphong()
        {
            return DBConnect.GetData("get_maloaiphong");
        }
        public static int them_loaiphong(
            string ma, 
            string ten, 
            decimal gia, 
            int chatluong, 
            string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value),
                 new SqlParameter("@chatluong",(chatluong >0)?(object)chatluong:DBNull.Value),
                 new SqlParameter("@mota",(ten!=null && mota.Trim()!="")?(object)mota:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("them_loaiphong", para);
        }
        public static int sua_loaiphong(
            string ma, 
            string ten, 
            decimal gia, 
            int chatluong, 
            string mota)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",ma),
                 new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                 new SqlParameter("@gia",(gia>0)?(object)gia:DBNull.Value),
                 new SqlParameter("@chatluong",(chatluong >0)?(object)chatluong:DBNull.Value),
                 new SqlParameter("@mota",(ten!=null && mota.Trim()!="")?(object)mota:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("sua_loaiphong", para);
        }
        public static int xoa_loaiphong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
           return DBConnect.ExecuteNonQuery("xoa_loaiphong", para);
        }
        #endregion

        #region Phong
        public static DataTable get_phong()
        {
            return DBConnect.GetData("get_phong");
        }
        public static DataTable get_phong_loaiphong()
        {
            return DBConnect.GetData("get_phong_loaiphong");
        }

        public static int capnhatttphong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
                
            };
            return DBConnect.ExecuteNonQuery("capnhatttphong", para);
        }

        public static int capnhatttphongroi(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)

            };
            return DBConnect.ExecuteNonQuery("capnhatttphongroi", para);
        }

        public static int them_phong(
            string ma, 
            string tinhtrang, 
            string loaiphongma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@tinhtrang",(tinhtrang!=null && tinhtrang.Trim()!="")?(object)tinhtrang:DBNull.Value),
                new SqlParameter("@loaiphongma",(loaiphongma!=null && loaiphongma.Trim()!="")?(object)loaiphongma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_phong", para);
        }
        public static int sua_phong(
            string ma,
            string tinhtrang,
            string loaiphongma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@tinhtrang",(tinhtrang!=null && tinhtrang.Trim()!="")?(object)tinhtrang:DBNull.Value),
                new SqlParameter("@loaiphongma",(loaiphongma!=null && loaiphongma.Trim()!="")?(object)loaiphongma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_phong", para);
        }
        public static int xoa_phong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_phong", para);
        }
        #endregion

        #region Hoa Don Phong
        public static DataTable get_HDP()
        {
            return DBConnect.GetData("get_HDP");
        }
        public static int them_hoadonphong(
            string phongma,
            string phieuthuema,
            DateTime ngaydi,
            int songaythue,
            decimal thanhtien,
            DateTime ngaythanhtoan,
            string nhanvienxacnhan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@phongma",phongma),
                new SqlParameter("@phieuthuema",phieuthuema),
                new SqlParameter("@ngaydi",(ngaydi!=null && ngaydi.Year>1800)?(object)ngaydi:DBNull.Value),
                new SqlParameter("@songaythue",(songaythue>0)?songaythue:0),
                new SqlParameter("@thanhtien",(thanhtien>0)?thanhtien:0),
                new SqlParameter("@ngaythanhtoan",(ngaythanhtoan!=null && ngaythanhtoan.Year>1800)?(object)ngaythanhtoan:DBNull.Value),
                new SqlParameter("@nhanvienxacnhan",(nhanvienxacnhan!=null && nhanvienxacnhan.Trim()!="")?(object)nhanvienxacnhan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_hoadonphong", para);
        }
        public static int sua_hoadonphong(
            string phongma,
            string phieuthuema,
            DateTime ngaydi,
            int songaythue,
            decimal thanhtien,
            DateTime ngaythanhtoan,
            string nhanvienxacnhan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@phongma",phongma),
                new SqlParameter("@phieuthuema",phieuthuema),
                new SqlParameter("@ngaydi",(ngaydi!=null && ngaydi.Year>1800)?(object)ngaydi:DBNull.Value),
                new SqlParameter("@songaythue",(songaythue>0)?songaythue:0),
                new SqlParameter("@thanhtien",(thanhtien>0)?thanhtien:0),
                new SqlParameter("@ngaythanhtoan",(ngaythanhtoan!=null && ngaythanhtoan.Year>1800)?(object)ngaythanhtoan:DBNull.Value),
                new SqlParameter("@nhanvienxacnhan",(nhanvienxacnhan!=null && nhanvienxacnhan.Trim()!="")?(object)nhanvienxacnhan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_hoadonphong", para);
        }
        public static int xoa_hoadonphong(string phongma, string phieuthuema)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@phongma", phongma),
                 new SqlParameter("@phieuthuema", phieuthuema),
           };
           return DBConnect.ExecuteNonQuery("xoa_hoadonphong", para);
        }
        #endregion

        #region Khachhang
        public static DataTable get_khachhang()
        {
            return DBConnect.GetData("get_khachhang");
        }
        public static DataTable get_makhachhang()
        {
            return DBConnect.GetData("get_maKH");
        }
        public static int them_khachhang(string ma, string ten, bool gioitinh, string sdt, string cmnd, string diachi, string quoctich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
             //   new SqlParameter("@gioitinh",(gioitinh!=null && gioitinh.Trim()!="")?(object)ten:DBNull.Value),
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

        public static DataTable get_phieuthuema()
        {
            return DBConnect.GetData("get_PTma");
        }
        public static int them_phieuthue(string ma, DateTime ngayden, string nhanvienxacnhan, string khachhangma,string phongma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ngayden",(ngayden.Year!=1000)?(object)ngayden:DBNull.Value),
                new SqlParameter("@khachhangma",khachhangma),
                new SqlParameter("@nhanvienxacnhan",nhanvienxacnhan),
                new SqlParameter("@phongma",phongma)
            };
            return DBConnect.ExecuteNonQuery("them_phieuthue", para);
        }
        public static int sua_phieuthue(string ma, DateTime ngayden, string nhanvienxacnhan, string khachhangma,string phongma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ngayden",(ngayden.Year!=1000)?(object)ngayden:DBNull.Value),
                new SqlParameter("@khachhangma",khachhangma),
                new SqlParameter("@nhanvienxacnhan",nhanvienxacnhan),
                new SqlParameter("@phongma",phongma)
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
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@ngaysinh",(ngaysinh.Year!=1000)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@sdt",sdt),
                new SqlParameter("@diachi",diachi),
                new SqlParameter("@matkhau",matkhau),
                  
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

        #region Hoa Don Dich Vu
        public static DataTable get_hoadondichvu()
        {
            return DBConnect.GetData("get_hoadondichvu");
        }

 
        public static int them_hoadondichvu(string ma, string khachhangma, string nhanvienxacnhan, DateTime ngaysudung , decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@khachhangma",(khachhangma!=null && khachhangma.Trim()!="")?(object)khachhangma:DBNull.Value),
                new SqlParameter("@nhanvienxacnhan",(nhanvienxacnhan!=null && nhanvienxacnhan.Trim()!="")?(object)nhanvienxacnhan:DBNull.Value),
                new SqlParameter("@ngaysudung",(ngaysudung.Year!=1000)?(object)ngaysudung:DBNull.Value),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_hoadondichvu", para);
        }
        public static int sua_hoadondichvu(string ma, string khachhangma, string nhanvienxacnhan, DateTime ngaysudung, decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
               new SqlParameter("@ma",ma),
                new SqlParameter("@khachhangma",(khachhangma!=null && khachhangma.Trim()!="")?(object)khachhangma:DBNull.Value),
                new SqlParameter("@nhanvienxacnhan",(nhanvienxacnhan!=null && nhanvienxacnhan.Trim()!="")?(object)nhanvienxacnhan:DBNull.Value),
                new SqlParameter("@ngaysudung",(ngaysudung.Year!=1000)?(object)ngaysudung:DBNull.Value),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_hoadondichvu", para);
        }
        public static int xoa_hoadondichvu(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_hoadondichvu", para);
        }
        #endregion

        #region Chi Tiet Hoa Don Dich Vu
        public static DataTable get_CTHDdichvu()
        {
            return DBConnect.GetData("get_CTHDdichvu");
        }

        public static DataTable get_CTDV()
        {
            return DBConnect.GetData("get_CTDV");
        }
        public static DataTable get_mahoadon()
        {
            return DBConnect.GetData("get_mahoadon");
        }
        public static int them_CTHDdichvu(string hoadondichvuma, string dichvuma, int soluong, decimal thanhtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@hoadondichvuma",hoadondichvuma),
                new SqlParameter("@dichvuma",dichvuma),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                new SqlParameter("@thanhtien",(thanhtien>0)?(object)thanhtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_CTHDdichvu", para);
        }
        public static int sua_CTHDdichvu(string hoadondichvuma, string dichvuma, int soluong, decimal thanhtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("@hoadondichvuma",hoadondichvuma),
                new SqlParameter("@dichvuma",dichvuma),
                new SqlParameter("@soluong",(soluong >0)?(object)soluong:DBNull.Value),
                 new SqlParameter("@thanhtien",(thanhtien>0)?(object)thanhtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_CTHDdichvu", para);
        }
        public static int xoa_CTHDdichvu(string hoadondichvuma,string dichvuma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@hoadondichvuma",hoadondichvuma),
                 new SqlParameter("@dichvuma",dichvuma),
           };
            return DBConnect.ExecuteNonQuery("xoa_CTHDdichvu", para);
        }
        #endregion

    }
}
