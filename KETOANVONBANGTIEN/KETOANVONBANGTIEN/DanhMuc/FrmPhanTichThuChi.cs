using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraCharts;
namespace KETOANVONBANGTIEN.DanhMuc
{
    public partial class FrmPhanTichThuChi : Form
    {
        public FrmPhanTichThuChi()
        {
            InitializeComponent();
        }

        private void FrmPhanTichThuChi_Load(object sender, EventArgs e)
        {
            chart.DataSource = PhanTich_BUS.loadPhanTichThuChi();

            chart.SeriesDataMember = "TichChat";
            chart.SeriesTemplate.ArgumentDataMember = "Thang";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "SoTien" });
            DataTable dt = PhanTich_BUS.TinhTienTon();

            // Create a pie series.
            Series series1 = new Series("Pie Series 1", ViewType.Pie3D);
            series1.LegendPointOptions.PointView = PointView.Argument;
            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Tiền Mặt", dt.Rows[0][1]));
            series1.Points.Add(new SeriesPoint("Tiền Gửi", dt.Rows[1][1]));
           
            // Add the series to the chart.
            chart1.Series.Add(series1);
            // Adjust the value numeric options of the series.
            series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            series1.PointOptions.ValueNumericOptions.Precision = 0;

            // Adjust the view-type-specific options of the series.
            ((Pie3DSeriesView)series1.View).Depth = 30;
            ((Pie3DSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((Pie3DSeriesView)series1.View).ExplodedDistancePercentage = 30;

            // Access the diagram's options.
            ((SimpleDiagram3D)chart1.Diagram).RotationType = RotationType.UseAngles;
            ((SimpleDiagram3D)chart1.Diagram).RotationAngleX = -35;
            

                        
            digitalGauge1.Text = dt.Rows[0][1].ToString();
            digitalGauge2.Text = dt.Rows[1][1].ToString();
            digitalGauge3.Text = (Decimal.Parse(dt.Rows[0][1].ToString()) + Decimal.Parse(dt.Rows[1][1].ToString())).ToString();

           
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
