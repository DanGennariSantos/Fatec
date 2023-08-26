using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ListaEstudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx37_Click(object sender, EventArgs e)
        {
            {
                double[] vetorA = new double[10];
                double[,] matrizB = new double[10, 1];

                for (int i = 0; i < 10; i++)
                {
                    string input = Interaction.InputBox($"Digite o número {i+1}: ", "Entrada de dados");
                    
                    if (!double.TryParse(input, out double numero))
                    {
                        MessageBox.Show("Digite somente números!");
                        i--;
                    }
                    else
                    {
                        vetorA[i] = numero;

                        if (i % 2 == 0)
                            matrizB[i, 0] = numero * 5;
                        else
                            matrizB[i, 0] = numero + 5;
                    }                  
                }

                string vetorAStr = "Vetor A:\n";
                foreach (double numero in vetorA)
                {
                    vetorAStr += numero + " ";
                }

                string matrizBStr = "Matriz B:\n";
                for (int i = 0; i < 10; i++)
                {
                    matrizBStr += matrizB[i, 0] + "\n";
                }

                MessageBox.Show(vetorAStr + "\n\n" + matrizBStr);
                //MessageBox.Show(matrizBStr);
            }
        }

        private void btnEx36_Click(object sender, EventArgs e)
        {
            FormEx36 form1 = new FormEx36();
            form1.WindowState = FormWindowState.Normal;
            form1.Show();
        }

        private void btnEx38_Click(object sender, EventArgs e)
        {
            FormEx38 form2 = new FormEx38();
            form2.WindowState = FormWindowState.Normal;
            form2.Show();

        }
    }
}
