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
    public partial class Observações : Form
    {
        acessoObservacoes observacoes = new acessoObservacoes();

        public Observações()
        {
            InitializeComponent();
        }


        private void lblBtnAdicionar_Click(object sender, EventArgs e)
        {
            frmObservacoesCadastro telaAdminObservacoesCad = new frmObservacoesCadastro();
            this.Hide();
            telaAdminObservacoesCad.Show();
        }

        private void frmAdminObservacoes_Load(object sender, EventArgs e)
        {

            try
            {
                gvExibirObs.DataSource = observacoes.listarTudo();

                gvExibirObs.Columns[0].Visible = false;

                gvExibirObs.Columns[1].HeaderText = "Dono";
                gvExibirObs.Columns[1].Width = 80;

                gvExibirObs.Columns[2].HeaderText = "Tipo";
                gvExibirObs.Columns[2].Width = 80;

                gvExibirObs.Columns[3].HeaderText = "Assunto";
                gvExibirObs.Columns[3].Width = 95;

                gvExibirObs.Columns[4].HeaderText = "Mensagem";
                gvExibirObs.Columns[4].Width = 260;


                gvExibirObs.Columns[5].HeaderText = "Prioridade";
                gvExibirObs.Columns[5].Width = 91;

                gvExibirObs.Columns[6].HeaderText = "Data do envio";
                gvExibirObs.Columns[6].Width = 91;

                
                
           
            }
            catch
            {
                gvExibirObs.Visible = false;
            }
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (acessoDadosLogado.Tipo == "Administrador")
            {
                frmAdminPrincipal telaAdminPrincipal = new frmAdminPrincipal();
                this.Hide();
                telaAdminPrincipal.Show();
            }
            else { 

                frmFuncionarioPrincipal telaFuncPrincipal = new frmFuncionarioPrincipal();
                this.Hide();
                telaFuncPrincipal.Show();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            observacoes.pesquisarObjFiltro(txtPesquisar.Text);

            gvExibirObs.DataSource = observacoes.TabelaFilto;
        }

        private void frmObservacoes_FormClosing(object sender, FormClosingEventArgs e)
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
