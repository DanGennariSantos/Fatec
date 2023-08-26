using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;

        private void TxtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
            }
            else
    if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero");
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(txtRaio.Text, out raio)) || (!double.TryParse(txtAltura.Text, out altura))){
                MessageBox.Show("Valores inválidos"); 
            }
            else
            {
                if ((altura <=0) || (raio <= 0))
                {
                    MessageBox.Show("Valores não podem ser menores que zero");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtVolume.Text = volume.ToString("N2");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void TxtRaio_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("raio inválido!");
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero");
                //teste de edição no VS Code online
            }

        }
    }
}
