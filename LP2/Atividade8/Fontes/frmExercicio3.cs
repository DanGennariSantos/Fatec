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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalind_Click(object sender, EventArgs e)
        {
            string entrada = txtPalind.Text;
            string semEspacos = entrada.Replace(" ","");

            char[] charSemEspacos = semEspacos.ToCharArray();
            Array.Reverse(charSemEspacos);
            string invertida = new string(charSemEspacos);

            int palindromo = string.Compare(semEspacos, invertida);

            if (palindromo == 0)
            {
                MessageBox.Show("É palímdromo!\n" +
                    "Palavra ou frase invertida: " +
                    invertida);
            }
            else
            {
                MessageBox.Show("Não é palindromo!\n" +
                    "Palavra ou frase invertida: " + 
                    invertida);
            }


        }
    }
}
