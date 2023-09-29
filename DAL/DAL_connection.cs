using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_connection
    {
        SqlConnection con = new SqlConnection(@"Data Source=lembolaptop\sqlserver;Initial Catalog=btl7;Integrated Security=True");

        public DataTable Load(string sql)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable(); 
            ad.Fill(dt);
            con.Close();
            return dt;
        }

        public void Excecute(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader Read(string sql) 
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
        }
        public SqlDataReader Read(SqlCommand cmd) // Accept SqlCommand object
        {
            con.Open();
            cmd.Connection = con; // Set connection of SqlCommand
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
