using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void knopka_1_Click(object sender, EventArgs e)
        {

        }

        private void label3_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void knopka_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(L_TB.Text);
            double a = Convert.ToDouble(A_TB.Text);
            double b = Convert.ToDouble(B_TB.Text);
            double r = b / 2;
            double r1 = a / 2;
            double v1 = a * b * l;
            double v2 = (2 * Math.PI * r) * l;
            double c = v1 - v2;
            RES_TB.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
