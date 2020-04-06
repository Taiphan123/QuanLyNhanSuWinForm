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
    public partial class ChinhSuaPB : Form
    {
        public ChinhSuaPB()
        {
            InitializeComponent();
        }

        PhongBan_BUS pbb = new PhongBan_BUS();
        public String lg,a,b;

        private void button2_Click(object sender, EventArgs e)
        {


            if (label1.Text.Trim() == "")
                MessageBox.Show("Không thể thêm qua form này !");
            else if (tbmatkhau.Text.Trim() == "")
                MessageBox.Show("Tên Phòng Ban không được để trống !");
            else pbb.updatePhongBan(label1.Text, tbmatkhau.Text);

            // dong form củ mở form mới
            this.Hide();
            PhongBan pbf = new PhongBan();
            pbf.lg = label11.Text;
            pbf.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhongBan pbf = new PhongBan();
            pbf.lg = label11.Text;
            pbf.ShowDialog();
            this.Close();
        }

 

        private void ChinhSuaPB_Load(object sender, EventArgs e)
        {
            label1.Text = a;
            tbmatkhau.Text = b;
            label11.Text = lg;
        }
    }
}
