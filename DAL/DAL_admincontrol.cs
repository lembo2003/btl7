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
        public void Insert_AdminControl(DTO_admincontrol ob)
        {
            string sql = "insert into login values('" + ob.username + "','" + ob.password + "','" + ob.type + "')";
            Excecute(sql);
            string sql2 = "insert into account_info values('" + ob.username + "', '" + ob.hoten + "', '" + ob.diachi + "', '" + ob.email + "', '" + ob.sdt + "')";
            Excecute(sql2);            
        }
        public void Update_AdminControl(DTO_admincontrol ob)
        {
            string sql2 = "update account_info set hoten = @hoten, diachi = @diachi, email = @email, sdt = @sdt where username = @username";
            SqlCommand command2 = new SqlCommand(sql2);
            command2.Parameters.AddWithValue("@username", ob.username);
            command2.Parameters.AddWithValue("@hoten", ob.hoten);
            command2.Parameters.AddWithValue("@diachi", ob.diachi);
            command2.Parameters.AddWithValue("@email", ob.email);
            command2.Parameters.AddWithValue("@sdt", ob.sdt);
            Execute_CMD(command2);

            string sql = "update login set password = @password, type = @type where username = @username";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@username", ob.username);
            command.Parameters.AddWithValue("@password", ob.password);
            command.Parameters.AddWithValue("@type", ob.type);
            Execute_CMD(command);
        }
        public void Delete_AdminControl(DTO_admincontrol ob)
        {
            string sql2 = "delete from account_info where username = @username";
            SqlCommand command2 = new SqlCommand(sql2);
            command2.Parameters.AddWithValue("@username", ob.username);
            Execute_CMD(command2);

            string sql = "delete from login where username = @username";
            SqlCommand command = new SqlCommand(sql);
            command.Parameters.AddWithValue("@username", ob.username);
            Execute_CMD(command);
        }
    }
}
