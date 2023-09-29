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
    public partial class admin_edit_form : Form
    {
        private string usernameadmin;
        public admin_edit_form(string usernameadmin)
        {
            InitializeComponent();
            this .usernameadmin = usernameadmin;
        }

        private void admin_edit_form_Load(object sender, EventArgs e)
        {
            DTO_admincontrol AC = BUS_admincontrol.GetUserInformationAdminC(usernameadmin);
            nametb.Text = AC.hoten;
            adrtb.Text = AC.diachi;
            emailtb.Text = AC.email;
            sdttb.Text = AC.sdt;
            usertb.Text = AC.username;
            passtb.Text = AC.password;
            typetb.Text = AC.type;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
