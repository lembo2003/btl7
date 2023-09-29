using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL7
{
    public partial class loginchange_form : Form
    {
        private string username;
        public loginchange_form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginchange_form_Load(object sender, EventArgs e)
        {
            DTO_account account = BUS_account.GetUserInformationLogin(username);
            username_lb.Text = account.tk;
        }

        private void chang_Click(object sender, EventArgs e)
        {
            if (newpw_txt.Text == "")
            {
                MessageBox.Show("Mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BUS_account busaccount = new BUS_account();
                DTO_account ob = new DTO_account(username_lb.Text,newpw_txt.Text);
                busaccount.Update_login(ob);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo!", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
