using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Looping___Eduardo_Borges_e_Eric
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void bntcalcular_Click(object sender, EventArgs e)
        {
            double celsius, I, F, x;

            celsius = Convert.ToDouble(txtcelsius.Text);


            I = 10;

            F = (1.8 * celsius) + 32;

            for (I = 10; I <= 100;)
            {
                x = F + I;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + x.ToString());
                I = I + 10;
            } 
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtresultado.Clear();
        }
    }
}
