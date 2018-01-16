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
    public partial class frmAlunoEditar : Form
    {
        string sexo;
        acessoCEP cep = new acessoCEP();
        acessoAluno acessarAluno = new acessoAluno();
        public frmAlunoEditar()
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
              mskdNascimento.MaskFull == false ||
              cmbPagPeriodo.Text == string.Empty ||
              cmbPagForma.Text == string.Empty ||
              txtEndereco.Text == string.Empty ||
              txtNum.Text == string.Empty ||
              txtSenha.Text == string.Empty ||
              txtConfirmacao.Text == string.Empty)
            {

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtNome.Text == string.Empty)
                {
                    pbANome.Visible = true;
                }
                if (mskdCpf.MaskFull == false)
                {
                    pbACPF.Visible = true;
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
                if (cmbPagPeriodo.Text == string.Empty)
                {
                    pbAPagPeriodo.Visible = true;
                }
                if (cmbPagForma.Text == string.Empty)
                {
                    pbAPagForma.Visible = true;
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
                            acessarAluno.alterar(txtNome.Text, mskdCelular.Text, txtEmail.Text, mskdNascimento.Text, mskdCpf.Text, mskdTelefoneEmer.Text, sexo, cmbPagPeriodo.Text,cmbPagForma.Text, mskdCep.Text, txtEndereco.Text, txtBairro.Text, txtNum.Text, txtComplemento.Text, txtLogin.Text, txtSenha.Text,dadosAlunosParaTodosFrms.CodAluno);

                            MessageBox.Show("Aluno alterado com sucesso.", "Edição de Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAlunos telaAlunos = new frmAlunos();
                            this.Close();
                            telaAlunos.Show();

                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("A data digitada não é válida", "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbADdeN.Visible = true;
                            mskdNascimento.Focus();

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

        private void mskdCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbACPF.Visible = false;
        }

        private void rdSexMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
            lblObrigatorioSexo.Visible = true;
            pbAsexo.Visible = false;
        }

        private void rdSexFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
            lblObrigatorioSexo.Visible = true;
            pbAsexo.Visible = false;
        }

        private void mskdCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbACEP.Visible = false;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            pbAbairro.Visible = false;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            pbAlogin.Visible = false;
        }

        private void mskdNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            pbADdeN.Visible = false;
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


        private void cmbPagForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbAPagForma.Visible = false;
        }


        private void cmbPagPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbAPagPeriodo.Visible = false;

            pbAPagPeriodo.Visible = false;
            if (cmbPagPeriodo.Text == "Bimestral")
            {
                lblResumo2.Text = " Bimestral - %" + opcaoFinanceiraVariaveis.DescontoBi + " de desconto";
            }
            else if (cmbPagPeriodo.Text == "Trimestral")
            {
                lblResumo2.Text = " Trimestral - %" + opcaoFinanceiraVariaveis.DescontoTri + " de desconto";
            }
            else if (cmbPagPeriodo.Text == "Semestral")
            {
                lblResumo2.Text = " Semestral - %" + opcaoFinanceiraVariaveis.DescontoSeme + " de desconto";
            }
            else if (cmbPagPeriodo.Text == "Anual")
            {
                lblResumo2.Text = " Anual - %" + opcaoFinanceiraVariaveis.DescontoAnual + " de desconto";
            }
            else if (cmbPagPeriodo.Text == "Mensal")
            {
                lblResumo2.Text = string.Empty;
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

        private void mskdCep_TextChanged_1(object sender, EventArgs e)
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

        private void frmAdminAlunoEditar_Load(object sender, EventArgs e)
        {
            lblResumo1.Text = lblResumo1.Text + opcaoFinanceiraVariaveis.ValorMatricula + " Mensalidade: R$ " + opcaoFinanceiraVariaveis.ValorMensalidade;
      

            acessarAluno.pesquisa(dadosAlunosParaTodosFrms.CodAluno);

            txtNome.Text = acessarAluno.Nome_aluno;
            txtEmail.Text = acessarAluno.Email_aluno;
            mskdCpf.Text = acessarAluno.Cpf_aluno;
            mskdCep.Text = acessarAluno.Cep_aluno;
            txtBairro.Text = acessarAluno.Bairro_aluno;
            cmbPagPeriodo.Text = acessarAluno.PagPeriodo_aluno;
            cmbPagForma.Text = acessarAluno.PagForma_aluno;
            txtLogin.Text = acessarAluno.Login_aluno;
            mskdCelular.Text = acessarAluno.Cel_aluno;
            mskdTelefoneEmer.Text = acessarAluno.TelEmergencia_aluno;
            mskdNascimento.Text = acessarAluno.DataNascimento_aluno;
            txtEndereco.Text = acessarAluno.Endereco_aluno;
            txtNum.Text = acessarAluno.Numero_aluno;
            txtComplemento.Text = acessarAluno.Complemento_aluno;
            txtSenha.Text = acessarAluno.Senha_aluno;
            txtConfirmacao.Text = acessarAluno.Senha_aluno;

            if (acessarAluno.Sexo_aluno == "Masculino") { rdSexMasculino.Checked = true; sexo = "Masculino"; } else { rdSexFeminino.Checked = true; sexo = "Feminino"; }
            
 
        }

        private void pctVoltar_Click(object sender, EventArgs e)
        {
            frmAlunos telaAlunos = new frmAlunos();
            this.Close();
            telaAlunos.Show();
        }


        private void frmAlunoEditar_FormClosing(object sender, FormClosingEventArgs e)
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
