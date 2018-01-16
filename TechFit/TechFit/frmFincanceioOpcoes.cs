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
    public partial class frmFincanceioOpcoes : Form
    {
        acessoOpcoesFinanceiro OpFinanceiro = new acessoOpcoesFinanceiro();
        string controle;

        public frmFincanceioOpcoes()
        {
            InitializeComponent();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar esta janela? \r\nTenha certeza de ter salvado suas alterações!", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {



                this.Close();

            }
            
            
            
        }

        private void lblBtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtValorMatricula.Text == string.Empty ||
                txtValorMensalidade.Text == string.Empty ||
                txtDescBim.Text == string.Empty ||
                txtDescTri.Text == string.Empty ||
                txtDescSem.Text == string.Empty ||
                txtDescAnu.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtValorMatricula.Text == string.Empty)
                {
                    pctrAlertMatricula.Visible = true;
                }
                if (txtValorMensalidade.Text == string.Empty)
                {
                    pctrAlertMensa.Visible = true;
                }
                if (txtDescBim.Text == string.Empty)
                {
                    pctrAlertBim.Visible = true;
                }
                if (txtDescTri.Text == string.Empty)
                {
                    pctrAlertTri.Visible = true;
                }
                if (txtDescSem.Text == string.Empty)
                {
                    pctrAlertSeme.Visible = true;
                }
                if (txtDescAnu.Text == string.Empty)
                {
                    pctrAlertDescAnual.Visible = true;
                }


            }
            else
            {
                if(controle == "Inserir")
                {
                    OpFinanceiro.inserirOpFinanceiro(txtValorMatricula.Text, txtValorMensalidade.Text, txtDescBim.Text, txtDescTri.Text, txtDescSem.Text, txtDescAnu.Text);
                    MessageBox.Show("Dados inseridos com sucesso!", "Inserir dados financeiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    OpFinanceiroVariaveis();
                    

                }
                else
                {
                    OpFinanceiro.alterarOpFinanceiro(txtValorMatricula.Text, txtValorMensalidade.Text, txtDescBim.Text, txtDescTri.Text, txtDescSem.Text, txtDescAnu.Text, "1");
                    MessageBox.Show("Dados alterados com sucesso!", "Alterar dados financeiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  
                    OpFinanceiroVariaveis();
                }
            }
        }

        private void OpFinanceiroVariaveis() {
            opcaoFinanceiraVariaveis.DescontoAnual = Convert.ToDouble(txtDescAnu.Text);
            opcaoFinanceiraVariaveis.DescontoBi = Convert.ToDouble(txtDescBim.Text);
            opcaoFinanceiraVariaveis.DescontoSeme = Convert.ToDouble(txtDescSem.Text);
            opcaoFinanceiraVariaveis.DescontoTri = Convert.ToDouble(txtDescTri.Text);
            opcaoFinanceiraVariaveis.ValorMatricula = Convert.ToDouble(txtValorMatricula.Text);
            opcaoFinanceiraVariaveis.ValorMensalidade = Convert.ToDouble(txtValorMensalidade.Text);
        }

        private void txtValorMatricula_TextChanged(object sender, EventArgs e)
        {
            pctrAlertMatricula.Visible = false;
        }

        private void txtValorMensalidade_TextChanged(object sender, EventArgs e)
        {
            pctrAlertMensa.Visible = false;
        }

        private void txtDescBim_TextChanged(object sender, EventArgs e)
        {
            pctrAlertBim.Visible = false;
        }

        private void txtDescTri_TextChanged(object sender, EventArgs e)
        {
            pctrAlertTri.Visible = false;
        }

        private void txtDescSem_TextChanged(object sender, EventArgs e)
        {
            pctrAlertSeme.Visible = false;
        }

        private void txtDescAnu_TextChanged(object sender, EventArgs e)
        {
            pctrAlertDescAnual.Visible = false;
        }

        private void txtValorMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtValorMensalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescBim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtDescAnu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void frmAdminFincanceioOpcoes_Load(object sender, EventArgs e)
        {

            if (OpFinanceiro.pesquisarOpFinanceiro() == true)
            {
                controle = "Alterar";
                txtValorMatricula.Text = OpFinanceiro.ValorMatricula.ToString();
                txtValorMensalidade.Text = OpFinanceiro.ValorMensalidade.ToString();
                txtDescBim.Text = OpFinanceiro.DescontoBi.ToString();
                txtDescTri.Text = OpFinanceiro.DescontoTri.ToString();
                txtDescSem.Text = OpFinanceiro.DescontoSeme.ToString();
                txtDescAnu.Text = OpFinanceiro.DescontoAnual.ToString();
            }
            else
            {
                controle = "Inserir";
            }

            
            
        }

        

       
 
    }
}
