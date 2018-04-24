using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void frmMaiorValorDeTres_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valorA = System.Convert.ToDouble(vla_txtbox.Text);
            double valorB = System.Convert.ToDouble(vlb_txtbox.Text);
            double valorC = System.Convert.ToDouble(vlc_txtbox.Text);

            if (valorA == valorB && valorA == valorC)
                maiorvalor_lbl.Text = "Os três valores são iguais";
            else if (valorA == valorB)
                maiorvalor_lbl.Text = "O maior valor é A e B";
            else if (valorA == valorC)
                maiorvalor_lbl.Text = "O maior valor é A e C";
            else if (valorB == valorC)
                maiorvalor_lbl.Text = "O maior valor é B e C";
            else if (valorA > valorB && valorA > valorC)
                maiorvalor_lbl.Text = "O maior valor é A";
            else if (valorB > valorA && valorB > valorC)
                maiorvalor_lbl.Text = "O maior valor é B";
            else if (valorC > valorB && valorC > valorA)
                maiorvalor_lbl.Text = "O maior valor é C";

            vla_txtbox.Text = null;
            vlb_txtbox.Text = null;
            vlc_txtbox.Text = null;


        }
    }
}
