using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_QuyDinh:DAL_Connection
    {
        public DAL_QuyDinh() { }
        public DataTable Load_QuyDinh()
        {
            return Load("select * from QuyDinh");
        }
        public void Insert_QuyDinh(DTO_QuyDinh ob)
        {
            string sql = "insert into QuyDinh values('" + ob.maquydinh + "',N'" + ob.tenquydinh + "',N'" + ob.noidung + "')";
            Excecute(sql);
        }
        public void Update_QuyDinh(DTO_QuyDinh ob)
        {
            string sql="update QuyDinh set tenquydinh=N'"+ob.tenquydinh+"', noidung=N'"+ob.noidung+"'where maquydinh='"+ob.maquydinh+"'";
            Excecute(sql );
        }
        public void Delete_QuyDinh(string maquydinh)
        {
            string sql = "delete from QuyDinh where maquydinh='" + maquydinh + "'";
            Excecute (sql);
        }
        public DataTable Load_GetTenQuyDinh()
        {
            return Load("select tenquydinh from QuyDinh");
        }
    }
}
