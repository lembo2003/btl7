using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Connection
    {
        SqlConnection con = new SqlConnection(@"Data Source=lembolaptop\sqlserver;Initial Catalog=QLSTK;Integrated Security=True");
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
        public float Executee(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object result = cmd.ExecuteScalar();
            con.Close();

            // Convert the result to float and return it
            if (result != null && float.TryParse(result.ToString(), out float interest))
            {
                return interest;
            }
            else
            {
                // Return a default value or throw an exception if the conversion failed
                return 0;
            }
        }
    }
}
