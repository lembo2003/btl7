using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LaiSuat
    {
        public string thoihan;
        public string tenloaiso;
        public string laisuat;

        public DTO_LaiSuat() { }
        public DTO_LaiSuat( string thoihan, string tenloaiso, string laisuat)
        {
            this.thoihan = thoihan;
            this.tenloaiso = tenloaiso;
            this.laisuat = laisuat;
        }
    }
}
