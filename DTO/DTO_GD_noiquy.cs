using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GD_noiquy
    {
        string username;
        string tennd;
        string noidung;
        string tinhtrang;
        public DTO_GD_noiquy() { }
        public DTO_GD_noiquy(string username, string tennd, string noidung, string tinhtrang)
        {
            this.username = username;
            this.tennd = tennd;
            this.noidung = noidung;
            this.tinhtrang = tinhtrang;
        }
    }
}
