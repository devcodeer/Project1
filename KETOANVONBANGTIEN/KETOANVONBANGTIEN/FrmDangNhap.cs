using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = NGUOI_DUNG_BUS.KiemTraDangNhap(txtTenTk.Text, txtMatKhau.Text);
            if (dt.Rows.Count > 0)
            {            
            MainForm frm = new MainForm();
            this.Hide();
            frm.nguoidunghientai = txtTenTk.Text;
            frm.matkhauhientai = txtMatKhau.Text;
            frm.quyenhientai =int.Parse(dt.Rows[0]["Quyen"].ToString());
            frm.ShowDialog();
            this.Close();
            }
            else MessageBox.Show("Đăng nhập không thành công !");
        }

    
    }
}
