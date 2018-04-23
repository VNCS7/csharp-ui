using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(nm1_txtbox.Text);
            double n2 = System.Convert.ToDouble(nm2_txtbox.Text);
            double resultado = n1 - n2;

            resultado_txtbox.Text = resultado.ToString();

            nm1_txtbox.Text = null;
            nm2_txtbox.Text = null;
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(nm1_txtbox.Text);
            double n2 = System.Convert.ToDouble(nm2_txtbox.Text);
            double resultado = n1 * n2;

            resultado_txtbox.Text = resultado.ToString();

            nm1_txtbox.Text = null;
            nm2_txtbox.Text = null;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(nm1_txtbox.Text);
            double n2 = System.Convert.ToDouble(nm2_txtbox.Text);
            double resultado = n1 + n2;

            resultado_txtbox.Text = resultado.ToString();

            nm1_txtbox.Text = null;
            nm2_txtbox.Text = null;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(nm1_txtbox.Text);
            double n2 = System.Convert.ToDouble(nm2_txtbox.Text);
            double resultado = n1 / n2;

            resultado_txtbox.Text = resultado.ToString();

            nm1_txtbox.Text = null;
            nm2_txtbox.Text = null;
        }

        private void credits_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
