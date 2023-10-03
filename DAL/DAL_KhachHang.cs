using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang:DAL_Connection
    {
        public DAL_KhachHang() { }
        public DataTable Load_KhachHang()
        {
            return Load("select * from KhachHang");
        }
        public void Insert_KhachHang(DTO_KhachHang ob)
        {
            string sql = "insert into KhachHang values('" + ob.makh + "',N'" + ob.hoten + "',N'" + ob.diachi + "','" + ob.cccd + "','" + ob.sdt + "','" + ob.sodu.ToString() + "')";
            Excecute(sql);
        }
        public void Update_KhachHang(DTO_KhachHang ob)
        {
            string sql = "update KhachHang set hoten=N'" + ob.makh + "',diachi=N'" + ob.diachi + "',cccd='" + ob.cccd + "', sdt='" + ob.sdt + "', sodu='" + ob.sodu.ToString() + "' where makh='"+ob.makh+"'";
            Excecute(sql);
        }
        public void Delete_KhachHang(string makh)
        {
            string sql = "delete from KhachHang where makh='" + makh + "'";
            Excecute(sql);
        }
        public DataTable Load_makhachhang()
        {
            return Load("select makh from khachhang");
        }
    }
}
