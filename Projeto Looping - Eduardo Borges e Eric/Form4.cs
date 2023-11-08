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
    public partial class Form4 : Form
    {
        public Form4()
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
            double num1, I, result;

            num1 = Convert.ToDouble(txtnum1.Text);
            I = 1;
            for (I = 1; I <= 10;) 
            {
                result = num1 * I;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + result.ToString());
                I++;
            }  
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtresultado.Clear();
        }
    }
}
