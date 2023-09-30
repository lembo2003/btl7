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
    public partial class admin_form : Form
    {
        private string username;
        public admin_form(string username)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        BUS_admincontrol admin = new BUS_admincontrol();
        private void admin_form_Load(object sender, EventArgs e)
        {
            DTO_info info = BUS_info.GetUserInformation(username);
            name_txt.Text = info.hoten;
            addr_txt.Text = info.diachi;
            email_txt.Text = info.email;
            sdt_txt.Text = info.sdt;

            dataGridView1.DataSource = admin.admin_LoadDGV();
            edit_button.Enabled = false;
            del_button.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUS_info infobus = new BUS_info();
            DTO_info ob = new DTO_info(name_txt.Text, addr_txt.Text,email_txt.Text,sdt_txt.Text,username);
            infobus.Update_info(ob);
            MessageBox.Show("Thay đổi thông tin thành công", "Thông báo!", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginchange_form change = new loginchange_form(username);
            change.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        string usernameadmin;//khai báo để đổ dữ liệu zô admin edit form
        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            usernameadmin = dataGridView1.Rows[i].Cells[1].Value.ToString();
            testlb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            edit_button.Enabled = true;
            del_button.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            usernameadmin = "";
            admin_edit_form adminform = new admin_edit_form(usernameadmin);
            adminform.FormClosed += new FormClosedEventHandler(admin_FormClosed);
            adminform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_edit_form adminform = new admin_edit_form(usernameadmin);
            adminform.FormClosed += new FormClosedEventHandler(admin_FormClosed);
            adminform.Show();
        }
        void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            admin_form_Load(null,null);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
         
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự muốn xóa?", "Cảnh Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BUS_admincontrol admin = new BUS_admincontrol();
                DTO_admincontrol ob = BUS_admincontrol.GetUserInformationAdminC(usernameadmin);
                admin.Delete_AdminControl(ob);
                admin_form_Load(null,null);
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
    }

