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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstHorista_Click(object sender, EventArgs e)
        {
            //Empregado obj1 = new Empregado(); não pode, classe abstrata

            Horista objHorista = new Horista();


            //set
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data de Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + '\n' +
                "Salario Bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + '\n' + objHorista.VerificaHome());
        }
    }
}
