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
    public partial class frmObservacoesCadastro : Form
    {
        acessoObservacoes observacoes = new acessoObservacoes();
            public frmObservacoesCadastro()
        {
            InitializeComponent();
        }

        private void lblBtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtAssunto.Text == string.Empty ||
                txtObs.Text == string.Empty ||
                cmbPrioridade.Text == string.Empty
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatorios vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtAssunto.Text == string.Empty)
                {
                    pbAassunto.Visible = true;
                }
                if (txtObs.Text == string.Empty)
                {
                    pbAobservacao.Visible = true;
                }
                if (cmbPrioridade.Text == string.Empty)
                {
                    pbAprioridade.Visible = true;
                }

            }
            else {

                observacoes.inserir(acessoDadosLogado.Nome, acessoDadosLogado.Tipo, txtAssunto.Text, txtObs.Text, cmbPrioridade.Text);
                MessageBox.Show("Observação cadastrada com sucesso!","Observação cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Observações telaObs = new Observações();
                telaObs.Show();
            }

        }

        private void txtAssunto_TextChanged(object sender, EventArgs e)
        {
            pbAassunto.Visible = false;
        }

        private void cmbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbAprioridade.Visible = false;
        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {
            pbAobservacao.Visible = false;
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            Observações telaObservacoes = new Observações();
            this.Hide();
            telaObservacoes.Show();
        }

   
        private void frmObservacoesCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar o programa?", "Fechar o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();

            } 
        }

        private void frmObservacoesCadastro_FormClosing(object sender, FormClosingEventArgs e)
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
