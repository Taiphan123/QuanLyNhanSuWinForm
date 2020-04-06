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
    public partial class LuongThuong : Form
    {
        public LuongThuong()
        {
            InitializeComponent();
        }
        Thuong_BUS thb = new Thuong_BUS();
        private void LuongThuong_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = thb.getThangThuong();
            comboBox1.DisplayMember = "thang";
            dataGridView1.DataSource = thb.getThuong();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String a = comboBox1.Text.ToString();
            try
            {
                int b = (int.Parse(a));
                dataGridView1.DataSource = thb.getThangSelect(b);
            }
            catch { }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thb.getThuong();
        }
    }
}
