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
    public partial class BaoCao1 : Form
    {
        public BaoCao1()
        {
            InitializeComponent();

        }

        NhanVien_BUS nvb = new NhanVien_BUS();

        private void bieuDoCot()
        {
            int demCot = nvb.luong().Rows.Count;
            for (int i = 0; i < demCot; i++)
            {
                String a = nvb.luong().Rows[i][0].ToString();
                String b = nvb.luong().Rows[i][1].ToString();
                int c = (int.Parse(b));
                this.chart1.Series["Seriesa"].Points.Add(c);
                this.chart1.Series["Seriesa"].Points[i].Label = c + "";
                this.chart1.Series["Seriesa"].Points[i].Color = Color.Blue;
                this.chart1.Series["Seriesa"].Points[i].AxisLabel = a;
            }
        }

        BanChamCong_BUS bccb = new BanChamCong_BUS();

        private void duong()
        {
            String c = bccb.thangMaxBieuDo().Rows[0][0].ToString();
            int c1 =  (int.Parse(c));
            for (int i = 0; i <=c1; i++)
            {
                String a = bccb.bccBieuDo(i).Rows[0][0].ToString();
                int b =0;
                try
                {
                    b = (int.Parse(a));
                }
                catch { }
                 
                this.chart4.Series["Series4"].Points.Add(b);
                this.chart4.Series["Series4"].Points[i].Label = b + "";
                this.chart4.Series["Series4"].Points[i].Color = Color.Blue;
                this.chart4.Series["Series4"].Points[i].AxisLabel = (i+1)+"";    
                
            }
            
        }


        private int tinhPhanTram()
        {
            int tong = 0;
            int demCot = tbus.thuong().Rows.Count;
            for (int i = 0; i < demCot; i++)
            {
                String b = tbus.thuong().Rows[i][1].ToString();
                int c = (int.Parse(b));
                tong += c;
            }

            return tong;

          }
        
        Thuong_BUS tbus = new Thuong_BUS();
        private void bieuDoTron()
        {


            Color[] cl = { Color.Blue, Color.Red, Color.Orange, Color.DarkMagenta, Color.BurlyWood, Color.Orange };
            

            int demCot = tbus.thuong().Rows.Count;
            int tong = tinhPhanTram();
            for (int i = 0; i < demCot; i++)
            {
                
                String a = tbus.thuong().Rows[i][0].ToString();
                String b = tbus.thuong().Rows[i][1].ToString();
                int c = (int.Parse(b));
                this.chart3.Series["Series3"].Points.Add(c);
                this.chart3.Series["Series3"].Points[i].Label = (c*100)/tong + "%" +a;
                try
                {
                    this.chart3.Series["Series3"].Points[i].Color = cl[i];
                }
                catch { }
                this.chart3.Series["Series3"].Points[i].AxisLabel = a;
            }
        }



        private void BaoCao1_Load(object sender, EventArgs e)
        {
            bieuDoCot();
            bieuDoTron();
            duong();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
