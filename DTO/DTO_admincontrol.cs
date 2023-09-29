using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_admincontrol
    {
        public string username;
        public string password;
        public string type;
        public string hoten;
        public string diachi;
        public string email;
        public string sdt;
        public DTO_admincontrol() { }
        public DTO_admincontrol(string username, string password, string type, string hoten, string diachi, string email, string sdt)
        {
            this.username = username;
            this.password = password;
            this.type = type;
            this.hoten = hoten;
            this.diachi = diachi;
            this.email = email;
            this.sdt = sdt;
        }
    }
}
