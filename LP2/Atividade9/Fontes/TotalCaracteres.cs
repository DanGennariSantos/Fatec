using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace PMatriz
{
    public partial class TotalCaracteres : Form
    {
        public TotalCaracteres()
        {
            InitializeComponent();
        }

        private void BtnCalcularCaracteres_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[3]; //3 Porque meu RA é 003048222003
            
            for (int i = 0; i < 3; i++)
            {
                nomes[i] = Interaction.InputBox($"Digite seu nome completo:", "ENTRADA"); ;
            }

            foreach (var item in nomes)
            {
                var nomeSemEspaco = item.Replace(" ", "");
                lstBoxNomes.Items.Add($"O nome: {item} tem {nomeSemEspaco.Length} caracteres");
            }
        }
    }
}
