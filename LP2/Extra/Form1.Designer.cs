
namespace Extra
{
    partial class pnlCadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(60, 60);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(60, 141);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(82, 20);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 222);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(60, 303);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(62, 20);
            this.lblCelular.TabIndex = 3;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(60, 384);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 57);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 26);
            this.txtNome.TabIndex = 5;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(153, 138);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(361, 26);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 219);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(153, 300);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(139, 26);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(153, 381);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(139, 26);
            this.txtCPF.TabIndex = 9;
            this.txtCPF.Enter += new System.EventHandler(this.textBox5_Enter);
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(204, 448);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(127, 43);
            this.btnTestar.TabIndex = 10;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            // 
            // pnlCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 585);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pnlCadastroAluno";
            this.Text = "Cadastro de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnTestar;
    }
}

