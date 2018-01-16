using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace TechFit
{
    class acessoAdminCadastro
    {
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

        public bool verificarLogin(string loginV) {

            carregar_tabela("select * from administrador where login_admin='"+loginV+"'");

            if (tabela_memoria.Rows.Count > 0)
            {
                return false;
            }
            else
            {

                return true;
            }

        }

        public void cadastrarAdmin(string nome, string login, string senha) {

            carregar_tabela("insert into administrador values(0, '"+nome+"', '"+login+"', '"+senha+"')");

        
        }


    }
}
