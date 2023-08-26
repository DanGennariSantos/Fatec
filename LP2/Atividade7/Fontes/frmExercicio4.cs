using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void bntNumeros_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int tamanho = rchtxtTexto.Text.Length;

            for (int i = 0; i < tamanho; i++)
            {
                if (char.IsNumber(rchtxtTexto.Text, i))
                    resultado++;
            }

            txtResultado.Text = resultado.ToString();

        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int tamanho = rchtxtTexto.Text.Length;

            int i = 0;
            char caracter = rchtxtTexto.Text[i];

            while (char.IsWhiteSpace(caracter) == false)
            {
                i++;
                if (i >= tamanho)
                    break;

                caracter = rchtxtTexto.Text[i];
            }

            if (char.IsWhiteSpace(caracter) == true)
                resultado = i;
            else
                resultado = 0;

            txtResultado.Text = resultado.ToString();

        }

        private void bntLetras_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            char[] caracteres = rchtxtTexto.Text.ToCharArray();

            foreach (char letra in caracteres)
            {
                if (char.IsLetter(letra))
                    resultado++;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            rchtxtTexto.Clear();
        }
    }
}
