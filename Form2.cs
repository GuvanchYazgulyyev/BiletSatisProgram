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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add ("1");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("2");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("3");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Enabled = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("4");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button5.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("5");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button6.Enabled = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("6");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button7.Enabled = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("7");
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);

            if (radioButton1.Checked == true)
            {
                listBox6.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox6.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button8.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            button1.Enabled = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form3 geri = new Form3();
            geri.Show();
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

        }
    }
}
