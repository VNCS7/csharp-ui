using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoMedia
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void md_lbl_Click(object sender, EventArgs e)
        {

        }

        private void nmaluno_lbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double nota1 = System.Convert.ToDouble(n1_txtbox.Text);
            double nota2 = System.Convert.ToDouble(n2_txtbox.Text);
            double nota3 = System.Convert.ToDouble(n3_txtbox.Text);
            double nota4 = System.Convert.ToDouble(n4_txtbox.Text);

            double md = (nota1 + nota2 + nota3 + nota4) / 4;

            mdf_txtbox.Text =  nmaluno_txtbox.Text+", sua média final é: "+ md.ToString();

            if (md >= 5)
            {
                situacao_lbl.ForeColor = System.Drawing.Color.Green;
                situacao_lbl.Text = "APROVADO!";
            }

            else{
                situacao_lbl.ForeColor = System.Drawing.Color.Red;
                situacao_lbl.Text = "REPROVADO!";
            }
                

            n1_txtbox.Text = null;
            n2_txtbox.Text = null;
            n3_txtbox.Text = null;
            n4_txtbox.Text = null;

            nmaluno_txtbox.Text = null;



        }
    }
}
