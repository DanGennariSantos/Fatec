using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class frmTriangulo : Form
    {
        double ladoA, ladoB, ladoC;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtTriangulo.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtA.Text, out ladoA) || txtA.Text == "")
            {
                MessageBox.Show("Valor do lado A inválido. Digite um número.");
                txtA.Clear();
            }

            else if (ladoA <= 0)
            {
                MessageBox.Show("O lado A deve ser maior que zero.");
                txtA.Clear(); ;
            }

        }

        private void txtB_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtB.Text, out ladoB) || txtB.Text == "")
            {
                MessageBox.Show("Valor do lado B inválido. Digite um número.");
                txtB.Clear();
            }

            else if (ladoB <= 0)
            {
                MessageBox.Show("O lado B deve ser maior que zero.");
                txtB.Clear();
            }
        }

        private void txtC_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtC.Text, out ladoC) || txtB.Text == "")
            {
                MessageBox.Show("Valor do lado C inválido. Digite um número.");
                txtC.Clear();
            }

            else if (ladoC <= 0)
            {
                MessageBox.Show("O lado C deve ser maior que zero.");
                txtC.Clear();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtA.Text, out ladoA) || !Double.TryParse(txtB.Text, out ladoB) || !Double.TryParse(txtC.Text, out ladoC))
                MessageBox.Show("Algum lado é inválido! Verifique.");
            else
            {
                if (ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC) &&
                    ladoB < (ladoA + ladoC) && ladoB > Math.Abs(ladoA - ladoC) &&
                    ladoC < (ladoA + ladoB) && ladoC > Math.Abs(ladoA - ladoB))
                {
                    if (ladoA == ladoB && ladoA == ladoC)
                        txtTriangulo.Text = "Equilátero";

                    else if ((ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) && (ladoA != ladoB || ladoA != ladoC || ladoB != ladoC))
                        txtTriangulo.Text = "Isósceles";

                    else
                        txtTriangulo.Text = "Escaleno";
                }

                else
                {
                    MessageBox.Show("Lados informados não formam um triângulo.");
                }

            }

        }

        public frmTriangulo()
        {
            InitializeComponent();
        }
    }
}
