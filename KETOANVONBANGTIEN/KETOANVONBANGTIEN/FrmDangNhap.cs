using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

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
            Application.Exit();
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
                    NguoiDung_DTO user = new NguoiDung_DTO();

                    this.Hide();
                    user.TenTk = txtTenTk.Text;
                    user.MatKhau = txtMatKhau.Text;
                    user.Quyen = int.Parse(dt.Rows[0]["Quyen"].ToString());
                    MainForm frmMain = new MainForm(user);
                    frmMain.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai username hoặc password!");
            }
        }

    
    }
}
