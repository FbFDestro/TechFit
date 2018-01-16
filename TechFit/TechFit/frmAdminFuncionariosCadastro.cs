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
    public partial class frmAdminFuncionariosCadastro : Form
    {
        string sexo, tipo;
        acessoFuncionario acessarFuncCad = new acessoFuncionario();
        acessoCEP cep = new acessoCEP();

        public frmAdminFuncionariosCadastro()
        {
            InitializeComponent();
        }

        private void lblBtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty ||
               mskdCep.MaskFull == false ||
               rdSexFeminino.Checked == false && rdSexMasculino.Checked == false ||
               mskdCpf.Text == string.Empty ||
               txtBairro.Text == string.Empty ||
               txtLogin.Text == string.Empty ||
               txtSalario.Text == string.Empty ||
               mskdNascimento.MaskFull == false ||
               rdTipInstrutor.Checked == false && rdTipSecretario.Checked == false ||
               txtEndereco.Text == string.Empty ||
               txtNum.Text == string.Empty ||
               txtSenha.Text == string.Empty ||
               txtConfirmacao.Text == string.Empty)
            {

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(txtSalario.Text == string.Empty)
                {
                    pbASalario.Visible = true;
                }
                if (rdTipInstrutor.Checked == false && rdTipSecretario.Checked == false)
                {
                    pbAtipo.Visible = true;
                    lblObrigatorioTipo.Visible = false;
                }
                if (txtNome.Text == string.Empty)
                {
                    pbANome.Visible = true;
                }
              
                if (mskdCpf.MaskFull == false)
                {
                    pbACPF.Visible = true;
                    lblObrigatorioCPF.Visible = false;
                }
                if (rdSexFeminino.Checked == false && rdSexMasculino.Checked == false)
                {
                    pbAsexo.Visible = true;
                    lblObrigatorioSexo.Visible = false;
                }
                if (mskdCep.MaskFull == false)
                {
                    pbACEP.Visible = true;
                }
                if (txtBairro.Text == string.Empty)
                {
                    pbAbairro.Visible = true;
                }
                if (txtLogin.Text == string.Empty)
                {
                    pbAlogin.Visible = true;
                }
                if (mskdNascimento.MaskFull == false)
                {
                    pbADdeN.Visible = true;
                }
                if (txtEndereco.Text == string.Empty)
                {
                    pbAendereco.Visible = true;
                }
                if (txtNum.Text == string.Empty)
                {
                    pbANum.Visible = true;
                }
                if (txtSenha.Text == string.Empty)
                {
                    pbASenha.Visible = true;
                }
                if (txtConfirmacao.Text == string.Empty)
                {
                    pbAconfSenha.Visible = true;
                }
            }

            else
            {
                if (txtSenha.Text == txtConfirmacao.Text)
                {

                    if (acessarFuncCad.verificarLogin(txtLogin.Text) == false)
                    {

                        MessageBox.Show("O nome de usuário escolhido (Login) já existe. \r\nPor favor, digite outro!", "Login já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbAlogin.Visible = true;
                        txtLogin.Focus();

                    }
                    else
                    {

                        try
                        {
                            acessarFuncCad.cadastrarFunc(txtNome.Text, mskdCelular.Text, txtEmail.Text, mskdNascimento.Text, mskdCpf.Text, mskdTelefoneEmer.Text, sexo, tipo, mskdCep.Text, txtEndereco.Text, txtBairro.Text, txtNum.Text, txtComplemento.Text, txtSalario.Text, txtLogin.Text, txtSenha.Text);

                            MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAdminFuncionarios telaFunc = new frmAdminFuncionarios();
                            this.Hide();
                            telaFunc.Show();

                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("A data digitada não é válida", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbADdeN.Visible = true;
                            mskdNascimento.Focus();

                        }
                    }


                }
                else {

                    MessageBox.Show("A senha e confirmação não coincidem!", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbAconfSenha.Visible = true;
                    pbASenha.Visible = true;
                    txtSenha.Focus();

                } 
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            pbANome.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mskdCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbACPF.Visible = false;
            lblObrigatorioCPF.Visible = true;
        }

        private void rdSexMasculino_CheckedChanged(object sender, EventArgs e)
        {
            pbAsexo.Visible = false;
            lblObrigatorioSexo.Visible = true;
            sexo = "Masculino";
        }

        private void rdSexFeminino_CheckedChanged(object sender, EventArgs e)
        {
            pbAsexo.Visible = false;
            lblObrigatorioSexo.Visible = true;
            sexo = "Feminino";
        }

        private void mskdCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbACEP.Visible = false;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            pbAbairro.Visible = false;
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            pbASalario.Visible = false;

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            pbAlogin.Visible = false;
        }

        private void mskdNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbADdeN.Visible = false;
        }

        private void rdTipSecretario_CheckedChanged(object sender, EventArgs e)
        {
            pbAtipo.Visible = false;
            lblObrigatorioTipo.Visible = true;
            tipo = "Secretário";
        }

        private void rdTipInstrutor_CheckedChanged(object sender, EventArgs e)
        {
            pbAtipo.Visible = false;
            lblObrigatorioTipo.Visible = true;
            tipo = "Instrutor";
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            pbAendereco.Visible = false;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            pbANum.Visible = false;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            pbASenha.Visible = false;
        }

        private void txtConfirmacao_TextChanged(object sender, EventArgs e)
        {
            pbAconfSenha.Visible = false;
        }

        private void frmAdminFuncionariosCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar !='.')
            {
                e.Handled = true;
            }
        }


        public String limparCEP(String cep)
        {
            String tmp;

            tmp = cep.Remove(2, 1);

            tmp = tmp.Remove(5, 1);

            return tmp;
        }

        public void limCep()
        {
            txtBairro.Clear();
            txtComplemento.Clear();
            txtNum.Clear();
            txtEndereco.Clear();

        }
        private void mskdCep_TextChanged(object sender, EventArgs e)
        {
            mskdCep.BackColor = Color.White;
            // para cep's existentes
            if (mskdCep.MaskFull == true && mskdCep.Text != "00.000-000")
            {
                if (cep.buscaEndereco(limparCEP(mskdCep.Text)) == true)
                {

                    txtEndereco.Text = cep.Logradouro;

                    txtBairro.Text = cep.Bairro;

                    dadosCEP.ZonaRural = "S";
                }
                else
                {
                    limCep();
                }
            }
            else
            {
                // para cep's de zona rural
                if (mskdCep.Text != "  .   -" && mskdCep.Text != "00.000-000")
                {
                    if (cep.buscaEndereco(limparCEP(mskdCep.Text)) == true)
                    {
                        txtEndereco.Text = cep.Logradouro;
                        txtBairro.Text = cep.Bairro;
                        mskdCep.Text = "00.000-000";

                    }
                    else
                    {
                        limCep();
                    }
                }
            }
        }

        private void lnkCep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTelaBuscaCEP tela = new frmTelaBuscaCEP();
            tela.ShowDialog();
            if (dadosCEP.ZonaRural == "S")
                mskdCep.Text = dadosCEP.Cep;
            else
            {
                mskdCep.Text = "00.000-000";
            }

            txtNum.Text = dadosCEP.Num;
            txtComplemento.Text = dadosCEP.Comple;
            txtBairro.Text = dadosCEP.Bairro;
            txtEndereco.Text = dadosCEP.Rua;
    

        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            frmAdminFuncionarios telaFuncionarios = new frmAdminFuncionarios();
            this.Hide();
            telaFuncionarios.Show();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void frmAdminFuncionariosCadastro_FormClosing(object sender, FormClosingEventArgs e)
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
