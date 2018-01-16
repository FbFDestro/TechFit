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
    public partial class frmAdminPrincipal : Form
    {
        public frmAdminPrincipal()
        {
            InitializeComponent();
        }


        private void lblBtnAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos telaAdminAlunos = new frmAlunos();
            this.Hide();
            telaAdminAlunos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmAdminFuncionarios telaAdminFunc = new frmAdminFuncionarios();
            this.Hide();
            telaAdminFunc.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Observações telaObs = new Observações();
            this.Hide();
            telaObs.Show();
        }

        private void lblBtnEditarPerfil_Click(object sender, EventArgs e)
        {
            frmAdminEditar telaAdminEditar = new frmAdminEditar();
            telaAdminEditar.ShowDialog();
        }

        private void lblBtnFunc_Click(object sender, EventArgs e)
        {
            frmAdminFuncionarios telaAdminFunc = new frmAdminFuncionarios();
            telaAdminFunc.Show();
            this.Hide();
        }

        private void lblBtnFincanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro telaAdminFinanceiro = new frmFinanceiro();
            telaAdminFinanceiro.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaLogin telaLogin = new frmTelaLogin();
            this.Hide();
            telaLogin.Show();

            acessoDadosLogado.Codigo = null;
            acessoDadosLogado.Login = null;
            acessoDadosLogado.Nome = null;
            acessoDadosLogado.Senha = null;
            acessoDadosLogado.Tipo = null;
        }

        private void frmAdminPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar o programa?", "Fechar o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                e.Cancel = true;

            }
            else
            {

                Application.Exit();
            }
        }
    }
}
