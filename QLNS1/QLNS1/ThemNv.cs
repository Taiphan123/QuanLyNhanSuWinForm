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
    public partial class ThemNv : Form
    {
        public ThemNv()
        {
            InitializeComponent();
        }

        public String lg;
        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        NhanVien_BUS nvb = new NhanVien_BUS();
        PhongBan_BUS pbb = new PhongBan_BUS();
        ChucVu_BUS cvb = new ChucVu_BUS();

        public void Load1(object sender, EventArgs e)
        {
           label11.Text = lg;
           PhongBan_Load(sender, e);
           ChucVu_Load(sender, e);
        }

        public void PhongBan_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = pbb.getMaPhongBan();
            comboBox1.DisplayMember = "Ma_pb";
          //  comboBox1.ValueMember = "Ten_pb";
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
            if (tbmanv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (textBox1.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0) MessageBox.Show("Thêm thất bại !");
            else nvb.insertNV(tbmanv.Text, textBox1.Text, tbmatkhau.Text, cbbGioiTinh.Text, dateTimePicker1.Value.ToString("yyyy/MM/dd"), textBox2.Text, textBox3.Text, textBox4.Text, comboBox2.Text.ToString().Replace(" ", ""), comboBox1.Text.ToString().Replace(" ", ""), luongnv,path);
            
            // dong form củ mở form mới
            this.Hide();
            Hoso HS = new Hoso();
            HS.lg = label11.Text;
            HS.ShowDialog();
           
            this.Close();
        }

        private void tbmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoso HS = new Hoso();
            HS.lg = label11.Text;
            HS.ShowDialog();
            this.Close();

        }
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

        
    }
}
