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
    public class DAL_GD_noiquy :DAL_connection
    {
        public DataTable Load_noiquy_nonGD()
        {
            return Load("SELECT rules.tennd, rules.noidung, account_info.hoten FROM rules JOIN account_info ON rules.username = account_info.username WHERE rules.tinhtrang = N'Hoạt Động'");
        }

    }
}
