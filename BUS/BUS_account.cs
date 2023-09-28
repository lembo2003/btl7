using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_account
    {
        public static bool Check_login(DTO_account ob)
        {
            return DAL_account.Check_login(ob);
        }
        public static string Check_type(DTO_account ob)
        {
            return DAL_account.Check_type(ob);
        }
        DAL_account dal = new DAL_account();
        public void Update_login(DTO_account ob)
        {
            dal.Update_login(ob);
        }
        public static DTO_account GetUserInformationLogin(string username)
        {
            DAL_account DAL = new DAL_account();
            return DAL.GetUserInformationLogin(username);
        }
    }
}
