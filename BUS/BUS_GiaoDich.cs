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
    public class BUS_GiaoDich
    {
        DAL_GiaoDich gd = new DAL_GiaoDich();

        public DataTable Load_BUS()
        {
            return gd.Load_GiaoDich();
        }
        public void Insert_Giaodich(DTO_GiaoDich ob)
        {
            gd.Insert_GiaoDich(ob);
        }
        public bool KtraTien(string makh, float sotiengui)
        {
            float balance = gd.GetSodu(makh);

            if(balance - sotiengui < 0)
            {
                return false;
            }
            gd.Capnhatsodu(makh, balance - sotiengui);
            return true;
        }
        public void TatToan(string maso,string makh, float sotiengui, int thoihan)
        {
            //tinh
            float interest = gd.get_LaiSuat(maso);
            float newBalance = sotiengui * interest / 100 * thoihan;
            //cap nhat so du
            gd.Capnhatsodu(makh, newBalance);
            //xoa(ve sau la chuyen sang lich su giao dich)
            gd.Delete_GiaoDich(maso);
        }
    }
}
