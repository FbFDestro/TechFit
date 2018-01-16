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
    public partial class frmObjetivosCadastro : Form
    {
        acessoFuncionariosObjetivos Objetivos = new acessoFuncionariosObjetivos();
        acessoAluno aluno = new acessoAluno();

        string controle;
        public frmObjetivosCadastro()
        {
            InitializeComponent();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            pctPeso.Visible = false;
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            pctAltura.Visible = false;
        }

        private void txtMetaPeso_TextChanged(object sender, EventArgs e)
        {
            pctMetaPeso.Visible = false;
        }

        private void cmbEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pctEstilo.Visible = false;
        }

        private void objetivosVariaveis()
        {
            opcaoDadosObjetivosVariaveis.Altura = Convert.ToDouble(txtAltura.Text);
            opcaoDadosObjetivosVariaveis.Estilo = cmbEstilo.Text;
            opcaoDadosObjetivosVariaveis.Meta_peso = Convert.ToDouble(txtMetaPeso.Text);
            opcaoDadosObjetivosVariaveis.Peso = Convert.ToDouble(txtPeso.Text);
        }

        private void lblBtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar esta janela? \r\nTenha certeza de ter salvado suas alterações!", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {



                this.Close();

            }

        }

        private void frmObjetivosCadastro_Load(object sender, EventArgs e)
        {



            if (Objetivos.pesquisar(dadosAlunosParaTodosFrms.CodAluno) == true)
            {

                controle = "Alterar";
                txtPeso.Text = Objetivos.Peso.ToString();
                txtAltura.Text = Objetivos.Altura.ToString();
                txtMetaPeso.Text = Objetivos.Meta_peso.ToString();
                cmbEstilo.Text = Objetivos.Estilo;
            }
            else
            {

                controle = "Inserir";

            }
        }

        private void lblBtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text == string.Empty ||
               txtMetaPeso.Text == string.Empty ||
               txtAltura.Text == string.Empty ||
               cmbEstilo.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (txtPeso.Text == string.Empty)
                {
                    pctPeso.Visible = true;
                }

                if (txtMetaPeso.Text == string.Empty)
                {
                    pctMetaPeso.Visible = true;
                }

                if (txtAltura.Text == string.Empty)
                {
                    pctAltura.Visible = true;
                }

                if (cmbEstilo.Text == string.Empty)
                {
                    pctEstilo.Visible = true;
                }

            }
            else
            {
                if (controle == "Inserir")
                {
                    Objetivos.inserir(txtPeso.Text, txtAltura.Text, txtMetaPeso.Text, cmbEstilo.Text);
                    MessageBox.Show("Dados Inseridos com sucesso!!!", "Inserir Dados Financeiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    objetivosVariaveis();
                }
                else
                {

                    Objetivos.alterarObjetivo(txtPeso.Text, txtAltura.Text, txtMetaPeso.Text, cmbEstilo.Text, dadosAlunosParaTodosFrms.CodAluno);
                    MessageBox.Show("Dados Alterados com sucesso!!!", "Alterar Dados Financeiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    objetivosVariaveis();
                }
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMetaPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
