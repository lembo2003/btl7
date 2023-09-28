using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_info : DAL_connection
    {

        public DTO_info GetUserInformation(string username)
        {
        DAL_connection dal = new DAL_connection();
        DTO_info info = new DTO_info();
        string sql = "SELECT account_info.* FROM account_info JOIN login ON account_info.username = login.username WHERE login.username = @username";
        SqlCommand cmd = new SqlCommand(sql);
        cmd.Parameters.AddWithValue("@username", username);
        SqlDataReader reader = dal.Read(cmd);
        while (reader.Read())
            {
                info.hoten = reader["hoten"].ToString();
                info.email = reader["email"].ToString();
                info.diachi = reader["diachi"].ToString();
                info.sdt = reader["sdt"].ToString();
            }
            return info;
        }
        public void Update_info(DTO_info ob)
        {
            string sql = "update account_info set hoten = N'" + ob.hoten + "',diachi = N'" + ob.diachi + "', sdt = '" + ob.sdt + "', email= N'" + ob.email + "' where username = '"+ob.username+"'";
            Excecute(sql);
        }
    }
}
