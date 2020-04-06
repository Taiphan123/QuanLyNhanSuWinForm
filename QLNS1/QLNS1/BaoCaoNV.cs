using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS1.BUS;


namespace QLNS1
{
    public partial class BaoCaoNV : Form
    {
        public BaoCaoNV()
        {
            InitializeComponent();
        }
       String a, b, c, d;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbDx_Click(object sender, EventArgs e)
        {

        }

      

        NhanVien_BUS nvb = new NhanVien_BUS();
        public void Load1(object sender, EventArgs e)
      
        {

            a = nvb.trinhDo("Đại Học").Rows[0][0].ToString();
            b = nvb.trinhDo("Trung Cấp Nghề").Rows[0][0].ToString();
            c = nvb.trinhDo("THPT").Rows[0][0].ToString();
            d = nvb.trinhDo("").Rows[0][0].ToString();
            int a1 = (int.Parse(a));
            int b1 = (int.Parse(b));
            int c1 = (int.Parse(c));
            int d1 = (int.Parse(d));

            //int.Parse(a)
            this.chart1.Series["Char1"].Points.Add(a1);
           // this.chart1.Series["Char1"].Points[0].LegendText = "Đại Học";
            this.chart1.Series["Char1"].Points[0].Label = ""+a1+"0%";
            this.chart1.Series["Char1"].Points[0].Color = Color.Green;
            this.chart1.Series["Char1"].Points[0].AxisLabel = "Đại học";

            this.chart1.Series["Char1"].Points.Add(b1);
           // this.chart1.Series["Char1"].Points[1].LegendText = "THPT";
            this.chart1.Series["Char1"].Points[1].Label = "" + b1 + "0%";
            this.chart1.Series["Char1"].Points[1].Color = Color.Green;
            this.chart1.Series["Char1"].Points[1].AxisLabel = "THPT";

            this.chart1.Series["Char1"].Points.Add(c1);
         //   this.chart1.Series["Char1"].Points[2].LegendText = "Trung Cấp Nghề";
            this.chart1.Series["Char1"].Points[2].Label = "" + c1 + "0%";
            this.chart1.Series["Char1"].Points[2].Color = Color.Green;
            this.chart1.Series["Char1"].Points[2].AxisLabel = "Trung Cấp Nghề";

            this.chart1.Series["Char1"].Points.Add(d1);
          //  this.chart1.Series["Char1"].Points[3].LegendText = "Không Có";
            this.chart1.Series["Char1"].Points[3].Label = "" + d1 + "0%";
            this.chart1.Series["Char1"].Points[3].Color = Color.Green;
            this.chart1.Series["Char1"].Points[3].AxisLabel = "Không Có";

        }

        
    }
}
