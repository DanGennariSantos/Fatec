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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int N;
            double H = 0.0;

            if(int.TryParse(txtNum.Text, out N) && N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    H += 1.0 / i;   
                }
                MessageBox.Show("Valor de H = " + H.ToString("N2"));
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }

        }
    }
}
