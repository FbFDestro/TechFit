using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    class acesssoLucroDespesa
    {

        int cod_ld;
        string descricao_ld, tipo_ld, criadorNome_ld, criadorLogin_ld;
        DateTime data_ld;
        double valor;
        DataTable datald;

        public DataTable Datald
        {
            get { return datald; }
            set { datald = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime Data_ld
        {
            get { return data_ld; }
            set { data_ld = value; }
        }

        public string CriadorLogin_ld
        {
            get { return criadorLogin_ld; }
            set { criadorLogin_ld = value; }
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

        private String conversorData(String data)
        {
            DateTime dt = Convert.ToDateTime(data);

            return dt.ToString("yyyy/MM/dd");
        }

        public void inserir(string descricao, string tipo, string criadorNome, string criadorLog, string valor) {

             string dataCorreta = conversorData(DateTime.Now.ToShortDateString());

            carregar_tabela("insert into LucrosDespesas values(0, '"+descricao+"', '"+tipo+"', '"+criadorNome+"', '"+criadorLog+"', '"+dataCorreta+"', '"+valor.Replace(",",".")+"');");

        }


        public DataTable listarTudo()
        {
            carregar_tabela("select * from LucrosDespesas");
            return tabela_memoria;
        }

        public Boolean pesquisarTabelaFiltro(String pesq)
        {
            carregar_tabela("select * from LucrosDespesas where descricao_ld like '" + pesq + "%'");

            try
            {
                cod_ld = Convert.ToInt32(tabela_memoria.Rows[0]["cod_ld"].ToString());
                descricao_ld = tabela_memoria.Rows[0]["descricao_ld"].ToString();
                tipo_ld = tabela_memoria.Rows[0]["tipo_ld"].ToString();
                criadorNome_ld = tabela_memoria.Rows[0]["criadorNome_ld"].ToString();
                criadorLogin_ld = tabela_memoria.Rows[0]["criadorLogin_ld"].ToString();
                data_ld = Convert.ToDateTime(tabela_memoria.Rows[0]["data_ld"].ToString());
                valor = Convert.ToDouble(tabela_memoria.Rows[0]["valor"].ToString());

                 if (tabela_memoria.Rows.Count >= 1)
                {
                     datald = tabela_memoria;
                }
                else
                {
                     datald = null;
                }


                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
