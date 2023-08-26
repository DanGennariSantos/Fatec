using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEstudo
{
    public partial class FormEx36 : Form
    {
        public FormEx36()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //int numero; posso criar a variável antes ou dentro do 'if (tryparse...)'

            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Digite um número inteiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numero <= 0 || numero >= 50)
            {
                MessageBox.Show("Digite um valor maior que zero e menor que 50.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double soma = 0.0;

            // Calcula a soma dos valores da sequência
            for (int i = 1; i <= numero; i++)
            {
                soma += (double)i / (i + 1);
            }

            // Exibe a soma no MessageBox
            MessageBox.Show("A soma dos " + numero + " primeiros valores da sequência é: " + soma.ToString("N2"), "Resultado");
        }
    }
}
