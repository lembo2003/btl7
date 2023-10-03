using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string makh;
        public string hoten;
        public string diachi;
        public string cccd;
        public string sdt;
        public string sodu;
        public DTO_KhachHang() { }

        public DTO_KhachHang(string makh, string hoten, string diachi, string cccd, string sdt, string sodu)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.diachi = diachi;
            this.cccd = cccd;
            this.sdt = sdt;
            this.sodu = sodu;
        }
    }
}
