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
    public partial class Form8 : Form
    {

        public Form8()
        {
            InitializeComponent();
        }
        double areatotal;

        private void bntcalcular_Click(object sender, EventArgs e)
        {
            double larg, comp, area, nome;

            larg = Convert.ToDouble(txtlargura.Text);
            comp = Convert.ToDouble(txtcomprimento.Text);
            

            area = larg * comp;
            areatotal += area;
            txtarea.Text = area.ToString();

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtarea.Clear();
                txtlargura.Clear();
                txtcomprimento.Clear();
                txtnome.Clear();
            }
            else
            {
                lblareatotal.Visible = true;
                txtareatotal.Visible = true;
                txtareatotal.Text = areatotal.ToString();
            }
        }

        private void txtcelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlargura.Clear();
            txtcomprimento.Clear();
            txtnome.Clear();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
