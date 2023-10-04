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
    public class BUS_LaiSuat
    {
        DAL_LaiSuat LS=new DAL_LaiSuat();
        public DataTable LS_Load_Bus()
        {
            return LS.Load_LaiSuat();
        }
        public void LS_Insert_Bus(DTO_LaiSuat ob)
        {
            LS.Insert_LaiSuat(ob);
        }
        public void LS_Update_Bus(DTO_LaiSuat ob)
        {
            LS.Update_LaiSuat(ob);
        }
        public void LS_Delete_Bus(string thoihan)
        {
            LS.Delete_LaiSuat(thoihan);
        }
        public List<string> Get_TenLoaiSo()
        {
            DataTable dt = LS.Load_LoaiSo();
            List<string> thoihanList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                thoihanList.Add(row["thoihan"].ToString());
            }
            return thoihanList;
        }
    }
}
