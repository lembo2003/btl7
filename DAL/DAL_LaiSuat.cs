using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LaiSuat:DAL_Connection
    {
        public DAL_LaiSuat() { }
        public DataTable Load_LaiSuat()
        {
            return Load("select * from LaiSuat");
        }
        public void Insert_LaiSuat(DTO_LaiSuat ob)
        {
            string sql="insert into LaiSuat values(N'"+ob.thoihan+"',N'"+ob.tenloaiso+"','"+ob.laisuat.ToString()+"')";
            Excecute(sql);
        }
        public void Update_LaiSuat(DTO_LaiSuat ob)
        {
            string sql = "update LaiSuat set thoihantenloaiso=N'" + ob.tenloaiso + "', laisuat='" + ob.laisuat.ToString() + "'where thoihan='" + ob.thoihan + "'";
            Excecute(sql);
        }
        public void Delete_LaiSuat(string thoihan)
        {
            string sql = "delete from LaiSuat where maloaiso='" + thoihan + "'";
            Excecute(sql);
        }
        public DataTable Load_LoaiSo()
        {
            return Load("select thoihan from LaiSuat");
        }

    }
}
