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
    public partial class frmAdminObservacoes : Form
    {
        acessoObservacoes observacoes = new acessoObservacoes();

        public frmAdminObservacoes()
        {
            InitializeComponent();
        }

        private void frmAdminObservacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdminObservacoesCadastro telaAdminObservacoesCad = new frmAdminObservacoesCadastro();
            this.Hide();
            telaAdminObservacoesCad.Show();
        }

        private void frmAdminObservacoes_Load(object sender, EventArgs e)
        {
            gvExibirObs.DataSource = observacoes.listarTudo();
        }

     
    }
}
