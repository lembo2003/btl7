using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_admincontrol : DAL_connection
    {
        public DataTable admin_LoadDGV()
        {
            return Load("SELECT login.username AS username, login.password,login.type,account_info.hoten,account_info.diachi,account_info.email,account_info.sdt FROM login JOIN account_info ON login.username = account_info.username;");
        }
        public DTO_admincontrol GetUserInformationAdminC(string username)
        {
            DAL_connection dal = new DAL_connection();
            DTO_admincontrol info = new DTO_admincontrol();
            string sql = "SELECT * FROM account_info JOIN login ON account_info.username = login.username WHERE login.username = @username";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = dal.Read(cmd);
            while (reader.Read())
            {
                info.hoten = reader["hoten"].ToString();
                info.email = reader["email"].ToString();
                info.diachi = reader["diachi"].ToString();
                info.sdt = reader["sdt"].ToString();
                info.username = reader["username"].ToString();
                info.password = reader["password"].ToString(); 
                info.type = reader["type"].ToString();
            }
            return info;
        }
    }
}
