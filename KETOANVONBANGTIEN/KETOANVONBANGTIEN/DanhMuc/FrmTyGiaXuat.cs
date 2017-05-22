using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmTyGiaXuat : Form
    {
        public FrmTyGiaXuat()
        {
            InitializeComponent();
            LoadLookUpEditTienTe();

        }

        private void LoadLookUpEditTienTe()
        {
            lookUpEditLoaiTien.Properties.DataSource = BUS.TienTe_BUS.loadDanhMucTienTe();
            lookUpEditLoaiTien.Properties.DisplayMember = "MaTien";
            lookUpEditLoaiTien.Properties.ValueMember = "MaTien";

            lookUpEditLoaiTien.EditValue = "VND";
        }

        private void FrmTyGiaXuat_Load(object sender, EventArgs e)
        {

        }
    }
}
