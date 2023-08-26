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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcSalBruto_Click(object sender, EventArgs e)
        {
            //string nome = txtNome.Text;
            string cargo = cmbBoxCargo.Text;
            //int matricula = int.Parse(txtMatricula.Text);
            int producao = int.Parse(txtProducao.Text);
            //double salario = double.Parse(txtSalario.Text);
            double gratificacao = double.Parse(txtGratif.Text);


            double A;
            if (cargo == "Soldador")
            {
                A = 6500.00;
            }
            else if (cargo == "Operador")
            {
                A = 4500.00;
            }
            else if (cargo == "Auxiliar")
            {
                A = 3000.00;
            }
            else
            {
                A = 0;
            }

            int B = producao >= 100 ? 1 : 0;
            int C = producao >= 120 ? 1 : 0;
            int D = producao >= 150 ? 1 : 0;

            double salarioBruto = A + A * (0.05 * B + 0.1 * B + 0.1 * D) + gratificacao;

            if (salarioBruto > 7000.00 && (producao < 150 || gratificacao == 0))
            {
                salarioBruto = 7000.00;
            }

            MessageBox.Show("Nome: " + txtNome.Text + "\n" +
                            "Cargo: " + cmbBoxCargo.Text + "\n" + 
                            "Matrícula: " + txtMatricula.Text + "\n\n" + 
                            "Salário Bruto: R$" + salarioBruto.ToString("N2"));

        }
    }
}
