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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 bilet = new Form2();
            bilet.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://canlitv.com/trt-haber";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/turkiye.aspx");
        }
    }
}
