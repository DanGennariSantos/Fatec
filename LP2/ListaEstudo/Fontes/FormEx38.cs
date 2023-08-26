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
    public partial class FormEx38 : Form
    {
        public FormEx38()
        {
            InitializeComponent();
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            double[,] matrizCompra = new double[7, 5];
            double[] totalPorDia = new double[7];
            double totalGeral = 0;

            for (int dia = 0; dia < 7; dia++)
            {
                for (int produto = 0; produto < 5; produto++)
                {
                    string input = Interaction.InputBox($"Digite o valor para o produto {produto + 1} no dia {dia + 1}:");
                    if (!double.TryParse(input, out double valor))
                    {
                        MessageBox.Show("Valor inválido. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        produto--;
                    }
                    matrizCompra[dia, produto] = valor;
                }
            }

            // Calcular o total por dia e o total geral
            for (int dia = 0; dia < 7; dia++)
            {
                double totalDia = 0;
                for (int produto = 0; produto < 5; produto++)
                {
                    totalDia += matrizCompra[dia, produto];
                }
                totalPorDia[dia] = totalDia;
                totalGeral += totalDia;
            }

            // Exibir resultados no ListBox
            lboxResultado.Items.Clear();
            for (int dia = 0; dia < 7; dia++)
            {
                lboxResultado.Items.Add($"Total do dia {dia + 1}: {totalPorDia[dia]}");
            }
            lboxResultado.Items.Add($"\nTotal geral: {totalGeral}");
        }
    }
}
