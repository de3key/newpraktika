using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void A_L_Click(object sender, EventArgs e)
        {

        }

        private void CALC_B_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A_TB.Text);
            double b = Convert.ToDouble(A_TB.Text);
            double c = a + b;
            RES_TB.Text = c.ToString();
        }

        private void A_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
