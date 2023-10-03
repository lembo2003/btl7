using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoDich
    {
        public string maso;
        public string makh;
        public string sotiengui;
        public string maloaiso;
        public string ngaymoso;
        public string ngaydenhan;
        public string maquydinh;

        public DTO_GiaoDich() { }
        public DTO_GiaoDich(string maso, string makh, string sotiengui, string tenloaiso, string ngaymoso, string ngaydenhan, string maquydinh)
        {
            this.maso = maso;
            this.makh = makh;
            this.sotiengui = sotiengui;
            this.maloaiso = tenloaiso;
            this.ngaymoso = ngaymoso;
            this.ngaydenhan = ngaydenhan;
            this.maquydinh  = maquydinh;
        }
    }
}
