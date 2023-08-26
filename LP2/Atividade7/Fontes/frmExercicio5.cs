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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int min, max;
            if(!int.TryParse(txtMin.Text, out min))
            {
                MessageBox.Show("Valor mínimo inválido");
            }
            else
            {
                if (!int.TryParse(txtMax.Text, out max))
                    MessageBox.Show("Valor máximo inválido");

                else if (max <= min)
                    MessageBox.Show("Valor máximo deve ser maior que o valor mínimo");

                else
                {
                    Random rnd = new Random();
                    int numeroAleatorio = rnd.Next(min, max);

                    txtSort.Text = numeroAleatorio.ToString();
                }
            }

        }
    }
}
