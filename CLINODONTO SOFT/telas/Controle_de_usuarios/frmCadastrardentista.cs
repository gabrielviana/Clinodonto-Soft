using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CLINODONTO_SOFT.classes;

namespace CLINODONTO_SOFT.telas.Controle_de_usuarios
{
    public partial class frmCadastrardentista : Form
    {
        string ID;
        ArrayList arr = new ArrayList();
        int aux=0;
        public frmCadastrardentista()
        {
            InitializeComponent();

        }
        public frmCadastrardentista(string id)
        {
            ID = id;
            InitializeComponent();
            aux = 1;
            classDentista de = new classDentista();
            arr = de.bucareditar(id);

            txtNomeMedico.Text = ((classDentista)arr[0]).Nome;
            txtEnderecoMedico.Text = ((classDentista)arr[0]).Endereco;
            txtCro.Text = ((classDentista)arr[0]).Cro;
            txtRg.Text = ((classDentista)arr[0]).Rg.ToString();
            txtOrg.Text = ((classDentista)arr[0]).Orgaoexpedidor;
            txtCpf.Text = ((classDentista)arr[0]).Cpf.ToString();
            txtTelefoneMedico.Text = ((classDentista)arr[0]).Telefone.ToString();
            txtLogin.Text = ((classDentista)arr[0]).Login;
            txtSenha.Text = ((classDentista)arr[0]).Senha;
         
            txtLogin.Enabled = false;
            txtCro.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmExpediente().ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
           txtNomeMedico.Text = string.Empty;
           txtEnderecoMedico.Text = string.Empty;
           txtCro.Text = string.Empty;
           txtRg.Text = string.Empty;
           txtOrg.Text = string.Empty;
           txtCpf.Text = string.Empty;
           txtTelefoneMedico.Text = string.Empty;
           txtLogin.Text = string.Empty;
           txtSenha.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCro.Text != null || txtNomeMedico.Text != string.Empty || txtLogin.Text != string.Empty || txtSenha.Text != string.Empty)
            {
                classDentista d = new classDentista();
                ArrayList arra = new ArrayList();
                arra = d.bucaverificar(txtCro.Text, txtLogin.Text);

                    if (aux == 1)
                    {
                        d.Nome = txtNomeMedico.Text;
                        d.Endereco = txtEnderecoMedico.Text;
                        d.Cro = txtCro.Text;
                        d.Rg = txtRg.Text;
                        d.Orgaoexpedidor = txtOrg.Text;
                        d.Cpf = txtCpf.Text;
                        d.Telefone = int.Parse(txtTelefoneMedico.Text);
                        d.Login = txtLogin.Text;
                        d.Senha = txtSenha.Text;

                        try
                        {
                            d.Editar(ID);
                            MessageBox.Show("Dados alterados com sucesso.\n", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        catch (Exception tt)
                        {
                            MessageBox.Show("erro!\n" + tt.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        if (arra.Count == 0)
                        {
                
                            d.Nome = txtNomeMedico.Text;
                            d.Endereco = txtEnderecoMedico.Text;
                            d.Cro = txtCro.Text;
                            d.Rg = txtRg.Text;
                            d.Orgaoexpedidor = txtOrg.Text;
                            d.Cpf = txtCpf.Text;
                             d.Telefone = int.Parse(txtTelefoneMedico.Text);
                            d.Login = txtLogin.Text;
                            d.Senha = txtSenha.Text;
                            d.Tipo = 1;
                            try
                            {
                                d.Salvar();
                                MessageBox.Show("Dentista salvo com sucesso.\n", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Close();
                            }
                            catch (Exception tt)
                            {
                                MessageBox.Show("erro!\n" + tt.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                      }
                        else
                        {
                            MessageBox.Show("Login ou Cro já estam sendo usados por outro dentista.\n", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                
          
            }
            else
            {
                MessageBox.Show("Os campos com * não podem ficar em branco \n", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }



    }
}
