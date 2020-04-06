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
    public partial class ThemPB : Form
    {
        public ThemPB()
        {
            InitializeComponent();
        }

        PhongBan_BUS pbb = new PhongBan_BUS();
        public String lg;

        private void button2_Click(object sender, EventArgs e)
        {

            if (tbmanv.Text.Trim() == "")
                MessageBox.Show("Mã Phòng Ban Không được để trống !");
            else if (tbmatkhau.Text.Trim() == "")
                MessageBox.Show("Tên Phòng Ban không được để trống !");
            else pbb.insertPhongBan(tbmanv.Text, tbmatkhau.Text);

            // dong form củ mở form mới
            this.Hide();
            PhongBan pbf = new PhongBan();
            pbf.lg = label11.Text;
            pbf.ShowDialog();
            this.Close();
        }

        private void ThemPB_Load(object sender, EventArgs e)
        {
            label11.Text = lg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhongBan pbf = new PhongBan();
            pbf.lg = label11.Text;
            pbf.ShowDialog();
            this.Close();
        }
    }
}
