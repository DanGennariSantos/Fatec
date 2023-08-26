using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();   
        }
        private void frmSalario_Load(object sender, EventArgs e)
        {
            //mskbxSalBruto.Mask = "$99990.00";
            Limpar();
        }

        private void btnVerDesc_Click(object sender, EventArgs e)
        {
            double salario;
            if (!double.TryParse(txtSalBruto.Text, out salario) || salario <= 0)
            {
                MessageBox.Show("Digite um salário válido!");
                txtSalBruto.Clear();
            }
            else
            {
                //----------------------------INSS--------------------------
                txtSalBruto.Text = "R$" + salario.ToString("N2");
                double descontoINSS = 0.0;
                if (salario > 2801.56)
                {
                    descontoINSS = 308.17;
                    txtPorcINSS.Text = "Teto";     
                }
                else
                {
                    double aliquotaINSS = CalcularAliquotaINSS(salario);
                    txtPorcINSS.Text = aliquotaINSS.ToString("N2")+"%";
                    descontoINSS = salario * (aliquotaINSS/100);
                }
                txtDescINSS.Text = "R$"+descontoINSS.ToString("N2");

                //----------------------------IRPF--------------------------

                double descontoIRPF = 0.0;
                if (salario <= 1257.12)                  
                {
                    txtPorcIRPF.Text = "Isento";
                    txtDescIRPF.Text = "Isento";
                }
                else
                {
                    double aliquotaIRPF = CalcularAliquitaIRPF(salario);
                    descontoIRPF = salario * (aliquotaIRPF / 100);
                    txtPorcIRPF.Text = aliquotaIRPF.ToString("N2") + "%";
                    txtDescIRPF.Text = "R$"+descontoIRPF.ToString("N2");
                }

                //-------------------Salário Família-------------------------
                int numFilhos = (int)numUPFilhos.Value;
                double salFamilia = 0.0;

                if (salario <= 435.52)
                    salFamilia = 22.33 * numFilhos;

                else if (salario <= 654.61)
                    salFamilia = 15.74 * numFilhos;

                else
                    salFamilia = 0.00;

                txtSalFamilia.Text = "R$"+salFamilia.ToString("N2");

                double salLiquido = salario - descontoINSS - descontoIRPF + salFamilia;
                txtSalLiquido.Text = "R$"+salLiquido.ToString("N2");

                string sexo;
                if (rbtnFem.Checked == true)
                    sexo = "da sra.";
                else
                    sexo = "do sr. ";

                string estCivil;
                if (cboxCasado.Checked == true)
                    estCivil = "casado(a)";
                else
                    estCivil = "solteiro(a)";

                lblMensagem.Visible = true;
                lblMensagem.Text = $"Segue o detalhamento do salário {sexo} {txtNomeFunc.Text}, que é {estCivil} e tem {numFilhos.ToString()} filho(s):";
            }

        }

        double CalcularAliquotaINSS(double salario)
        {
            double aliquota = 0.0;

            if (salario <= 800.47)
                aliquota = 7.65;

            else if (salario <= 1050.00)
                aliquota = 8.65;

            else if (salario <= 1400.77)
                aliquota = 9.00;

            else if (salario <= 2801.56)
                aliquota = 11.00;

            return aliquota;
        }

            double CalcularAliquitaIRPF(double salario)
        {
            double aliquota;

            if (salario <= 1257.12)
                aliquota = 0.0;

            else if (salario <= 2512.08)
                aliquota = 15.00;

            else
                aliquota = 27.5;

            return aliquota;
        }

        void Limpar()
        {
            txtNomeFunc.Clear();
            txtSalBruto.Clear();
            numUPFilhos.Value = 0;
            txtDescINSS.Clear();
            txtDescIRPF.Clear();
            txtPorcINSS.Clear();
            txtPorcIRPF.Clear();
            txtSalFamilia.Clear();
            txtSalLiquido.Clear();
            cboxCasado.Checked = false;
            rbtnFem.Checked = true;
            rbtnMasc.Checked = false;
            lblMensagem.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
