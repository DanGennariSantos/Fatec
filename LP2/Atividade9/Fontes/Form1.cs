using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcularMedia_Click(object sender, System.EventArgs e)
        {
            double[,] medias = new double[20, 3];
            double soma = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string input = Interaction.InputBox($"Digite a nota {j + 1} do aluno {i + 1}: ", "Entrada de Dados");
                    if (!int.TryParse(input, out int nota))
                    {
                        MessageBox.Show("Digite somente números");
                        j--;
                    }
                    else
                    {
                        soma += nota;
                        medias[i, j] = nota;
                    }
                }
                MessageBox.Show($"Nota do aluno {i + 1}: média: {soma / 3}");
            }
        }

        private void BtnInverter_Click(object sender, System.EventArgs e)
        {
            int[] vetor = new int[20];
            for (int i = 0; i < 20; i++)
            {
                string input = Interaction.InputBox("Digite um número: ", "Entrada de Dados");
                if (!int.TryParse(input, out int numero))
                {
                    MessageBox.Show("Digite somente números inteiros");
                    i--;
                }
                vetor[i] = numero;
            }

            Array.Reverse(vetor);

            foreach (var item in vetor)
            {
                MessageBox.Show(item.ToString());
            }

            MessageBox.Show("Acabou!");
        }

        private void btnArmazem_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            double faturamento = 0;

            for (int i = 0; i < 10; i++)
            {
                string input = Interaction.InputBox($"Digite a quantidade {i + 1}:", "Entrada de dados");
                if (!double.TryParse(input, out quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida");
                    i--;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        input = Interaction.InputBox($"Digite o preço {i + 1}:", "PREÇO");
                        if (!double.TryParse(input, out preco[i]))
                        {
                            MessageBox.Show("Preço inválido");
                            i--;
                        }
                        faturamento += quantidade[i] * preco[i];
                    }
                }
            }
            MessageBox.Show($"Faturamento total: {faturamento.ToString("N2")}");
        }

        private void BtnListaAlunos_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList() { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            foreach (var item in alunos)
            {
                MessageBox.Show($"Lista de alunos: {item.ToString()}");
            }

            alunos.Remove("Otávio");

            foreach (var item in alunos)
            {
                MessageBox.Show($"Nova lista de alunos: {item.ToString()}");
            }
        }

        private void BtnCalcularCaracteres_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TotalCaracteres>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe");
                Application.OpenForms["TotalCaracteres"].BringToFront();
            }
            else
            {
                TotalCaracteres form1 = new TotalCaracteres();
                form1.WindowState = FormWindowState.Normal;
                form1.Show();
            }
        }
    }
}
