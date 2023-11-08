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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bntcalcular_Click(object sender, EventArgs e)
        {
            double celsius, I, F, x;

            celsius = Convert.ToDouble(txtcelsius.Text);


            I = 10;

            F = (1.8 * celsius) + 32;

            do
            {
                x = F + I;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + x.ToString());
                I = I + 10;
            } while (I <= 100);


        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void txtcelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcelsius_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
