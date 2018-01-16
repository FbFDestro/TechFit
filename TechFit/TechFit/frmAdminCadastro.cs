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
    public partial class frmAdminCadastro : Form
    {

        acessoAdminCadastro acessarAdminCadastro = new acessoAdminCadastro();
        
        public frmAdminCadastro()
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

                    MessageBox.Show("A senha e confirmação não coincidem!", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pctrAlertSenha.Visible = true;
                    pctrAlertConfSenha.Visible = true;
                    txtSenha.Focus();

                }
                else {

                    if (acessarAdminCadastro.verificarLogin(txtLogin.Text) == false)
                    {

                        MessageBox.Show("O nome de usuário escolhido (Login) já existe. \r\nPor favor, digite outro!", "Login já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pctrAlertUsuario.Visible = true;
                        txtLogin.Focus();

                    }
                    else {

                        acessarAdminCadastro.cadastrarAdmin(txtNome.Text, txtLogin.Text, txtSenha.Text);
                        MessageBox.Show("Administrador cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmFincanceioOpcoes finOpcoes = new frmFincanceioOpcoes();
                        finOpcoes.ShowDialog();
                        this.Hide();
                        frmTelaLogin telaLogin = new frmTelaLogin();
                        telaLogin.Show();
                        this.Hide();

                    }

                }

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
            if (txtSenhaConfirmacao.Text != string.Empty)
            {
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

        
    }
}
