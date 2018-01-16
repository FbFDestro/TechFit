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
    public partial class frmCadastroDespesa : Form
    {
        acesssoLucroDespesa acessarLD = new acesssoLucroDespesa();

        public frmCadastroDespesa()
        {
            InitializeComponent();
        }

        private void lblBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty || txtValor.Text == string.Empty)
            {

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtDescricao.Text == string.Empty)
                {
                    pctrAlertDescricao.Visible = true;
                }

                if (txtValor.Text == string.Empty)
                {

                    pctrAlertValor.Visible = true;
                }

            }
            else
            {

                acessarLD.inserir(txtDescricao.Text, "Despesa", acessoDadosLogado.Nome, acessoDadosLogado.Login, "-"+txtValor.Text);
                MessageBox.Show("Despesa cadastrada com sucesso!", "Lucra Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Clear();
                txtValor.Clear();

            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            pctrAlertDescricao.Visible = false;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            pctrAlertValor.Visible = false;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
