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
    public partial class frmFuncionarioPrincipal : Form
    {        
        public frmFuncionarioPrincipal()
        {
            InitializeComponent();
        }

        private void lblBtnTreinosEObjetivos_Click(object sender, EventArgs e)
        {
            frmFuncObjetivos telaObjetivos = new frmFuncObjetivos();
            this.Hide();
            telaObjetivos.Show();
        }

        private void lblBtnObservacoes_Click(object sender, EventArgs e)
        {
            Observações telaObs = new Observações();
            this.Hide();
            telaObs.Show();
        }

        private void lblBtnEditarPerfil_Click(object sender, EventArgs e)
        {
            frmFuncionarioEditar telaFuncEditar = new frmFuncionarioEditar();
            telaFuncEditar.Show();
            this.Hide();
        }

        private void lblBtnAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos telaAlunos = new frmAlunos();
            this.Hide();
            telaAlunos.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void lblBtnFinanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro telaFinanceiro = new frmFinanceiro();
            telaFinanceiro.Show();
            this.Hide();
        }


        private void frmFuncionarioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
