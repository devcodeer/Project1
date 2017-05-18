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
            if (txtTenTk.Text.Equals("") || txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống username hoặc password!");
            }
            else
            {
                DataTable dt = NguoiDung_BUS.doLogin(txtTenTk.Text, txtMatKhau.Text);

                if (dt.Rows.Count > 0)
                {
                    MainForm frmMain = new MainForm();
                    this.Hide();
                    frmMain.nguoidunghientai = txtTenTk.Text;
                    frmMain.matkhauhientai = txtMatKhau.Text;
                    frmMain.quyenhientai = int.Parse(dt.Rows[0]["Quyen"].ToString());
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai username hoặc password!");
            }
        }

    
    }
}
