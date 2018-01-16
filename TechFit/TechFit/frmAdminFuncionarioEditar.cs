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
    public partial class frmAdminFuncionarioEditar : Form
    {
        string sexo, tipo;
        acessoFuncionario acessarFunc = new acessoFuncionario();
        acessoCEP cep = new acessoCEP();
       
        public frmAdminFuncionarioEditar()
        {
            InitializeComponent();
        }

        private void lblBtnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == string.Empty ||
               mskdCep.MaskFull == false ||
               sexo == null ||
               mskdCpf.Text == string.Empty ||
               txtBairro.Text == string.Empty ||
               txtLogin.Text == string.Empty ||
               txtSalario.Text == string.Empty ||
               mskdNascimento.MaskFull == false || 
               tipo == null ||
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
                if (tipo == null)
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
                if (sexo == null)
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


                        try
                        {
                            acessarFunc.alterar(txtNome.Text, mskdCelular.Text, txtEmail.Text, mskdNascimento.Text, mskdCpf.Text, mskdTelefoneEmer.Text, sexo, tipo, mskdCep.Text, txtEndereco.Text, txtBairro.Text, txtNum.Text, txtComplemento.Text, txtSalario.Text, txtLogin.Text, txtSenha.Text,dadosFuncParaTodosFrms.CodFunc);

                            MessageBox.Show("Funcionário alterado com sucesso.", "Edição de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("A data digitada não é válida", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbADdeN.Visible = true;
                            mskdNascimento.Focus();

                        }
                    }

                else {

                    MessageBox.Show("A senha e confirmação não conhecidem!", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbAconfSenha.Visible = true;
                    pbASenha.Visible = true;
                    txtSenha.Focus();

                } 
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
        

        private void txtLogin_TextChanged_1(object sender, EventArgs e)
        {
            pbAlogin.Visible = false;
        }

        private void mskdCpf_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            pbACPF.Visible = false;
            lblObrigatorioCPF.Visible = true;
        }

        private void rdSexMasculino_CheckedChanged_1(object sender, EventArgs e)
        {
            pbAsexo.Visible = false;
            lblObrigatorioSexo.Visible = true;
            sexo = "Masculino";
        }

        private void rdSexFeminino_CheckedChanged_1(object sender, EventArgs e)
        {
            pbAsexo.Visible = false;
            lblObrigatorioSexo.Visible = true;
            sexo = "Feminino";
        }

        private void mskdCep_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            pbACEP.Visible = false;
        }

        private void txtBairro_TextChanged_1(object sender, EventArgs e)
        {
            pbAbairro.Visible = false;
        }

        private void txtSalario_TextChanged_1(object sender, EventArgs e)
        {
            pbASalario.Visible = false;
        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            pbANome.Visible = false;
        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {
            pbASenha.Visible = false;
        }

        private void txtConfirmacao_TextChanged_1(object sender, EventArgs e)
        {
            pbAconfSenha.Visible = false;
        }

        private void txtNum_TextChanged_1(object sender, EventArgs e)
        {
            pbANum.Visible = false;
        }

       

        private void txtEndereco_TextChanged_1(object sender, EventArgs e)
        {
            pbAendereco.Visible = false;
        }

        private void rdTipSecretario_CheckedChanged_1(object sender, EventArgs e)
        {
            pbAtipo.Visible = false;
            lblObrigatorioTipo.Visible = true;
            tipo = "Secretário";
        }

        private void rdTipInstrutor_CheckedChanged_1(object sender, EventArgs e)
        {
            pbAtipo.Visible = false;
            lblObrigatorioTipo.Visible = true;
            tipo = "Instrutor";
        }

        
        private void mskdNascimento_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            pbADdeN.Visible = false;
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void txtSalario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

        private void frmAdminFuncionarioEditar_Load(object sender, EventArgs e)
        {
            acessarFunc.pesquisa(dadosFuncParaTodosFrms.CodFunc);

            txtNome.Text = acessarFunc.Nome_func;
            txtEmail.Text = acessarFunc.Email_func;
            mskdCpf.Text = acessarFunc.Cpf_func;
            mskdCep.Text = acessarFunc.Cep_func;
            txtBairro.Text = acessarFunc.Bairro_func;
            txtSalario.Text = acessarFunc.Salario_func.ToString();
            txtLogin.Text = acessarFunc.Login_func;
            mskdCelular.Text = acessarFunc.Cel_func;
            mskdTelefoneEmer.Text = acessarFunc.TelEmergencia_func;
            mskdNascimento.Text = acessarFunc.DataNascimento_func;
            txtEndereco.Text = acessarFunc.Endereco_func;
            txtNum.Text = acessarFunc.Numero_func;
            txtComplemento.Text = acessarFunc.Complemento_func;
            txtSenha.Text = acessarFunc.Senha_func;
            txtConfirmacao.Text = acessarFunc.Senha_func;

            if (acessarFunc.Sexo_func == "Masculino") { rdSexMasculino.Checked = true; sexo = "Masculino"; } else { rdSexFeminino.Checked = true; sexo = "Feminino"; }
            if (acessarFunc.Tipo_func == "Secretário") { rdTipSecretario.Checked = true; tipo = "Secretário"; } else { rdTipInstrutor.Checked = true; tipo = "Instrutor"; }

 
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            frmAdminFuncionarios telaFuncionarios = new frmAdminFuncionarios();
            this.Hide();
            telaFuncionarios.Show();
        }

        private void frmAdminFuncionarioEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que deseja fechar o programa?", "Fechar o programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                e.Cancel = true;

            }
            else {
                Application.Exit();
            
            }
        }
        

   

       
        
    
    }
}
