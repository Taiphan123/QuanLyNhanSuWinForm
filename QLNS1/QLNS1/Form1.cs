using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS1
{
    public partial class QLNS : Form
    {
        public QLNS()
        {
            InitializeComponent();
        }

        public String lg ;

        private void btnHs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoso hs = new Hoso();
            hs.lg = label2.Text;
            hs.ShowDialog(); 
            this.Close();
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            new ChamCong().ShowDialog();
        }

        private void btnCv_Click(object sender, EventArgs e)
        {
            new ChucVu().ShowDialog();
        }

        private void btnPb_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhongBan pb = new PhongBan();
            pb.lg = label2.Text;
            pb.ShowDialog();
            this.Close();
        }

        private void btnLt_Click(object sender, EventArgs e)
        {
            new LuongThuong().ShowDialog();
        }

        private void QLNS_Load(object sender, EventArgs e)
        {
            label2.Text = lg;
            if (label2.Text.Equals("ADMIN"))
            {
                btnCc.Visible = true;
                btnCv.Visible = true;
                btnBc.Visible = true;
            }
            else
            {
                this.btnHs.Location = new System.Drawing.Point(32, 120);
                this.btnPb.Location = new System.Drawing.Point(282, 120);
                this.btnLt.Location = new System.Drawing.Point(531, 120);
                btnCc.Visible = false;
                btnCv.Visible = false;
                btnBc.Visible = false;
            }
        }

        private void tsbDx_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBc_Click(object sender, EventArgs e)
        {
            
            new BaoCao1().ShowDialog();
            
        }
    }
}
