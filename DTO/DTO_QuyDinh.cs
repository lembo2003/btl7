using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuyDinh
    {
        public string maquydinh;
        public string tenquydinh;
        public string noidung;
        
        public DTO_QuyDinh() { }
        public DTO_QuyDinh(string maquydinh, string tenquydinh, string noidung)
        {
            this.maquydinh = maquydinh;
            this.tenquydinh= tenquydinh;
            this.noidung = noidung;
        }
    }
}
