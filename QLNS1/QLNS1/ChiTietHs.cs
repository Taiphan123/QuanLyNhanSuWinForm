using QLNS1.Properties;
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
    public partial class ChiTietHs : Form
    {
        public ChiTietHs()
        {
            InitializeComponent();
        }
        public String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12,lg;

        private void button3_Click(object sender, EventArgs e)
        {

            if (label11.Text == "")
            {
                MessageBox.Show("Không thể chỉnh sửa nhân viên này");
            }
            else
            {
                this.Hide();
                SuaNv Child = new SuaNv();
                Child.a1 = a1;
                Child.a2 = a2;
                Child.a3 = a3;
                Child.a4 = a4;
                Child.a5 = a5;
                Child.a6 = a6;
                Child.a7 = a7;
                Child.a8 = a8;
                Child.a9 = a9;
                Child.a10 = a10;
                Child.a11 = a11;
                Child.a12 = a12;
                Child.lg = label30.Text;

                Child.ShowDialog();
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoso HS = new Hoso();
            HS.lg = label30.Text;
            HS.ShowDialog();
            this.Close();
        }

        private void ChiTietHs_Load(object sender, EventArgs e)
        {
           

            label30.Text = lg;
            label11.Text = a1;
            if (label30.Text.Equals(label11.Text.Replace(" ", "")) ||label30.Text.Equals("ADMIN"))
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
            
            label12.Text = a3;
            label13.Text = a2;
            label14.Text = a4;
            label15.Text = a5;
            label16.Text = a6;
            label17.Text = a7;
            label18.Text = a8;
            label19.Text = a9;
            label20.Text = a11;
            label21.Text = a10;

            try
            {
                if (a12 != "")
                {
                    pictureBox1.Image = Image.FromFile(a12);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                else
                {
                    //pictureBox1.BackgroundImage
                    this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(Resources.GetObject("pictureBox1.BackgroundImage")));
                    this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                }
            }
            catch
            {

            }
            /////
            
                layBangChucVu(a10);
                layPhongBan(a11);
            


        }

        ChucVu_BUS cvb = new ChucVu_BUS();
        PhongBan_BUS pbb = new PhongBan_BUS();

        private void layPhongBan(String a)
        {
            try
            {
                label29.Text = pbb.getPhongBanChiTiet(a).Rows[0][1].ToString();
            }
            catch {  }
            
        }

        private void layBangChucVu( String a)
        {
            try
            {
                label26.Text = cvb.getChucVuChiTiet(a).Rows[0][1].ToString();
                label27.Text = cvb.getChucVuChiTiet(a).Rows[0][2].ToString();
                label28.Text = cvb.getChucVuChiTiet(a).Rows[0][3].ToString();
            }
            catch
            { MessageBox.Show("Chọn nhân viên trong Bảng"); }
    // b = nvb.trinhDo("Trung Cấp Nghề").Rows[0][0].ToString();
}





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
