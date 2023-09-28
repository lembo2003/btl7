using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_info 
    {
        public string username;
        public string hoten;
        public string diachi;
        public string email;
        public string sdt;
        public DTO_info() { }
        public DTO_info(string hoten, string diachi, string email, string sdt, string username)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
            this.username = username;
        }
    }
}
