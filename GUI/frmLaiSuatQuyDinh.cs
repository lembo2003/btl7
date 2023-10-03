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
    public partial class frmLaiSuatQuyDinh : Form
    {
        public frmLaiSuatQuyDinh()
        {
            InitializeComponent();
        }

        private void btnSanh_Click(object sender, EventArgs e)
        {
            frmSanh frm = new frmSanh();
            frm.Show();
            this.Hide();
        }

        private void btnThemLaiSuat_Click(object sender, EventArgs e)
        {
            DTO_LaiSuat ob = new DTO_LaiSuat(txtMaloaiso.Text, txtThoihan.Text, txtLoaiso.Text,txtLaisuat.Text);
            LS.LS_Insert_Bus(ob);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaloaiso.Clear();
            txtThoihan.Clear();
            txtLoaiso.Clear();
            txtLaisuat.Clear();

            
        }
        BUS_LaiSuat LS=new BUS_LaiSuat();
        BUS_QuyDinh QD=new BUS_QuyDinh();
        private void frmLaiSuatQuyDinh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = QD.QD_Load_Bus();
            dataGridView2.DataSource = LS.LS_Load_Bus();
        }

        private void btnXoaLaiSuat_Click(object sender, EventArgs e)
        {
            DTO_LaiSuat ob = new DTO_LaiSuat(txtMaloaiso.Text, txtThoihan.Text, txtLoaiso.Text, txtLaisuat.Text);
            LS.LS_Delete_Bus(txtMaloaiso.Text);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaloaiso.Clear();
            txtThoihan.Clear();
            txtLoaiso.Clear();
            txtLaisuat.Clear();
        }

        private void btnSuaLaiSuat_Click(object sender, EventArgs e)
        {
            DTO_LaiSuat ob = new DTO_LaiSuat(txtMaloaiso.Text, txtThoihan.Text, txtLoaiso.Text, txtLaisuat.Text);
            LS.LS_Update_Bus(ob);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaloaiso.Clear();
            txtThoihan.Clear();
            txtLoaiso.Clear();
            txtLaisuat.Clear();
        }

        private void ChonDong(object sender, DataGridViewCellEventArgs e)
        {
            //In this code, we first check if dataGridView1.CurrentRow is not null before trying to access its Index property.
            //This ensures that there is a current row selected in the DataGridView
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int i = dataGridView1.CurrentRow.Index;
                    txtMaquydinh.Text = dataGridView1.Rows[i].Cells[1].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtNoidung.Text = dataGridView1.Rows[i].Cells[2].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void DanhSTT(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnThemquydinh_Click(object sender, EventArgs e)
        {
            DTO_QuyDinh ob=new DTO_QuyDinh(txtMaquydinh.Text, txtTenquydinh.Text,txtNoidung.Text);
            QD.QD_Insert_Bus(ob);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaquydinh.Clear();
            txtNoidung.Clear();
            txtTenquydinh.Clear();
        }

        private void btnSuaquydinh_Click(object sender, EventArgs e)
        {
            DTO_QuyDinh ob = new DTO_QuyDinh(txtMaquydinh.Text, txtNoidung.Text, txtTenquydinh.Text);
            QD.QD_Update_Bus(ob);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaquydinh.Clear();
            txtNoidung.Clear();
            txtTenquydinh.Clear();
        }

        private void btnXoaquydinh_Click(object sender, EventArgs e)
        {
            DTO_QuyDinh ob = new DTO_QuyDinh(txtMaquydinh.Text, txtNoidung.Text, txtTenquydinh.Text);
            QD.QD_Delete_Bus(txtMaquydinh.Text);
            frmLaiSuatQuyDinh_Load(sender, e);
            txtMaquydinh.Clear();
            txtNoidung.Clear();
            txtTenquydinh.Clear();
        }

        private void ChonDongQuyDinh(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dataGridView2.CurrentRow != null)
                {
                    int i = e.RowIndex;
                    txtNoidung.Text = dataGridView1.Rows[i].Cells[1].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtTenquydinh.Text = dataGridView1.Rows[i].Cells[2].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[2].Value.ToString();
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }


        }

        private void DanhSTTQuyDinh(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void frmLaiSuatQuyDinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
