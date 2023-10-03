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
    public partial class frmQuanLyGiaoDich : Form
    {
        public frmQuanLyGiaoDich()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        BUS_QuyDinh qd = new BUS_QuyDinh();
        BUS_KhachHang KH = new BUS_KhachHang();
        BUS_GiaoDich GD = new BUS_GiaoDich();
        BUS_LaiSuat ls = new BUS_LaiSuat();
        private int time = 0;
        private void frmQuanLyGiaoDich_Load(object sender, EventArgs e)
        {
            cbMaloaiso.DataSource = ls.Get_TenLoaiSo();
            cbMaquydinh.DataSource = qd.Load_GetTenQuyDinh();
            cbMkh.DataSource = KH.Load_makhachhang();
            //chon thoi gian theo loai so
            cbMaloaiso.SelectedIndexChanged += cbMaloaiso_SelectedIndexChanged;
            dataGridView1.DataSource = GD.Load_BUS();
        }

        private void btnSanh_Click(object sender, EventArgs e)
        {
            frmSanh frm = new frmSanh();
            frm.Show();
            this.Hide();
        }

        private void frmQuanLyGiaoDich_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbMaloaiso_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Assuming that the selected value is an integer
            if (cbMaloaiso.SelectedValue != null)
            {
                time = Convert.ToInt32(cbMaloaiso.SelectedValue);
                dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(time);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void danhstt(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                float sotiengui;
                if (!float.TryParse(txtSotiengui.Text, out sotiengui))
                {
                    MessageBox.Show("Invalid deposit amount.");
                    return;
                }

                bool dieukientien = GD.KtraTien(cbMkh.Text,sotiengui);
                if (dieukientien)
                {
                    DTO_GiaoDich ob = new DTO_GiaoDich(TxtMaso.Text, cbMkh.Text, txtSotiengui.Text, cbMaloaiso.Text, dateTimePicker1.Text, dateTimePicker2.Text, cbMaquydinh.Text);
                    GD.Insert_Giaodich(ob);
                    TxtMaso.Clear();
                    txtSotiengui.Clear();
                    MessageBox.Show("Thêm sổ thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Số dư không khả dụng!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmQuanLyGiaoDich_Load(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ ex.Message);
            }
        }
      
        private string maso;
        private float sotiengui;
        private int thoihan;
        private string makh;
        private void btnTatToan_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dataGridView1.CurrentRow != null)
                //{
                // Get the current row
                // DataGridViewRow currentRow = dataGridView1.CurrentRow;

                // Get makh, sotiengui, and thoihan from the current row
                //string makh = currentRow.Cells["makh"].Value.ToString();
                // float sotiengui = float.Parse(currentRow.Cells["sotiengui"].Value.ToString());
                // int thoihan = int.Parse(currentRow.Cells["maloaiso"].Value.ToString());
                //testtxt.Text = currentRow.Cells["makh"].Value.ToString();
                // Thuc hien TAT     
                GD.TatToan(maso, makh,sotiengui, thoihan);
                frmQuanLyGiaoDich_Load(null, null);
                MessageBox.Show("Đã tất toán!", "Thông báo", MessageBoxButtons.OK);
                //}
                //else
               // {
                 //   MessageBox.Show("No row selected. Please select a row.");
               // }
            }
            catch( Exception ex )
             { 
              MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int i = dataGridView1.CurrentRow.Index;
                    maso = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    makh = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    testtxt.Text = dataGridView1.Rows[i].Cells[1].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[1].Value.ToString();
                    //get so tien gui and convert it to float
                    sotiengui = float.Parse(dataGridView1.Rows[i].Cells[3].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[3].Value.ToString());

                    //get thoi han and convert it to int
                    thoihan = int.Parse(dataGridView1.Rows[i].Cells[4].Value == null ? string.Empty : dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
