using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_Satma_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Proje"&& textBox2.Text == "123")
            {
                Form3 seyehat = new Form3();
                seyehat.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Giriş Hatalı Lütfen Tekrar Deneyiniz:");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
