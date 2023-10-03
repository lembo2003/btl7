using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LaiSuat
    {
        public string maloaiso;
        public string thoihan;
        public string tenloaiso;
        public string laisuat;

        public DTO_LaiSuat() { }
        public DTO_LaiSuat(string maloaiso, string thoihan, string tenloaiso, string laisuat)
        {
            this.maloaiso = maloaiso;
            this.thoihan = thoihan;
            this.tenloaiso = tenloaiso;
            this.laisuat = laisuat;
        }
    }
}
