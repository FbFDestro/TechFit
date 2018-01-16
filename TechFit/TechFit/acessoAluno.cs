using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace TechFit
{
    class acessoAluno
    {

        int cod_aluno;

        #region Variaveis INT

     
        public int Cod_aluno
        {
            get { return cod_aluno; }
            set { cod_aluno = value; }
        }
        #endregion

        string nome_aluno, cel_aluno, email_aluno, dataNascimento_aluno, cpf_aluno, telEmergencia_aluno, sexo_aluno, pagPeriodo_aluno, pagForma_aluno, cep_aluno, endereco_aluno,
        bairro_aluno, numero_aluno, complemento_aluno, login_aluno, senha_aluno;


        #region Variaveis STRING
        public string PagPeriodo_aluno
        {
            get { return pagPeriodo_aluno; }
            set { pagPeriodo_aluno = value; }
        }

        public string PagForma_aluno
        {
            get { return pagForma_aluno; }
            set { pagForma_aluno = value; }
        }
        public string Senha_aluno
        {
            get { return senha_aluno; }
            set { senha_aluno = value; }
        }

        public string Login_aluno
        {
            get { return login_aluno; }
            set { login_aluno = value; }
        }

        public string Complemento_aluno
        {
            get { return complemento_aluno; }
            set { complemento_aluno = value; }
        }

        public string Numero_aluno
        {
            get { return numero_aluno; }
            set { numero_aluno = value; }
        }

        public string Bairro_aluno
        {
            get { return bairro_aluno; }
            set { bairro_aluno = value; }
        }

        public string Endereco_aluno
        {
            get { return endereco_aluno; }
            set { endereco_aluno = value; }
        }

        public string Cep_aluno
        {
            get { return cep_aluno; }
            set { cep_aluno = value; }
        }


        public string Sexo_aluno
        {
            get { return sexo_aluno; }
            set { sexo_aluno = value; }
        }

        public string TelEmergencia_aluno
        {
            get { return telEmergencia_aluno; }
            set { telEmergencia_aluno = value; }
        }

        public string Cpf_aluno
        {
            get { return cpf_aluno; }
            set { cpf_aluno = value; }
        }

        public string DataNascimento_aluno
        {
            get { return dataNascimento_aluno; }
            set { dataNascimento_aluno = value; }
        }

        public string Email_aluno
        {
            get { return email_aluno; }
            set { email_aluno = value; }
        }

        public string Cel_aluno
        {
            get { return cel_aluno; }
            set { cel_aluno = value; }
        }

        public string Nome_aluno
        {
            get { return nome_aluno; }
            set { nome_aluno = value; }
        }

        #endregion

        DataTable tabelaFiltro;
        public DataTable TabelaFiltro
        {
            get { return tabelaFiltro; }
            set { tabelaFiltro = value; }
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

        public bool verificarLogin(string loginV)
        {
            carregar_tabela("select * from alunos where login_aluno='" + loginV + "'");

            if (tabela_memoria.Rows.Count > 0)
            {
                return false;
            }
            else
            {

                return true;
            }
        }
        private String conversorData(String data)
        {
            DateTime dt = Convert.ToDateTime(data);

            return dt.ToString("yyyy/MM/dd");
        }

        public void cadastrarAluno(string nome, string cel, string email, string dataNasc, string cpf, string telEmer, string sexo,
       string pagPeriodo, string pagForma, string cep, string endereco, string bairro, string numero, string complemento, string login,
       string senha)
        {

            string DataCorreta = conversorData(dataNasc);

            carregar_tabela("insert into alunos values (0,'" + nome + "','" + cel + "','" + email + "','" + DataCorreta + "','" + cpf + "','" + telEmer + "','" + sexo + "','" + pagPeriodo + "','"+pagForma+"','" + cep + "','" + endereco + "', '" + bairro + "', '" + numero + "', '" + complemento + "','" + login + "', '" + senha + "');");


        }

        public DataTable listarAlunos()
        {

            carregar_tabela("select * from alunos;");
            return tabela_memoria;

        }

        public Boolean pesquisaNomeFiltro(String Pesq)
        {
            carregar_tabela("select * from alunos where nome_aluno like '" + Pesq + "%'");

            try
            {
                cod_aluno = Convert.ToInt32(tabela_memoria.Rows[0]["cod_aluno"].ToString());
                nome_aluno = tabela_memoria.Rows[0]["nome_aluno"].ToString();
                cel_aluno = tabela_memoria.Rows[0]["cel_aluno"].ToString();
                email_aluno = tabela_memoria.Rows[0]["email_aluno"].ToString();
                dataNascimento_aluno = tabela_memoria.Rows[0]["dataNascimento_aluno"].ToString();
                cpf_aluno = tabela_memoria.Rows[0]["cpf_aluno"].ToString();
                telEmergencia_aluno = tabela_memoria.Rows[0]["telEmergencia_aluno"].ToString();
                sexo_aluno = tabela_memoria.Rows[0]["sexo_aluno"].ToString();
                pagPeriodo_aluno = tabela_memoria.Rows[0]["pagPeriodo_aluno"].ToString();
                pagForma_aluno = tabela_memoria.Rows[0]["pagForma_aluno"].ToString();
                cep_aluno = tabela_memoria.Rows[0]["cep_aluno"].ToString();
                endereco_aluno = tabela_memoria.Rows[0]["endereco_aluno"].ToString();
                bairro_aluno = tabela_memoria.Rows[0]["bairro_aluno"].ToString();
                numero_aluno = tabela_memoria.Rows[0]["numero_aluno"].ToString();
                complemento_aluno = tabela_memoria.Rows[0]["complemento_aluno"].ToString();
                login_aluno = tabela_memoria.Rows[0]["login_aluno"].ToString();
                senha_aluno = tabela_memoria.Rows[0]["senha_aluno"].ToString();


                if (tabela_memoria.Rows.Count >= 1)
                {
                    tabelaFiltro = tabela_memoria;
                }
                else
                {
                    tabelaFiltro = null;
                }


                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean pesquisa(String Pesq)
        {
            carregar_tabela("select * from alunos where cod_aluno = '" + Pesq + "'");

            try
            {
                cod_aluno = Convert.ToInt32(tabela_memoria.Rows[0]["cod_aluno"].ToString());
                nome_aluno = tabela_memoria.Rows[0]["nome_aluno"].ToString();
                cel_aluno = tabela_memoria.Rows[0]["cel_aluno"].ToString();
                email_aluno = tabela_memoria.Rows[0]["email_aluno"].ToString();
                dataNascimento_aluno = tabela_memoria.Rows[0]["dataNascimento_aluno"].ToString();
                cpf_aluno = tabela_memoria.Rows[0]["cpf_aluno"].ToString();
                telEmergencia_aluno = tabela_memoria.Rows[0]["telEmergencia_aluno"].ToString();
                sexo_aluno = tabela_memoria.Rows[0]["sexo_aluno"].ToString();
                pagPeriodo_aluno = tabela_memoria.Rows[0]["pagPeriodo_aluno"].ToString();
                pagForma_aluno = tabela_memoria.Rows[0]["pagForma_aluno"].ToString();
                cep_aluno = tabela_memoria.Rows[0]["cep_aluno"].ToString();
                endereco_aluno = tabela_memoria.Rows[0]["endereco_aluno"].ToString();
                bairro_aluno = tabela_memoria.Rows[0]["bairro_aluno"].ToString();
                numero_aluno = tabela_memoria.Rows[0]["numero_aluno"].ToString();
                complemento_aluno = tabela_memoria.Rows[0]["complemento_aluno"].ToString();
                login_aluno = tabela_memoria.Rows[0]["login_aluno"].ToString();
                senha_aluno = tabela_memoria.Rows[0]["senha_aluno"].ToString();


                return true;
            }
            catch
            {
                return false;
            }
        }

        public void alterar(string nome, string cel, string email, string dataNascimento, string cpf, string telEmer,
          string sexo, string pagPeriodo, string pagForma, string cep, string endereco, string bairro, string numero, string complemento,
          string login, string senha, string cod)
        {

            string DataCorreta = conversorData(dataNascimento);

            carregar_tabela("update alunos set nome_aluno='" + nome + "',cel_aluno='" + cel + "',email_aluno='" + email +
                "', dataNascimento_aluno='" + DataCorreta + "',cpf_aluno='" + cpf + "',telEmergencia_aluno='" + telEmer + "',sexo_aluno='" + sexo +
                "',pagPeriodo_aluno='" + pagPeriodo + "', pagForma_aluno='"+pagForma+"',cep_aluno='" + cep + "', endereco_aluno='" + endereco + "',bairro_aluno='" + bairro +
                "',numero_aluno='" + numero + "',complemento_aluno='" + complemento +
                "',login_aluno='" + login +
                "',senha_aluno='" + senha + "' where cod_aluno=" + cod + ";");
        }

        public void excluir(string codPesq)
        {
            carregar_tabela("delete from alunos where cod_aluno = " + codPesq + ";");
        }



    }
}
