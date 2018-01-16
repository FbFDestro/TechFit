using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechFit
{
    public partial class frmAdminEditar : Form
    {
        acessoEditarPerfilAdmin acessarEditPerfilAdmin = new acessoEditarPerfilAdmin();
      
        public frmAdminEditar()
        {
            InitializeComponent();
        }

        private void lblBtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtLogin.Text == string.Empty || txtSenha.Text == string.Empty || txtSenhaConfirmacao.Text == string.Empty)
            {

                MessageBox.Show("Por favor, preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtNome.Text == string.Empty) { pctrAlertNome.Visible = true; }
                if (txtLogin.Text == string.Empty) { pctrAlertUsuario.Visible = true; }
                if (txtSenha.Text == string.Empty) { pctrAlertSenha.Visible = true; }
                if (txtSenhaConfirmacao.Text == string.Empty) { pctrAlertConfSenha.Visible = true; }

            }
            else {

                if (txtSenha.Text != txtSenhaConfirmacao.Text)
                {

                    MessageBox.Show("A senha e confirmação não conhecidem!", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pctrAlertSenha.Visible = true;
                    pctrAlertConfSenha.Visible = true;
                    txtSenha.Focus();

                }
                else
                {

                    DialogResult result = MessageBox.Show("Você tem certeza que deseja alterar os seus dados?", "Alterar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        acessarEditPerfilAdmin.alterar(txtNome.Text, txtLogin.Text, txtSenha.Text, acessoDadosLogado.Codigo);
                        acessoDadosLogado.Login = txtLogin.Text;
                        acessoDadosLogado.Nome = txtNome.Text;
                        acessoDadosLogado.Senha = txtSenha.Text;

                      DialogResult res =  MessageBox.Show("Dados alterados com sucesso! \r\nDeseja fechar a tela de edição?" ,"Dados alterados", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                      if (res == DialogResult.Yes) {
                          this.Close();

                      }

                    }
                    else
                    {

                        MessageBox.Show("Você cancelou a alteração dos seus dados", "Ação cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
        }

        private void lblBtnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar esta janela? \r\nTenha certeza de ter salvado suas alterações!", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            pctrAlertNome.Visible = false;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            pctrAlertUsuario.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            pctrAlertSenha.Visible = false;
            if (txtSenhaConfirmacao.Text != string.Empty) {
                pctrAlertConfSenha.Visible = false;
            }
        }

        private void txtSenhaConfirmacao_TextChanged(object sender, EventArgs e)
        {
            pctrAlertConfSenha.Visible = false;
            if (txtSenha.Text != string.Empty)
            {
                pctrAlertSenha.Visible = false;
            }
        }

        private void frmAdminEditar_Load(object sender, EventArgs e)
        {

            txtLogin.Text = acessoDadosLogado.Login;
            txtNome.Text = acessoDadosLogado.Nome;
            txtSenha.Text = acessoDadosLogado.Senha;
            txtSenhaConfirmacao.Text = acessoDadosLogado.Senha;

        }



       
    }
}
