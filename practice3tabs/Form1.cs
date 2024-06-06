using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3tabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                double r = Convert.ToDouble(textBox1.Text);
                switch (tabControl1.SelectedIndex)
                {
                    case 1:
                        double s = Math.PI * r * r;
                        s = Math.Round(s, 3);
                        textBox2.Text = s.ToString();
                        break;
                    case 2:
                        double l = Math.PI * r * 2;
                        l = Math.Round(l, 3);
                        textBox3.Text = l.ToString();
                        break;
                    case 3:
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        break;
                }
            }
            else
                if (tabControl1.SelectedIndex == 1 ||
                tabControl1.SelectedIndex == 2)
                MessageBox.Show("Введіть радіус!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
