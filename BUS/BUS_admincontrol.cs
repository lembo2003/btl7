using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_admincontrol
    {
        DAL_admincontrol admin = new DAL_admincontrol();
        public DataTable admin_LoadDGV()
        {
            return admin.admin_LoadDGV();
        }
        public static DTO_admincontrol GetUserInformationAdminC(string username)
        {
            DAL_admincontrol dal = new DAL_admincontrol();
            return dal.GetUserInformationAdminC(username);
        }
        public void Insert_AdminControl(DTO_admincontrol ob)
        {
            admin.Insert_AdminControl(ob);
        }
        public void Update_AdminControl(DTO_admincontrol ob)
        {
            admin.Update_AdminControl(ob);
        }
        public void Delete_AdminControl(DTO_admincontrol ob)
        {
            admin.Delete_AdminControl(ob);
        }
    }
}
