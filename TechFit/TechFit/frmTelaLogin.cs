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
    public partial class frmTelaLogin : Form
    {
        acessoLogin acessarLogin = new acessoLogin();

        string tipo;

        public frmTelaLogin()
        {
            InitializeComponent();
        }

        private void lblBtnEntrar_Click(object sender, EventArgs e)
        {

            if (tipo == null || txtLoginUsuario.Text == string.Empty || txtLoginSenha.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (tipo == null) { pctrAlertTipo.Visible = true; }
                if (txtLoginUsuario.Text == string.Empty) { pctrAlertUsuario.Visible = true; }
                if (txtLoginSenha.Text == string.Empty) { pctrAlertSenha.Visible = true; }

            }
            else
            {
                if (tipo == "Administrador")
                {


                    if (acessarLogin.loginAdmin(txtLoginUsuario.Text, txtLoginSenha.Text) == false)
                    {

                        MessageBox.Show("Nenhum administrador cadastrado com este login", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        if (txtLoginSenha.Text != acessarLogin.Senha_admin)
                        {

                            MessageBox.Show("A senha digitada é uma senha invalida!", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            acessoDadosLogado.Codigo = acessarLogin.Cod_admin.ToString();
                            acessoDadosLogado.Login = txtLoginUsuario.Text;
                            acessoDadosLogado.Nome = acessarLogin.Nome_admin;
                            acessoDadosLogado.Senha = txtLoginSenha.Text;
                            acessoDadosLogado.Tipo = "Administrador";

                            frmAdminPrincipal telaAdminPrincipal = new frmAdminPrincipal();
                            this.Hide();
                            telaAdminPrincipal.Show();

                        }
                    }
                }
                else if (tipo == "Funcionário")
                {
                    if (acessarLogin.loginFuncionario(txtLoginUsuario.Text, txtLoginSenha.Text) == false)
                    {

                        MessageBox.Show("Nenhum funcionário cadastrado com este login", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        if (txtLoginSenha.Text != acessarLogin.Senha_func)
                        {

                            MessageBox.Show("A senha digitada é uma senha invalida!", "Erro ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            acessoDadosLogado.Codigo = acessarLogin.Cod_func.ToString();
                            acessoDadosLogado.Login = txtLoginUsuario.Text;
                            acessoDadosLogado.Nome = acessarLogin.Nome_func;
                            acessoDadosLogado.Senha = txtLoginSenha.Text;
                            acessoDadosLogado.Tipo = "Funcionário";

                            frmFuncionarioPrincipal telaFuncPrincipal = new frmFuncionarioPrincipal();
                            this.Hide();
                            telaFuncPrincipal.Show();

                        }
                    }


                }
              

            }
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Administrador";
            pctrAlertTipo.Visible = false;
        }

        private void rdFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Funcionário";
            pctrAlertTipo.Visible = false;
        }

        private void rdAlunos_CheckedChanged(object sender, EventArgs e)
        {
            tipo = "Aluno";
            pctrAlertTipo.Visible = false;
        }

        private void txtLoginUsuario_TextChanged(object sender, EventArgs e)
        {
            pctrAlertUsuario.Visible = false;
        }

        private void txtLoginSenha_TextChanged(object sender, EventArgs e)
        {
            pctrAlertSenha.Visible = false;
        }

        private void frmTelaLogin_Load(object sender, EventArgs e)
        {
            tipo = "Administrador";
        }

        private void frmTelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar o programa?", "Fechar o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                e.Cancel = true;

            }
 
        }     
    }
}
