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
    public partial class giamdoc_form : Form
    {
        public giamdoc_form()
        {
            InitializeComponent();
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
    }
}
