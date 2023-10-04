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
        DAL_LaiSuat LS = new DAL_LaiSuat();
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
        public void TatToan(string maso)
        {
            //tinh //interest bi loi// 3.15
            int thoihan = gd.get_ThoiHan(maso);
            double laisuat = gd.get_LaiSuat(thoihan);
            double sotiengui = gd.get_SoTienGui(maso);
            string makh = gd.get_MaKH(maso);
            double sodu = gd.GetSodu(makh);
            double tienlai = sotiengui * laisuat/100 * thoihan*30;
            double newBalance = sodu +sotiengui +tienlai;
            //cap nhat so du
            gd.Capnhatsodu(makh, newBalance);
            //xoa(ve sau la chuyen sang lich su giao dich)
            gd.Delete_GiaoDich(maso);
        }
    }
}
