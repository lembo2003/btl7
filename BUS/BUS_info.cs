using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_info
    {
        DAL_info dal = new DAL_info();
        public static DTO_info GetUserInformation(string username)
        {
            DAL_info daL = new DAL_info();
            return daL.GetUserInformation(username);
        }
        public void Update_info(DTO_info ob)
        {
            dal.Update_info(ob);
        }
    }
}
