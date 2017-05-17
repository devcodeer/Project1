using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using  BUS;

namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmTinhTyGiaXuatNT : Form
    {
        public FrmTinhTyGiaXuatNT()
        {
            InitializeComponent();
        }

      

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            //int thang = int.Parse(comboBoxThang.SelectedValue.ToString());
            //int nam = int.Parse(numericUpDownNam.Value.ToString());
            //gridControlBangTinhTyGia.DataSource = TinhTyGiaXuatNt_BUS.TinhTyGiaXuatNtBq(thang, nam);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadThang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Thang");
            for (int i = 0; i < 12; i++)
            {
                dt.Rows.Add((i + 1).ToString());
            }
            comboBoxThang.DataSource = dt;
            comboBoxThang.DisplayMember = "Thang";
            comboBoxThang.ValueMember = "Thang";

        }

        private void FrmTinhTyGiaXuatNT_Load(object sender, EventArgs e)
        {
            LoadThang();
            comboBoxThang.Text = DateTime.Today.Month.ToString();
            numericUpDownNam.Maximum = 2500;
            numericUpDownNam.Minimum = 0;
            numericUpDownNam.Value = DateTime.Today.Year;
            
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            ChungTu.FrmXuLyChenhLechNT frm = new ChungTu.FrmXuLyChenhLechNT();
            frm.Show();
        }


    }
}
