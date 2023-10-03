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

namespace GUI
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnSanh_Click(object sender, EventArgs e)
        {
            frmSanh frm=new frmSanh();
            frm.Show();
            this.Hide();
        }

        private void ChonDong(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int i = e.RowIndex;
                    txtMakh.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtHoten.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    txtDiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    txtCccd.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    txtSdt.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    txtSodu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                txtMakh.Text = "";
                txtHoten.Text = "";
                txtDiachi.Text = "";
                txtSdt.Text = "";
                txtCccd.Text = "";
                txtSodu.Text = "";
            }
        }
        BUS_KhachHang KH = new BUS_KhachHang();
        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = KH.KH_Load_Bus();
        }

        private void DanhSTT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            DTO_KhachHang ob=new DTO_KhachHang(txtMakh.Text,txtHoten.Text,txtDiachi.Text,txtCccd.Text,txtSdt.Text,txtSodu.Text);
            KH.KH_Insert_Bus(ob);
            frmQuanLyKhachHang_Load(sender, e);
            txtMakh.Clear();
            txtHoten.Clear();
            txtDiachi.Clear();
            txtCccd.Clear();
            txtSdt.Clear();
            txtSodu.Clear();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            DTO_KhachHang ob = new DTO_KhachHang(txtMakh.Text, txtHoten.Text, txtDiachi.Text, txtCccd.Text, txtSdt.Text, txtSodu.Text);
            KH.KH_Update_Bus(ob);
            frmQuanLyKhachHang_Load(sender, e);
            txtMakh.Clear();
            txtHoten.Clear();
            txtDiachi.Clear();
            txtCccd.Clear();
            txtSdt.Clear();
            txtSodu.Clear();
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            DTO_KhachHang ob = new DTO_KhachHang(txtMakh.Text, txtHoten.Text, txtDiachi.Text, txtCccd.Text, txtSdt.Text, txtSodu.Text);
            KH.KD_Delete_Bus(txtMakh.Text);
            frmQuanLyKhachHang_Load(sender, e);
            txtMakh.Clear();
            txtHoten.Clear();
            txtDiachi.Clear();
            txtCccd.Clear();
            txtSdt.Clear();
            txtSodu.Clear();
        }

        private void frmQuanLyKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
