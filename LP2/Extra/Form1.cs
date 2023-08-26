using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra
{
    public partial class pnlCadastroAluno : Form
    {
        public pnlCadastroAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(13)) //se a tecla Enter foi pressionada. Obs: tecla Enter na tabela ASCII é 13
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }

        }

        private void textBox2_Validated(object sender, EventArgs e) //Endereço
        {
            if ((txtEndereco.Text == "") || (txtEndereco.Text.Length < 20))
            {
                MessageBox.Show("Endereço inválido");
                txtEndereco.Focus();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("E-mail vazio");
                e.Cancel = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("celular-textbox4 perdeu o foco");
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("CPF-textBox5 ganhou o foco");
        }
    }
}
