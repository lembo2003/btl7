using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameadmin == "")
            {
                if (usertb.Text == "" || passtb.Text ==""|| typetb.Text=="" || nametb.Text == "" ||adrtb.Text == "" ||emailtb.Text == "" ||sdttb.Text == "")
                {
                    MessageBox.Show("Có ô bị trống!", "Thông báo!", MessageBoxButtons.OK);
                }
                else{
                    BUS_admincontrol admin = new BUS_admincontrol();
                    DTO_admincontrol ob = new DTO_admincontrol(usertb.Text, passtb.Text, typetb.Text, nametb.Text, adrtb.Text, emailtb.Text, sdttb.Text);
                    admin.Insert_AdminControl(ob);
                    MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                usertb.ReadOnly = true;
                BUS_admincontrol admin = new BUS_admincontrol();
                DTO_admincontrol ob = new DTO_admincontrol(usertb.Text, passtb.Text, typetb.Text, nametb.Text, adrtb.Text, emailtb.Text, sdttb.Text);
                admin.Update_AdminControl(ob);
                MessageBox.Show("Đã cập nhật!", "Thông báo!", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
