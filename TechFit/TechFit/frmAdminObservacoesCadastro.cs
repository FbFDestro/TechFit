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
    public partial class frmAdminObservacoesCadastro : Form
    {
        acessoObservacoes observacoes = new acessoObservacoes();
            public frmAdminObservacoesCadastro()
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
    }
}
