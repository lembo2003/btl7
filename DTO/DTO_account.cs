using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_account
    {
        public string tk;
        public string mk;
        public string type;
        public DTO_account() { }
        public DTO_account(string tk, string mk)
        {
            this.tk = tk;
            this.mk = mk;
        }
    }
}
