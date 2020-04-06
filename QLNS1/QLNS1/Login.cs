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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        NhanVien_BUS nv = new NhanVien_BUS();
        private void button1_Click(object sender, EventArgs e)
        {
            String condition;
            condition = " Ma_ND ='" + textBox1.Text + "' AND MatKhau ='" + textBox2.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = nv.getCondition(condition);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !");

                    this.Hide();
                    QLNS qlns = new QLNS();
                    qlns.lg = textBox1.Text.ToUpper();
                    qlns.ShowDialog();
                    
                    this.Close();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối CSDL !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


      
    }
}
