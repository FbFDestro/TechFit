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
    public partial class frmTelaSplash : Form
    {
        acessoOpcoesFinanceiro opFin = new acessoOpcoesFinanceiro();
        acessoInicializacoes acessarInicializacoes = new acessoInicializacoes();
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void frmTelaSplash_Load(object sender, EventArgs e)
        {
            if (Conexao.criar_Conexao() == "Conectado" && Conexao2.criar_Conexao() == "Conexão OK!!!")
            {
                lblBancoConectado.Text = "BANCO DE DADOS CONECTADO";

            }
            else
            {

                lblBancoConectado.Text = "ERRO AO CONECTAR AO BANCO DE DADOS";
            }
            try
            {
                opFin.pesquisarOpFinanceiro();
                opcaoFinanceiraVariaveis.DescontoAnual = opFin.DescontoAnual;
                opcaoFinanceiraVariaveis.DescontoBi = opFin.DescontoBi;
                opcaoFinanceiraVariaveis.DescontoSeme = opFin.DescontoSeme;
                opcaoFinanceiraVariaveis.DescontoTri = opFin.DescontoTri;
                opcaoFinanceiraVariaveis.ValorMatricula = opFin.ValorMatricula;
                opcaoFinanceiraVariaveis.ValorMensalidade = opFin.ValorMensalidade;
            }
            catch{}
        }

        
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tmrSplash.Stop();

            if (acessarInicializacoes.verificarInicializacoes() == true)
            {
                MessageBox.Show("Esta é a primeira vez que você executa o software TechFit. \r\nPor favor, cadastre um administrador!","Primeira inicialização",MessageBoxButtons.OK,MessageBoxIcon.Information);


                frmAdminCadastro telaAdminCadastro = new frmAdminCadastro();
                telaAdminCadastro.ShowDialog();

                acessarInicializacoes.atualizarInicializacoes();
            }
            else {
                frmTelaLogin telaLogin = new frmTelaLogin();
                telaLogin.Show();
                acessarInicializacoes.atualizarInicializacoes();
            }



            
        }
        
    }
}
