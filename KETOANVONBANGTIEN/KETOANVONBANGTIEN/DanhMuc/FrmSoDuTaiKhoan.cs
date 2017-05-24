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
    public partial class FrmSoDuTaiKhoan : Form
    {
        public FrmSoDuTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDuLieu();
            
        }

        private void FrmSoDuTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            
        }
        private void LoadDuLieu()
        {
            grvDanhMucTaiKhoan.DataSource = TaiKhoan_BUS.loadListTaiKhoanKeToan();
        }

        private void grvDanhMucTaiKhoan_Click(object sender, EventArgs e)
        {
           
           
            try
            {
                txtMaTk.Text = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colMaTk).ToString();
                txtDuNo.Text = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colDuNo).ToString();
                txtDuCo.Text = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colDuCo).ToString();
                txtDuNoNt.Text = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colSoDuNoNt).ToString();
                txtDuCoNt.Text = gridViewDMTK.GetRowCellValue(gridViewDMTK.FocusedRowHandle, colSoDuCoNt).ToString();
            }
            catch
            { }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = TaiKhoan_BUS.kiemTraLaTaiKhoanTongHop(txtMaTk.Text);
            if (dt.Rows.Count == 0)
            {


                try
                {
                    string matk = txtMaTk.Text;
                    decimal duno = decimal.Parse(txtDuNo.Text.ToString());
                    decimal duco = decimal.Parse(txtDuCo.Text.ToString());
                    decimal dunont = decimal.Parse(txtDuNoNt.Text.ToString());
                    decimal ducont = decimal.Parse(txtDuCoNt.Text.ToString());
                    TaiKhoan_BUS.capNhatSoDuTaiKhoan(matk, dunont, ducont, duno, duco);
                    MessageBox.Show("Cập nhật thành công !");
                    LoadDuLieu();

                }
                catch
                {
                    MessageBox.Show("Cập nhật không thành công !");
                }
            }
            else
            {
                MessageBox.Show("Không cập nhật số dư cho tài khoản tổng hợp !");
            }
        }

        private void btnXuatEx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDMTK.ShowPrintPreview();
        }
    }
}
