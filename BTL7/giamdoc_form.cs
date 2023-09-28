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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL7
{
    public partial class giamdoc_form : Form
    {
        private string username;
        public giamdoc_form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn đăng xuất?", "Close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                login_form login = new login_form();
                login.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void giamdoc_form_Load(object sender, EventArgs e)
        {
            DTO_info info = BUS_info.GetUserInformation(username);
            name_txt.Text = info.hoten;
            addr_txt.Text = info.diachi;
            email_txt.Text = info.email;
            sdt_txt.Text = info.sdt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUS_info infobus = new BUS_info();
            DTO_info ob = new DTO_info(name_txt.Text, addr_txt.Text, email_txt.Text, sdt_txt.Text, username);
            infobus.Update_info(ob);
            MessageBox.Show("Thay đổi thông tin thành công", "Thông báo!", MessageBoxButtons.OK);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginchange_form change = new loginchange_form(username);
            change.Show();
        }
    }
}
