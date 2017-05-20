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
namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmEditNguoiDung : Form
    {
        private NguoiDung_DTO user;
        public FrmEditNguoiDung()
        {
            InitializeComponent();
        }

        public FrmEditNguoiDung(NguoiDung_DTO userUpdate)
        {
            this.user = userUpdate;
            InitializeComponent();
        }

        private void FrmEditNguoiDung_Load(object sender, EventArgs e)
        {
            LoadQuyen();     
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuuVaDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = NguoiDung_BUS.checkUsernameIsExist(txtTenTk.Text);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại !");
            }
            else
            {
                try
                {
                    ThemMoi();
                    MessageBox.Show("Thêm mới thành công!");
                    this.Close();

                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công!");
                }
            }
        }

        private void btnLuuVaMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ThemMoi();
                MessageBox.Show("Thêm mới thành công!");
                txtTenTk.Text = "";
                txtMatKhau.Text = "";
                LoadQuyen();

            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công!");
            }
        }

        private void ThemMoi()
        {
            string tentk = txtTenTk.Text;
            string matkhau = txtMatKhau.Text;
            int quyen = int.Parse(lookUpEditQuyen.GetColumnValue("Ma").ToString()) ;
            
            NguoiDung_DTO nd= new NguoiDung_DTO(tentk,matkhau,quyen);
            NguoiDung_BUS.insertUser(nd);
        }

        private void LoadQuyen()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma", typeof(int));
            dt.Columns.Add("Quyen", typeof(string));
            dt.Rows.Add(1, "Quản trị hệ thống");
            dt.Rows.Add(2, "Người dùng");
            lookUpEditQuyen.Properties.DataSource = dt;
            lookUpEditQuyen.Properties.DisplayMember = "Quyen";
            lookUpEditQuyen.Properties.ValueMember = "Ma";
        }
    }
}
