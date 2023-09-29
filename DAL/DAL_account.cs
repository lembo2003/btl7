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
    public class DAL_account : DAL_connection
    {
        public static bool Check_login(DTO_account ob)
        {
            DAL_connection dal = new DAL_connection();
            string sql = "select * from login where username='" + ob.tk + "' and password='" + ob.mk + "'";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@tk", ob.tk);
            cmd.Parameters.AddWithValue("@mk", ob.mk);
            DataTable dt = dal.Load(sql);
            return dt.Rows.Count > 0;
        }
        public static string Check_type(DTO_account ob)
        {
            string account_type = null;
            DAL_connection dal = new DAL_connection();
            string sql = "SELECT type FROM login WHERE username ='"+ob.tk+"'";
            
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@tk", ob.tk);

            SqlDataReader read = dal.Read(sql);
            if (read.Read())
            {
                if(!read.IsDBNull(0))
                {
                    account_type = read.GetString(0);
                }
            }
            return account_type;

        }
        public DTO_account GetUserInformationLogin(string tk)
        {
            DAL_connection dal = new DAL_connection();
            DTO_account account = new DTO_account();
            string sql = "SELECT * FROM login WHERE username = @tk";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@tk", tk);
            SqlDataReader reader = dal.Read(cmd);
            while (reader.Read())
            {
                //account.tk = reader["tk"].ToString();
                account.tk = reader["username"].ToString(); // Use the correct column name
                account.mk = reader["password"].ToString();
            }
            return account;
        }
        public void Update_login(DTO_account ob)
        {
            string sql = "update login set username = '" + ob.tk + "',password = '" + ob.mk + "'where username = '" + ob.tk + "'";
            Excecute(sql);
        }
    }
}
