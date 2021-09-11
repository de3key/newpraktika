using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CULC_B_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(x1_TB.Text);
            double y1 = Convert.ToDouble(y3_TB.Text);
            double x2 = Convert.ToDouble(x2_TB.Text);
            double y2 = Convert.ToDouble(y4_TB.Text);
            double a = (y1 - y2) / (x1 - x2);
            RES_A.Text = a.ToString();

        }

        private void CULC_B_Click_1(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(x1_TB.Text);
            double y1 = Convert.ToDouble(y3_TB.Text);
            double x2 = Convert.ToDouble(x2_TB.Text);
            double y2 = Convert.ToDouble(y4_TB.Text);
            double a = (y1 - y2) / (x1 - x2);
            double b = (y1 - a * x1);
            RES_B.Text = b.ToString();
        }
    }
}
