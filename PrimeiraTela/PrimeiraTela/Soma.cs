using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraTela
{
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            double nm1 = System.Convert.ToDouble(nm1_txtbox.Text);
            double nm2 = System.Convert.ToDouble(nm2_txtbox.Text);
            double r = nm1 + nm2;

            Resultado_txtbox.Text = r.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
