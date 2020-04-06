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
    public partial class Hoso : Form
    {
        public Hoso()
        {
            InitializeComponent();
        }
        NhanVien_BUS nvb = new NhanVien_BUS();
        public String lg;

        public void Hoso_Load(object sender, EventArgs e)
        {
            label3.Text = lg;

            if (label3.Text.Equals("ADMIN"))
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                tsbBc.Visible = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                tsbBc.Visible = false;
                this.button5.Location = new System.Drawing.Point(660, 12);
            }


            dataGridView1.DataSource = nvb.getNhanvien();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ThemNv Child = new ThemNv();
            Child.lg = label3.Text;
            Child.ShowDialog();
            this.Close();


        }
        String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11,a12;

       

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHs Child = new ChiTietHs();
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
            Child.lg = lg;

            Child.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tsbBc_Click(object sender, EventArgs e)
        {
            new BaoCaoNV().ShowDialog();
        }

        private void tsbDx_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nvb.Search(tbS.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            a1 = null; a2 = null; a3 = null; a4 = null; a5 = null; a6 = null;
            a7 = null; a8 = null; a9 = null; a10 = null; a11 = null; a12=null;


            //  String mapb, mada; 
            int row = e.RowIndex;
            if (row >= 0)
            {
               a1 = dataGridView1.Rows[row].Cells[0].Value.ToString();
               a2 = dataGridView1.Rows[row].Cells[1].Value.ToString();
               a3 = dataGridView1.Rows[row].Cells[2].Value.ToString();
               a4 = dataGridView1.Rows[row].Cells[3].Value.ToString();
               a5 = dataGridView1.Rows[row].Cells[4].Value.ToString();
               a6 = dataGridView1.Rows[row].Cells[5].Value.ToString();
               a7 = dataGridView1.Rows[row].Cells[6].Value.ToString();
               a8 = dataGridView1.Rows[row].Cells[7].Value.ToString();
               a10 = dataGridView1.Rows[row].Cells[8].Value.ToString();
               a11 = dataGridView1.Rows[row].Cells[9].Value.ToString();
               a9 = dataGridView1.Rows[row].Cells[10].Value.ToString();
               a12 = dataGridView1.Rows[row].Cells[11].Value.ToString();
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            XoaNV xoa = new XoaNV();
            xoa.a = a1;
            xoa.lg = label3.Text;
            xoa.ShowDialog();
            this.Close();
            
        }
        private void button3_Click(object sender, EventArgs e)
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
            Child.lg = label3.Text;

            Child.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLNS QLNS = new QLNS();
            QLNS.lg = label3.Text;
            QLNS.ShowDialog();
            this.Close();
        }
    }
}
