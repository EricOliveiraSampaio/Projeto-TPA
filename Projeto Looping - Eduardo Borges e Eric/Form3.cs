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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
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
            do
            {
                result = num1 * I;
                txtresultado.Text = String.Concat(txtresultado.Text + "\r\n" + result.ToString());
                I++;
            } while (I <= 10);
        
    }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtresultado.Clear();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
