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

using QLNS1.Properties;

namespace QLNS1
{
    public partial class SuaNv : Form
    {

        public SuaNv()
        {
            InitializeComponent();
        }

        public String a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,lg;

        String path = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                this.path = open.FileName;
                pictureBox1.Image = Image.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa mở được file");
            }
        }

        public void Load1(object sender, EventArgs e)
        {
            label12.Text = lg;
            label11.Text =  a1;
            tbmatkhau.Text = a3;
            textBox1.Text = a2;
            comboBox3.Text = a4;
            dateTimePicker1.Text = a5;
            textBox2.Text = a6;
            textBox3.Text = a7;
            textBox4.Text = a8;
            textBox5.Text = a9;
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
            

            //load combobox
            PhongBan_Load(sender, e);
            ChucVu_Load(sender, e);
            comboBox2.Text = a10;
            comboBox1.Text = a11;
            path = a12;
        }
        NhanVien_BUS nvb = new NhanVien_BUS();
        PhongBan_BUS pbb = new PhongBan_BUS();
        ChucVu_BUS cvb = new ChucVu_BUS();

        public void PhongBan_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = pbb.getMaPhongBan();
            comboBox1.DisplayMember = "Ma_pb";
            
        }
        public void ChucVu_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = cvb.getMaChucVu();
            comboBox2.DisplayMember = "Ma_cv";
            //comboBox2.ValueMember = "Ten_CV,HesoLuong,PhuCap";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            float luongnv = 0;
            try
            {
                luongnv = float.Parse(textBox5.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0) MessageBox.Show("Thêm thất bại !");
            else nvb.updateNV(label11.Text, textBox1.Text, tbmatkhau.Text, comboBox3.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), textBox2.Text, textBox3.Text, textBox4.Text, comboBox2.Text.ToString().Replace(" ", ""), comboBox1.Text.ToString().Replace(" ", ""), luongnv,path);
            // dong form củ mở form mới
            this.Hide();
            Hoso hs = new Hoso();
            hs.lg = label12.Text;
            hs.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // dong form củ mở form mới
            this.Hide();
            Hoso hs = new Hoso();
            hs.lg = label12.Text;
            hs.ShowDialog();
            this.Close();
        }
    }
}
