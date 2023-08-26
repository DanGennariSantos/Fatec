using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void RchTxtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEspaco_Click(object sender, EventArgs e)
        {
            int i, cont = 0;

            for(i = 0; i < rchTxtTexto.Text.Length; i++)
            {
                if (rchTxtTexto.Text[i] == ' ')
                {
                    cont++;
                }

            }
            MessageBox.Show("Número de espaços em branco é: " + cont);
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int i = 0;

            foreach(char letra in rchTxtTexto.Text)
            {
                if (letra == 'r' || letra == 'R')
                {
                    cont++;
                }
                i++;
            }

            MessageBox.Show("Número de letras 'R' é: " + cont);
        }

        private void BtnRep_Click(object sender, EventArgs e)
        {
            int i;
            int cont = 0;

            for (i = 1; i < rchTxtTexto.Text.Length; i++)
            {
                if (rchTxtTexto.Text[i] == rchTxtTexto.Text[i - 1])
                {
                    cont++;
                }
            }

            MessageBox.Show("Número de letras repetidas é: " + cont);

        }
    }
}
