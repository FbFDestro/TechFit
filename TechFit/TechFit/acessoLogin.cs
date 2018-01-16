using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    class acessoLogin
    {

        int cod_admin;
        string nome_admin, login_admin, senha_admin;

        int cod_func;
        string nome_func, login_func, senha_func;

        #region Variaveis Funcionario
        public int Cod_func
        {
            get { return cod_func; }
            set { cod_func = value; }
        }
        public string Senha_func
        {
            get { return senha_func; }
            set { senha_func = value; }
        }

        public string Login_func
        {
            get { return login_func; }
            set { login_func = value; }
        }

        public string Nome_func
        {
            get { return nome_func; }
            set { nome_func = value; }
        }
        #endregion
        #region Variaveis ADMIN
        public int Cod_admin
        {
            get { return cod_admin; }
            set { cod_admin = value; }
        }
        public string Senha_admin
        {
            get { return senha_admin; }
            set { senha_admin = value; }
        }

        public string Login_admin
        {
            get { return login_admin; }
            set { login_admin = value; }
        }

        public string Nome_admin
        {
            get { return nome_admin; }
            set { nome_admin = value; }
        }

        #endregion


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


        public bool loginAdmin(string login, string senha) {

            carregar_tabela("select * from administrador where login_admin='" + login + "'");

            try{

                cod_admin = Convert.ToInt32(tabela_memoria.Rows[0]["cod_admin"].ToString());
                nome_admin = tabela_memoria.Rows[0]["nome_admin"].ToString();
                login_admin = tabela_memoria.Rows[0]["login_admin"].ToString();
                senha_admin = tabela_memoria.Rows[0]["senha_admin"].ToString();

                return true;

            } catch{
                return false;
            }

        }

        public bool loginFuncionario(string login, string senha)
        {
            carregar_tabela("select * from funcionarios where login_func='" + login + "'");

            try
            {

                cod_func = Convert.ToInt32(tabela_memoria.Rows[0]["cod_func"].ToString());
                nome_func = tabela_memoria.Rows[0]["nome_func"].ToString();
                login_func = tabela_memoria.Rows[0]["login_func"].ToString();
                senha_func = tabela_memoria.Rows[0]["senha_func"].ToString();

                return true;

            }
            catch
            {
                return false;
            }

           
        }

    }
}
