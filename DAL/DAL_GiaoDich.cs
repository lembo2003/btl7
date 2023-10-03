using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiaoDich:DAL_Connection
    {
        public DAL_GiaoDich() { }
        public DataTable Load_GiaoDich()
        {
            return Load("select * from GiaoDich");
        }
        public void Insert_GiaoDich(DTO_GiaoDich ob)
        {
            string sql = "insert into GiaoDich values('"+ob.maso+"','"+ob.makh+"','"+ob.sotiengui.ToString()+"',N'"+ob.maloaiso+"','"+ob.ngaymoso+"','"+ob.ngaydenhan+"',N'"+ob.maquydinh+"')";
            Excecute(sql);
        }
        public void Update_GiaoDich(DTO_GiaoDich ob)
        {
            string sql = "update GiaoDich values ";
            Excecute(sql);
        }
        public void Delete_GiaoDich(string maso)
        {
            string sql = "delete from giaodich where maso='" + maso + "'";
            Excecute(sql);
        }
        public float GetSodu(string makh)
        {
            DataTable dt = Load("select sodu from khachhang where makh='" + makh + "'");
            return float.Parse(dt.Rows[0]["sodu"].ToString());
        }
        public void Capnhatsodu(string makh, float newBalance)
        {
            Excecute("update khachhang set sodu= " + newBalance + " where makh='" + makh + "'");
        }
        public float get_LaiSuat(string maso)
        {
            string sql = "select laisuat from Laisuat where maloaiso='" + maso + "'";
            float interest = Executee(sql);
            return interest;
        }
    }
}
