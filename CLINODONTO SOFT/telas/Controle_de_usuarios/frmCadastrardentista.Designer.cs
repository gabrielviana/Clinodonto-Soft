namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    partial class frmCadastrardentista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrardentista));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtCro = new System.Windows.Forms.TextBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.gpbMedicoDPessoais = new System.Windows.Forms.GroupBox();
            this.txtOrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.txtEnderecoMedico = new System.Windows.Forms.TextBox();
            this.txtTelefoneMedico = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.gpbMedicoDPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(764, 431);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(644, 431);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(38, 391);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(120, 28);
            this.btnApagar.TabIndex = 27;
            this.btnApagar.Text = "Limpar campos";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtCro
            // 
            this.txtCro.Location = new System.Drawing.Point(97, 96);
            this.txtCro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCro.MaxLength = 5;
            this.txtCro.Name = "txtCro";
            this.txtCro.Size = new System.Drawing.Size(145, 22);
            this.txtCro.TabIndex = 7;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(46, 99);
            this.lblCRM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(51, 17);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "* CRO:";
            // 
            // gpbMedicoDPessoais
            // 
            this.gpbMedicoDPessoais.Controls.Add(this.txtRg);
            this.gpbMedicoDPessoais.Controls.Add(this.txtCpf);
            this.gpbMedicoDPessoais.Controls.Add(this.txtSenha);
            this.gpbMedicoDPessoais.Controls.Add(this.label2);
            this.gpbMedicoDPessoais.Controls.Add(this.txtOrg);
            this.gpbMedicoDPessoais.Controls.Add(this.label1);
            this.gpbMedicoDPessoais.Controls.Add(this.txtNomeMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtEnderecoMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtCro);
            this.gpbMedicoDPessoais.Controls.Add(this.lblCRM);
            this.gpbMedicoDPessoais.Controls.Add(this.txtTelefoneMedico);
            this.gpbMedicoDPessoais.Controls.Add(this.txtLogin);
            this.gpbMedicoDPessoais.Controls.Add(this.lblEndereco);
            this.gpbMedicoDPessoais.Controls.Add(this.lblTelefone);
            this.gpbMedicoDPessoais.Controls.Add(this.lblCPF);
            this.gpbMedicoDPessoais.Controls.Add(this.lbllogin);
            this.gpbMedicoDPessoais.Controls.Add(this.lblRG);
            this.gpbMedicoDPessoais.Controls.Add(this.lblNome);
            this.gpbMedicoDPessoais.Location = new System.Drawing.Point(29, 14);
            this.gpbMedicoDPessoais.Margin = new System.Windows.Forms.Padding(4);
            this.gpbMedicoDPessoais.Name = "gpbMedicoDPessoais";
            this.gpbMedicoDPessoais.Padding = new System.Windows.Forms.Padding(4);
            this.gpbMedicoDPessoais.Size = new System.Drawing.Size(835, 324);
            this.gpbMedicoDPessoais.TabIndex = 23;
            this.gpbMedicoDPessoais.TabStop = false;
            this.gpbMedicoDPessoais.Text = "Dados Pessoais";
            // 
            // txtOrg
            // 
            this.txtOrg.Location = new System.Drawing.Point(97, 156);
            this.txtOrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrg.MaxLength = 13;
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(192, 22);
            this.txtOrg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Org. exp.:";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(97, 36);
            this.txtNomeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(723, 22);
            this.txtNomeMedico.TabIndex = 1;
            // 
            // txtEnderecoMedico
            // 
            this.txtEnderecoMedico.Location = new System.Drawing.Point(97, 66);
            this.txtEnderecoMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnderecoMedico.MaxLength = 100;
            this.txtEnderecoMedico.Name = "txtEnderecoMedico";
            this.txtEnderecoMedico.Size = new System.Drawing.Size(723, 22);
            this.txtEnderecoMedico.TabIndex = 2;
            // 
            // txtTelefoneMedico
            // 
            this.txtTelefoneMedico.Location = new System.Drawing.Point(97, 216);
            this.txtTelefoneMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefoneMedico.MaxLength = 9;
            this.txtTelefoneMedico.Name = "txtTelefoneMedico";
            this.txtTelefoneMedico.Size = new System.Drawing.Size(192, 22);
            this.txtTelefoneMedico.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(97, 246);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(192, 22);
            this.txtLogin.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(20, 69);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(73, 17);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(22, 221);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 17);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(46, 189);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(36, 246);
            this.lbllogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(56, 17);
            this.lbllogin.TabIndex = 3;
            this.lbllogin.Text = "* Login:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(55, 127);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(33, 17);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 39);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "* Nome:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 346);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 28);
            this.button3.TabIndex = 30;
            this.button3.Text = "Expediente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(97, 281);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(192, 22);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "* Senha:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(97, 125);
            this.txtRg.Mask = "00000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(145, 22);
            this.txtRg.TabIndex = 135;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(97, 186);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(145, 22);
            this.txtCpf.TabIndex = 134;
            // 
            // frmCadastrardentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(895, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gpbMedicoDPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCadastrardentista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Dentista";
            this.gpbMedicoDPessoais.ResumeLayout(false);
            this.gpbMedicoDPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtCro;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.GroupBox gpbMedicoDPessoais;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.TextBox txtEnderecoMedico;
        private System.Windows.Forms.TextBox txtTelefoneMedico;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
    }
}