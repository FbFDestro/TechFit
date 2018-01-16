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
    public partial class frmAdminFuncionarios : Form
    {
        acessoFuncionario acessarFunc = new acessoFuncionario();

        public frmAdminFuncionarios()
        {
            InitializeComponent();
        }

        private void frmAdminFuncionarios_Load(object sender, EventArgs e)
        {

        

            try
            {
                gvFunc.DataSource = acessarFunc.listarFunc();

                gvFunc.Columns[0].HeaderText = "Número de Matricula";
                gvFunc.Columns[0].Width = 135;

                gvFunc.Columns[1].HeaderText = "Nome do Funcionário";
                gvFunc.Columns[1].Width = 160;


                gvFunc.Columns[5].HeaderText = "CPF";
                gvFunc.Columns[5].Width = 100;

                gvFunc.Columns[8].HeaderText = "Tipo";
                gvFunc.Columns[8].Width = 100;

                gvFunc.Columns[14].HeaderText = "Salário (R$)";
                gvFunc.Columns[14].Width = 100;

                gvFunc.Columns[15].HeaderText = "Login";
                gvFunc.Columns[15].Width = 100;

                gvFunc.Columns[2].Visible = false;
                gvFunc.Columns[3].Visible = false;
                gvFunc.Columns[4].Visible = false;
                gvFunc.Columns[5].Visible = true;
                gvFunc.Columns[6].Visible = false;
                gvFunc.Columns[7].Visible = false;
                gvFunc.Columns[8].Visible = true;
                gvFunc.Columns[9].Visible = false;
                gvFunc.Columns[10].Visible = false;
                gvFunc.Columns[11].Visible = false;
                gvFunc.Columns[12].Visible = false;
                gvFunc.Columns[13].Visible = false;
                gvFunc.Columns[14].Visible = true;
                gvFunc.Columns[15].Visible = true;
                gvFunc.Columns[16].Visible = false;

                dadosFuncParaTodosFrms.CodFunc = gvFunc.Rows[0].Cells[0].Value.ToString();
            }
            catch {

                gvFunc.Visible = false;
                lblBtnEditar.Enabled = false;
                lblBtnDeletar.Enabled = false;
            }

            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            acessarFunc.pesquisaNomeFiltro(txtPesquisar.Text);

            gvFunc.DataSource = acessarFunc.TabelaFiltro;

          
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
        }



        private void lblBtnEditar_Click(object sender, EventArgs e)
        {
         
                frmAdminFuncionarioEditar funcEditar = new frmAdminFuncionarioEditar();
                funcEditar.Show();
                this.Hide();
            
            
        }

        private void gvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = Convert.ToInt32(gvFunc.CurrentCell.RowIndex.ToString());

            dadosFuncParaTodosFrms.CodFunc = gvFunc.Rows[i].Cells[0].Value.ToString();
        }

        private void lblBtnDeletar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir este funcionário?", "Excluir funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                acessarFunc.excluir(dadosFuncParaTodosFrms.CodFunc);
                MessageBox.Show("Funcionário excluido com sucesso!","Funcionário excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    gvFunc.DataSource = acessarFunc.listarFunc();
                    dadosFuncParaTodosFrms.CodFunc = gvFunc.Rows[0].Cells[0].Value.ToString();
                }
                catch {
                    lblBtnEditar.Enabled = false;
                    lblBtnDeletar.Enabled = false;
                
                }
            
            }
            else {

                MessageBox.Show("A exclusão do funcionário foi cancelada!", "Exclusão cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }

        }

        private void lblBtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdminFuncionariosCadastro telaFuncionariosCadastro = new frmAdminFuncionariosCadastro();
            this.Hide();
            telaFuncionariosCadastro.Show();
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            frmAdminPrincipal telaAdminPrincipal = new frmAdminPrincipal();
            this.Hide();
            telaAdminPrincipal.Show();
        }

        private void frmAdminFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
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
