using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTk.Text = tentk;            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMatKhau.Text != matkhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng !");
            }
            else
            {
                try
                {
                    NguoiDung_BUS.updatePassword(tentk, txtMatKhauMoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                catch
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!");
                }
            }
        }
        public string tentk;
        public string matkhau;
        
    }
}
