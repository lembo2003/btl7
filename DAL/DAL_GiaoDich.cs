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
        public void Capnhatsodu(string makh, double newBalance)
        {
            Excecute("update khachhang set sodu= " + newBalance + " where makh='" + makh + "'");
        }
        public float get_LaiSuat(int thoihan)
        {
            DataTable dt = Load("select laisuat from Laisuat where thoihan='" + thoihan + "'");
            if (dt.Rows.Count > 0)
            {
                return float.Parse(dt.Rows[0]["laisuat"].ToString());
            }
            else
            {
                Console.WriteLine("No rows returned.");
                return 0; // or any default value
            }
        }

        public int get_ThoiHan(string maso)
        {
            DataTable dt = Load("select thoihan from GiaoDich where maso='" + maso + "'");
            if (dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["thoihan"].ToString());
            }
            else
            {
                Console.WriteLine("No rows returned.");
                return 0; // or any default value
            }
        }

        public float get_SoTienGui(string maso)
        {
            DataTable dt = Load("select sotiengui from giaodich where maso='" + maso + "'");
            if (dt.Rows.Count > 0)
            {
                return float.Parse(dt.Rows[0]["sotiengui"].ToString());
            }
            else
            {
                Console.WriteLine("No rows returned.");
                return 0; // or any default value
            }
        }

        public string get_MaKH(string maso)
        {
            DataTable dt = Load("select makh from giaodich where maso='" + maso + "'");
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["makh"].ToString();
            }
            else
            {
                // Handle the case where no rows were returned
                Console.WriteLine("No rows returned.");
                return null;
            }
        }
    }
}
