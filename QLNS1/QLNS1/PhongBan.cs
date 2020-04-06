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
    public partial class PhongBan : Form
    {
        public PhongBan()
        {
            InitializeComponent();
        }

        public String lg;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPB thempb = new ThemPB();
            thempb.lg = label3.Text;
            thempb.ShowDialog();
            this.Close();
        }

        private void manv_Click(object sender, EventArgs e)
        {

        }

        private void tbmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void tbmanv_TextChanged(object sender, EventArgs e)
        {

        }
        PhongBan_BUS pbb = new PhongBan_BUS();
        private void PhongBan_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = pbb.getPhongBan();
            label3.Text = lg;
            if (label3.Text.Equals("ADMIN"))
            {
         
                button3.Visible = true;
                button2.Visible = true;
                tbS.Visible = true;
                btnS.Visible = true;
            }
            else
            {
                //  this.btnHs.Location = new System.Drawing.Point(32, 120); 18, 149 8, 45

                
               
                button3.Visible = false;
                button2.Visible = false;
                tsbBc.Visible = false;
            }

        }

        String a, b;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChinhSuaPB suapb = new ChinhSuaPB();
            suapb.lg = label3.Text;
            suapb.a = maa;
            suapb.b = mab;
            suapb.ShowDialog();
            this.Close();
        }
        private String maa, mab;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

            //  String mapb, mada; 
            int row = e.RowIndex;
            if (row >= 0)
            {
                a = dataGridView1.Rows[row].Cells[0].Value.ToString();
                b = dataGridView1.Rows[row].Cells[1].Value.ToString();   
            }
            maa = a;
            mab = b;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLNS QLNS = new QLNS();
            QLNS.lg = label3.Text;
            QLNS.ShowDialog();
            this.Close();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbb.Search(tbS.Text);
        }
    }
}
