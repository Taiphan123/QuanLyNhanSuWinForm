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
    public partial class XoaNV : Form
    {
        public XoaNV()
        {
            InitializeComponent();
        }
        public String a=null,lg;
        NhanVien_BUS nvb = new NhanVien_BUS();

        public void Load1(object sender, EventArgs e)
        {
            label2.Text = lg;
            try
            {
                textBox1.Text = a.ToString().Replace(" ", "");
            }
            catch
            {
                MessageBox.Show("Chọn Người Dùng Cần Xóa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="ADMIN")
            {
                MessageBox.Show("Không thể Xóa ADMIN");
                this.Hide();
         
                Hoso HS = new Hoso();
                HS.lg = label2.Text;
                HS.ShowDialog();
     
                this.Close();
            }
            else
            {
                nvb.deleteNV(textBox1.Text);
                this.Hide();
                Hoso HS = new Hoso();
                HS.lg = label2.Text;
                HS.ShowDialog();
                this.Close();
            }
                

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoso HS = new Hoso();
            HS.lg = label2.Text;
            HS.ShowDialog();
            this.Close();
        }
    }
}
