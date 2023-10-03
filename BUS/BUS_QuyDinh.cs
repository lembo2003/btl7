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
    public class BUS_QuyDinh
    {
        DAL_QuyDinh QD=new DAL_QuyDinh();
        public DataTable QD_Load_Bus()
        {
            return QD.Load_QuyDinh();
        }
        public void QD_Insert_Bus(DTO_QuyDinh ob)
        {
            QD.Insert_QuyDinh(ob);
        }
        public void QD_Update_Bus(DTO_QuyDinh ob)
        {
            QD.Update_QuyDinh(ob);
        }
        public void QD_Delete_Bus(string maquydinh)
        {
            QD.Delete_QuyDinh(maquydinh);
        }
        public List<string> Load_GetTenQuyDinh()
        {
            DataTable dt = QD.Load_GetTenQuyDinh();
            List<string> tenquydinhList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                tenquydinhList.Add(row["tenquydinh"].ToString());
            }
            return tenquydinhList;
        }
    }
}
