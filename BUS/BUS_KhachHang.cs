using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang KH= new DAL_KhachHang();
        public DataTable KH_Load_Bus()
        {
            return KH.Load_KhachHang();
        }
        public void KH_Insert_Bus(DTO_KhachHang ob)
        {
            KH.Insert_KhachHang(ob);
        }
        public void KH_Update_Bus(DTO_KhachHang ob)
        {
            KH.Update_KhachHang(ob);
        }
        public void KD_Delete_Bus(string makh)
        {
            KH.Delete_KhachHang(makh);
        }
        public List<string> Load_makhachhang()
        {
            DataTable dt = KH.Load_makhachhang();
            List<string> makhList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                makhList.Add(row["makh"].ToString());
            }
            return makhList;
        }
    }
}
