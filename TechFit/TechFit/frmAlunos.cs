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
    public partial class frmAlunos : Form
    {

        acessoAluno acessarAluno = new acessoAluno();
        public frmAlunos()
        {
            InitializeComponent();
        }


        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void frmAdminAlunos_Load(object sender, EventArgs e)
        {
            try
            {
                gvExibir.DataSource = acessarAluno.listarAlunos();

                gvExibir.Columns[0].HeaderText = "Número de Matricula";
                gvExibir.Columns[0].Width = 140;

                gvExibir.Columns[1].HeaderText = "Nome do Aluno";
                gvExibir.Columns[1].Width = 140;

                gvExibir.Columns[3].HeaderText = "E-mail";
                gvExibir.Columns[3].Width = 140;

                gvExibir.Columns[5].HeaderText = "CPF";
                gvExibir.Columns[5].Width = 95;

                gvExibir.Columns[7].HeaderText = "Sexo";
                gvExibir.Columns[7].Width = 90;


                gvExibir.Columns[15].HeaderText = "Login";
                gvExibir.Columns[15].Width = 91;

                gvExibir.Columns[2].Visible = false;
                gvExibir.Columns[3].Visible = true;
                gvExibir.Columns[4].Visible = false;
                gvExibir.Columns[5].Visible = true;
                gvExibir.Columns[6].Visible = false;
                gvExibir.Columns[7].Visible = true;
                gvExibir.Columns[8].Visible = false;
                gvExibir.Columns[9].Visible = false;
                gvExibir.Columns[10].Visible = false;
                gvExibir.Columns[11].Visible = false;
                gvExibir.Columns[12].Visible = false;
                gvExibir.Columns[13].Visible = false;
                gvExibir.Columns[14].Visible = false;
                gvExibir.Columns[15].Visible = true;
                gvExibir.Columns[16].Visible = false;

                dadosAlunosParaTodosFrms.CodAluno = gvExibir.Rows[0].Cells[0].Value.ToString();
            }
            catch
            {
                gvExibir.Visible = false;
                lblBtnEditar.Enabled = false;
                lblBtnExcluir.Enabled = false;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            acessarAluno.pesquisaNomeFiltro(txtPesquisar.Text);

            gvExibir.DataSource = acessarAluno.TabelaFiltro;
        }



        private void lblBtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAlunosCadastro telaAlunosCadastro = new frmAlunosCadastro();
            this.Hide();
            telaAlunosCadastro.Show();
        }

        private void lblBtnEditar_Click(object sender, EventArgs e)
        {
            frmAlunoEditar telaAlunoEditar = new frmAlunoEditar();
            telaAlunoEditar.Show();
            this.Hide();
        }

        private void lblBtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este aluno?", "Excluir aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                acessarAluno.excluir(dadosAlunosParaTodosFrms.CodAluno);
                MessageBox.Show("Aluno excluido com sucesso!", "Aluno excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                try
                {
                    dadosAlunosParaTodosFrms.CodAluno = gvExibir.Rows[0].Cells[0].Value.ToString();
                    gvExibir.DataSource = acessarAluno.listarAlunos();
                }
                catch
                {

                    lblBtnEditar.Enabled = false;
                    lblBtnExcluir.Enabled = false;

                }
                }
            else
            {

                MessageBox.Show("A exclusão do aluno foi cancelada!", "Exclusão cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gvExibir_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = Convert.ToInt32(gvExibir.CurrentCell.RowIndex.ToString());

            dadosAlunosParaTodosFrms.CodAluno = gvExibir.Rows[i].Cells[0].Value.ToString();
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

        private void frmAlunos_FormClosing(object sender, FormClosingEventArgs e)
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
