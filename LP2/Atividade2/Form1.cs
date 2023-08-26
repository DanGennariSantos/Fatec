using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class formCalculadora : Form

    

    {
        double numero1;
        double numero2;
        double resultado;
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void TxtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
                MessageBox.Show("Número inválido!");

        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNumero1.Text, out numero1) && Double.TryParse(txtNumero2.Text, out numero2))
                {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void TxtNumero2_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNumero2.Text, out numero2))
                MessageBox.Show("Número inválido!");
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNumero1.Text, out numero1) && Double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNumero1.Text, out numero1) && Double.TryParse(txtNumero2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNumero1.Text, out numero1) && Double.TryParse(txtNumero2.Text, out numero2) && numero2 != 0)
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Número inválido!");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
