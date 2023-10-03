using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSanh : Form
    {
        public frmSanh()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
           
            frmQuanLyKhachHang frm=new frmQuanLyKhachHang();
            frm.Show();
            this.Hide();
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            frmQuanLyGiaoDich frm=new frmQuanLyGiaoDich();
            frm.Show();
            this.Hide();
        }

        private void btnLaiSuatQuyDinh_Click(object sender, EventArgs e)
        {
            frmLaiSuatQuyDinh frm=new frmLaiSuatQuyDinh();
            frm.Show();
            this.Hide();
        }

        private void frmSanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
