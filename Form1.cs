﻿using System;
using System.Windows.Forms;

namespace SobreCargaOperadores_G3_2022_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
          
            if (rdbSuma.Checked)
            {
                float real = float.Parse(txtbComReal1.Text);
                float imaginaria = float.Parse(txtbComIma1.Text);
                Complejo c1 = new Complejo(real, imaginaria);

                real = float.Parse(txtbComReal2.Text);
                imaginaria = float.Parse(txtbComIma2.Text);
                Complejo c2 = new Complejo(real, imaginaria);

                Complejo c3 = c1 + c2;
                lbResultado.Text = c3.ToString();
            }
            if (rdbResta.Checked)
            {
                float real = float.Parse(txtbComReal1.Text);
                float imaginaria = float.Parse(txtbComIma1.Text);
                Complejo c1 = new Complejo(real, imaginaria);

                real = float.Parse(txtbComReal2.Text);
                imaginaria = float.Parse(txtbComIma2.Text);
                Complejo c2 = new Complejo(real, imaginaria);

                Complejo c3 = c1 - c2;
                lbResultado.Text = c3.ToString();
            }
            if (rdbMultiplica.Checked)
            {
                float real = float.Parse(txtbComReal1.Text);
                float imaginaria = float.Parse(txtbComIma1.Text);
                Complejo c1 = new Complejo(real, imaginaria);

                real = float.Parse(txtbComReal2.Text);
                imaginaria = float.Parse(txtbComIma2.Text);
                Complejo c2 = new Complejo(real, imaginaria);

                Complejo c3 = c1 * c2;
                lbResultado.Text = c3.ToString();
            }
            if (rdbConjuga.Checked)
            {
                float real;
                float imaginaria;
                real = float.Parse(txtbComReal1.Text);
                imaginaria = float.Parse(txtbComIma1.Text);
                Complejo c1 = new Complejo(real, imaginaria);
                lbResultado.Text = (~c1).ToString();
            }

        }


        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {
            lbOperador.Text = "+";
            btnSumar.Text = "Sumar";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            lbOperador.Text = "-";
            btnSumar.Text = "Resta";
        }

        private void rdbMultiplica_CheckedChanged(object sender, EventArgs e)
        {
            lbOperador.Text = "*";
            btnSumar.Text = "Multiplicacion";
        }

        private void rdbConjuga_CheckedChanged(object sender, EventArgs e)
        {
            lbOperador.Text = "";
            btnSumar.Text = "Conjugar";
               
        }

       
    }
}
