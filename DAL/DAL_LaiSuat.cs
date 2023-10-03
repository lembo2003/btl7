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
            string sql="insert into LaiSuat values('"+ob.maloaiso+"',N'"+ob.thoihan+"',N'"+ob.tenloaiso+"','"+ob.laisuat.ToString()+"')";
            Excecute(sql);
        }
        public void Update_LaiSuat(DTO_LaiSuat ob)
        {
            string sql = "update LaiSuat set thoihan=N'" + ob.thoihan + "',tenloaiso=N'" + ob.tenloaiso + "', laisuat='" + ob.laisuat.ToString() + "'where maloaiso='" + ob.maloaiso + "'";
            Excecute(sql);
        }
        public void Delete_LaiSuat(string maloaiso)
        {
            string sql = "delete from LaiSuat where maloaiso='" + maloaiso + "'";
            Excecute(sql);
        }
        public DataTable Load_LoaiSo()
        {
            return Load("select thoihan from LaiSuat");
        }

    }
}
