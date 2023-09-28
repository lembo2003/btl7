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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DTO_account tk = new DTO_account(user_txt.Text, pw_txt.Text);
            bool result = BUS_account.Check_login(tk);
            if(result)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string typez = BUS_account.Check_type(tk);
                string username = user_txt.Text;
                    if(typez == "admin")
                {
                    //MessageBox.Show("Đây là tài khoản admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    admin_form admin_Form = new admin_form(username);
                    admin_Form.Show();
                    this.Hide();
                }
                else if(typez == "kh")
                {
                    //MessageBox.Show("Đây là tài khoản khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    khachhang_form khachhang = new khachhang_form(username);
                    khachhang.Show();
                    this.Hide();
                }
                    else if (typez == "ksv")
                {
                    //MessageBox.Show("Đây là tài khoản của ksv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ksv_form ksv = new ksv_form(username);
                    ksv.Show();
                    this.Hide();
                }
                    else if (typez == "gd")
                {
                    //MessageBox.Show("Đây là tài khoản của giám đốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    giamdoc_form giamdoc = new giamdoc_form(username);
                    giamdoc.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Tài khoản không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //admin_form admin_Form = new admin_form();
                //admin_Form.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to the application?", "Close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
