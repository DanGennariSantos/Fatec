using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class frmIMC : Form
    {
        double peso;
        double altura;
        double imc;

        public frmIMC()
        {
            InitializeComponent();

        }

       private void FrmIMC_Load(object sender, EventArgs e)
        {
            

        }

        //private void MskbxPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        //{

       // }

        private void MskbxPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido!");
            }

        else if (peso <= 0)
            {
                MessageBox.Show("Peso deve ser maior que de zero");
            }
        }

        private void MskbxAltura_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
            }

            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero");
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxAltura.Text, out altura) || !Double.TryParse(mskbxPeso.Text, out peso) || altura == 0 || peso == 0)
            {
                MessageBox.Show("Valores inválidos!");
            }
            else
            {
                imc = peso / Math.Pow(altura, 2);
                imc = Math.Round(imc, 1);

                txtIMC.Text = imc.ToString("N1");

                if (imc < 18.5)
                    MessageBox.Show("Classificação: Magreza");

                else if (imc <= 24.9)
                    MessageBox.Show("Classificação: Normal");

                else if (imc <= 29.9)
                    MessageBox.Show("Classificação: Sobrepeso");

                else if (imc <= 39.9)
                    MessageBox.Show("Classificação: Obesidade");

                else
                    MessageBox.Show("Classificação: Obesidade Grave!");

            }     
            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            mskbxPeso.Clear();
            mskbxAltura.Clear();
            txtIMC.Clear();

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
