using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_GD_noiquy
    {
        DAL_GD_noiquy GD = new DAL_GD_noiquy();
        public DataTable Load_noiquy_nonGD()
        {
            return GD.Load_noiquy_nonGD();
        }
    }
}
