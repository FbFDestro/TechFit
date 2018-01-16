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
    public partial class frmFinanceiro : Form
    {
        acesssoLucroDespesa acessarLD = new acesssoLucroDespesa();

        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void lblBtnCadastrarLucros_Click(object sender, EventArgs e)
        {
            frmCadastroLucro telaCadLucro = new frmCadastroLucro();
            telaCadLucro.ShowDialog();
            gvExibirLucrosDespesas.DataSource = acessarLD.listarTudo();

        }

        private void lblBtnCadastrarDespesas_Click(object sender, EventArgs e)
        {
            frmCadastroDespesa telaCadDesp = new frmCadastroDespesa();
            telaCadDesp.ShowDialog();
            gvExibirLucrosDespesas.DataSource = acessarLD.listarTudo();
        }

        private void lblBtnOpcoes_Click(object sender, EventArgs e)
        {
            frmFincanceioOpcoes telaFinOp = new frmFincanceioOpcoes();
            telaFinOp.ShowDialog();
            
        }

        private void frmAdminFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                gvExibirLucrosDespesas.DataSource = acessarLD.listarTudo();

                gvExibirLucrosDespesas.Columns[0].Visible = false;

                gvExibirLucrosDespesas.Columns[1].HeaderText = "Descrição";
                gvExibirLucrosDespesas.Columns[1].Width = 120;

                gvExibirLucrosDespesas.Columns[2].HeaderText = "Tipo";
                gvExibirLucrosDespesas.Columns[2].Width = 120;

                gvExibirLucrosDespesas.Columns[3].HeaderText = "Criador";
                gvExibirLucrosDespesas.Columns[3].Width = 120;

                gvExibirLucrosDespesas.Columns[4].HeaderText = "Login";
                gvExibirLucrosDespesas.Columns[4].Width = 120;

                gvExibirLucrosDespesas.Columns[5].HeaderText = "Data";
                gvExibirLucrosDespesas.Columns[5].Width = 120;

                gvExibirLucrosDespesas.Columns[6].HeaderText = "Valor";
                gvExibirLucrosDespesas.Columns[6].Width = 120;

            }
            catch {
                gvExibirLucrosDespesas.Visible = false;
            }
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            if (acessoDadosLogado.Tipo == "Administrador")
            {
                frmAdminPrincipal telaAdminPrincipal = new frmAdminPrincipal();
                this.Hide();
                telaAdminPrincipal.Show();
            }
            else
            {
                frmFuncionarioPrincipal telaFuncPrincipal = new frmFuncionarioPrincipal();
                this.Hide();
                telaFuncPrincipal.Show();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            acessarLD.pesquisarTabelaFiltro(txtPesquisar.Text);

            gvExibirLucrosDespesas.DataSource = acessarLD.Datald;
        }


        private void frmFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
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
