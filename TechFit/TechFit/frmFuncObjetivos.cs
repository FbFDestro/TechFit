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
    public partial class frmFuncObjetivos : Form
    {
        acessoAluno acessarAluno = new acessoAluno();
        acessoFuncionariosObjetivos Objetivos = new acessoFuncionariosObjetivos();

        public frmFuncObjetivos()
        {
            InitializeComponent();
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            frmFuncionarioPrincipal telaFuncPrincipal = new frmFuncionarioPrincipal();
            this.Hide();
            telaFuncPrincipal.Show();
        }

        private void lblBtnDefinirEditar_Click(object sender, EventArgs e)
        {

            frmObjetivosCadastro cadastroObjetivos = new frmObjetivosCadastro();
            cadastroObjetivos.ShowDialog();

        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
       

            acessarAluno.pesquisaNomeFiltro(txtPesquisar.Text);

            gvExibirObjetivos.DataSource = acessarAluno.TabelaFiltro;
        }

        private void gvExibirObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = Convert.ToInt32(gvExibirObjetivos.CurrentCell.RowIndex.ToString());

            dadosAlunosParaTodosFrms.CodAluno = gvExibirObjetivos.Rows[i].Cells[0].Value.ToString();

        }

        private void txtPesquisar_Enter_1(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void frmFuncObjetivos_Load_1(object sender, EventArgs e)
        {
            try
            {
                gvExibirObjetivos.DataSource = acessarAluno.listarAlunos();

                gvExibirObjetivos.Columns[0].HeaderText = "Número de Matricula";
                gvExibirObjetivos.Columns[0].Width = 100;

                gvExibirObjetivos.Columns[1].HeaderText = "Nome do Aluno";
                gvExibirObjetivos.Columns[1].Width = 140;

                gvExibirObjetivos.Columns[3].HeaderText = "E-mail";
                gvExibirObjetivos.Columns[3].Width = 200;

                gvExibirObjetivos.Columns[5].HeaderText = "CPF";
                gvExibirObjetivos.Columns[5].Width = 95;

                gvExibirObjetivos.Columns[7].HeaderText = "Sexo";
                gvExibirObjetivos.Columns[7].Width = 90;


                gvExibirObjetivos.Columns[15].HeaderText = "Login";
                gvExibirObjetivos.Columns[15].Width = 91;

                gvExibirObjetivos.Columns[2].Visible = false;
                gvExibirObjetivos.Columns[3].Visible = true;
                gvExibirObjetivos.Columns[4].Visible = false;
                gvExibirObjetivos.Columns[5].Visible = true;
                gvExibirObjetivos.Columns[6].Visible = false;
                gvExibirObjetivos.Columns[7].Visible = true;
                gvExibirObjetivos.Columns[8].Visible = false;
                gvExibirObjetivos.Columns[9].Visible = false;
                gvExibirObjetivos.Columns[10].Visible = false;
                gvExibirObjetivos.Columns[11].Visible = false;
                gvExibirObjetivos.Columns[12].Visible = false;
                gvExibirObjetivos.Columns[13].Visible = false;
                gvExibirObjetivos.Columns[14].Visible = false;
                gvExibirObjetivos.Columns[15].Visible = true;
                gvExibirObjetivos.Columns[16].Visible = false;

                dadosAlunosParaTodosFrms.CodAluno = gvExibirObjetivos.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
                gvExibirObjetivos.Visible = false;
            }

        }


        private void frmFuncObjetivos_FormClosing(object sender, FormClosingEventArgs e)
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
