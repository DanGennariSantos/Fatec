using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstMensalista_Click(object sender, EventArgs e)
        {
            //Empregado obj1 = new Empregado(); não pode, classe abstrata

            Mensalista objMensalista = new Mensalista();


            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);

            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" + 
                "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + '\n' +
                "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + '\n' + objMensalista.VerificaHome());

        }

        private void BtnInstMensPar_Click(object sender, EventArgs e)
        {

            Mensalista objMensalista = new Mensalista(
            Convert.ToInt32(txtMatricula.Text),
            txtNome.Text,
            Convert.ToDateTime(txtData.Text),
            Convert.ToDouble(txtSalario.Text));

            //get
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + '\n' +
                "Salario Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + '\n' + objMensalista.VerificaHome());
        }
    }
}
