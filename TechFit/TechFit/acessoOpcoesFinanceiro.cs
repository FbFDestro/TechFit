using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    
    class acessoOpcoesFinanceiro
    {
        int controlefinanceiro;

        public int Controlefinanceiro
        {
            get { return controlefinanceiro; }
            set { controlefinanceiro = value; }
        }
        int cod_op;
        double valorMatricula, valorMensalidade, descontoBi, descontoTri, descontoSeme, descontoAnual;

        public int Cod_op
        {
            get {return cod_op;}
            set { cod_op = value; }
        }
        public double ValorMatricula 
        {
            get {return valorMatricula;}
            set { valorMatricula = value; }
        }
        public double ValorMensalidade
        {
            get {return valorMensalidade;}
            set { valorMensalidade = value; }
        }
        public double DescontoBi
        {
            get {return descontoBi;}
            set { descontoBi = value; }
        }
        public double DescontoTri
        {
            get {return descontoTri;}
            set { descontoTri = value; }
        }
        public double DescontoSeme
        {
            get {return descontoSeme;}
            set { descontoSeme = value; }
        }
        public double DescontoAnual
        {
            get {return descontoAnual;}
            set { descontoAnual = value; }
        }
        
        
        // variaveis para acessar o MySql
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        // método private de acesso ao BD
        private void carregar_tabela(string comando)
        {
            
            // criar uma sacolinha vazia
            tabela_memoria = new DataTable();

            // converter um texto (string) para um comando SQL
            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            // executar o comando SQL 
            executar_comando = new MySqlCommandBuilder(comando_sql);

            // resposta que será armazenada na sacolinha
            comando_sql.Fill(tabela_memoria);
        }
       


        public void inserirOpFinanceiro(String ValorMatricula, String ValorMensalidade, String DescBimestral, String DescTrimestral, String DescSemestral, String DescAnual)
        {
            carregar_tabela("insert into opcoesFinanceiro values (0," + ValorMatricula.Replace(",", ".") + "," + ValorMensalidade.Replace(",", ".") + "," + DescBimestral.Replace(",", ".") + "," + DescTrimestral.Replace(",", ".") + "," + DescSemestral.Replace(",", ".") + "," + DescAnual.Replace(",", ".") + ");");
            
        }


        public void alterarOpFinanceiro(String ValorMatricula, String ValorMensalidade, String DescBimestral, String DescTrimestral, String DescSemestral, String DescAnual, String codOp)
        {
            carregar_tabela("update opcoesFinanceiro set valorMatricula='" + ValorMatricula.Replace(',', '.') + "', valorMensalidade='" + ValorMensalidade.Replace(',', '.') + "', descontoBi='" + DescBimestral.Replace(',', '.') + "', descontoTri='" + DescTrimestral.Replace(',', '.') + "', descontoSeme='" + DescSemestral.Replace(',', '.') + "', descontoAnual='" + DescAnual.Replace(',', '.') + "' where cod_op=" + codOp + ";");
        }

        public Boolean pesquisarOpFinanceiro()
        {
            carregar_tabela("select * from opcoesFinanceiro");

            try
            {
            cod_op = Convert.ToInt32(tabela_memoria.Rows[0]["cod_op"].ToString());
            valorMatricula = Convert.ToDouble(tabela_memoria.Rows[0]["valorMatricula"].ToString());
            valorMensalidade = Convert.ToDouble(tabela_memoria.Rows[0]["valorMensalidade"].ToString());
            descontoBi = Convert.ToDouble(tabela_memoria.Rows[0]["descontoBi"].ToString());
            descontoTri = Convert.ToDouble(tabela_memoria.Rows[0]["descontoTri"].ToString());
            descontoSeme = Convert.ToDouble(tabela_memoria.Rows[0]["descontoSeme"].ToString());
            descontoAnual = Convert.ToDouble(tabela_memoria.Rows[0]["descontoAnual"].ToString());

                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
