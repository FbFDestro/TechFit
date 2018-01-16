using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    class acessoFuncionario
    {


        int cod_func;

        #region Variaveis INT

        public int Cod_func
        {
            get { return cod_func; }
            set { cod_func = value; }
        }
        #endregion

        string nome_func, cel_func, email_func, dataNascimento_func, cpf_func, telEmergencia_func, sexo_func, tipo_func, cep_func, endereco_func,
        bairro_func, numero_func, complemento_func, login_func, senha_func;

        #region Variaveis STRING

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

        public string Complemento_func
        {
            get { return complemento_func; }
            set { complemento_func = value; }
        }

        public string Numero_func
        {
            get { return numero_func; }
            set { numero_func = value; }
        }

        public string Bairro_func
        {
            get { return bairro_func; }
            set { bairro_func = value; }
        }

        public string Endereco_func
        {
            get { return endereco_func; }
            set { endereco_func = value; }
        }

        public string Cep_func
        {
            get { return cep_func; }
            set { cep_func = value; }
        }

        public string Tipo_func
        {
            get { return tipo_func; }
            set { tipo_func = value; }
        }

        public string Sexo_func
        {
            get { return sexo_func; }
            set { sexo_func = value; }
        }

        public string TelEmergencia_func
        {
            get { return telEmergencia_func; }
            set { telEmergencia_func = value; }
        }

        public string Cpf_func
        {
            get { return cpf_func; }
            set { cpf_func = value; }
        }

        public string DataNascimento_func
        {
            get { return dataNascimento_func; }
            set { dataNascimento_func = value; }
        }

        public string Email_func
        {
            get { return email_func; }
            set { email_func = value; }
        }

        public string Cel_func
        {
            get { return cel_func; }
            set { cel_func = value; }
        }

        public string Nome_func
        {
            get { return nome_func; }
            set { nome_func = value; }
        }

        #endregion

        double salario_func;

        #region Variaveis DOUBLE

        public double Salario_func
        {
            get { return salario_func; }
            set { salario_func = value; }
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

/*
        	cod_func INT(10) NOT NULL AUTO_INCREMENT,
	nome_func VARCHAR(60) NOT NULL,
	cel_func VARCHAR(10) NULL,
	email_func VARCHAR(200) NULL,
	dataNascimento_func DATETIME NOT NULL,
	cpf_func VARCHAR(11) NOT NULL,
	telEmergencia_func VARCHAR(10) NULL,
	sexo_func VARCHAR(9) NOT NULL,
	tipo_func VARCHAR(20) NOT NULL,
	cep_func VARCHAR(8) NOT NULL,
	endereco_func VARCHAR(60) NOT NULL,
	bairro_func VARCHAR(50) NOT NULL,
	numero_func VARCHAR(4) NOT NULL,
	complemento_func VARCHAR(4) NULL,
	salario_func FLOAT(8) NULL,
	login_func VARCHAR(20) NOT NULL,
	senha_func VARCHAR(20) NOT NULL,    string , string , string ,
        primeiroLogin_func INT(1) NOT NULL,

 */


        public bool verificarLogin(string loginV) {
            carregar_tabela("select * from funcionarios where login_func='"+loginV+"'");

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

        public void cadastrarFunc(string nome, string cel, string email, string dataNasc, string cpf, string telEmer, string sexo, 
        string tipo, string cep, string endereco, string bairro, string numero, string complemento, string salario, string login, 
        string senha )
        {

     string DataCorreta = conversorData(dataNasc);

            carregar_tabela("insert into funcionarios values (0,'"+nome+"','"+cel+"','"+email+"','"+DataCorreta+"','"+cpf+"','"+telEmer+"','"+sexo+"','"+tipo+"','"+cep+"','"+endereco+"', '"+bairro+"', '"+numero+"', '"+complemento+"','"+salario.Replace(",",".")+"','"+login+"', '"+senha+"');");


        }

        public DataTable listarFunc() {

            carregar_tabela("select * from funcionarios;");
            return tabela_memoria;

        }

        public Boolean pesquisaNomeFiltro(String Pesq)
        {
            carregar_tabela("select * from funcionarios where nome_func like '" + Pesq + "%'");

            try
            {
                cod_func = Convert.ToInt32(tabela_memoria.Rows[0]["cod_func"].ToString());
                nome_func = tabela_memoria.Rows[0]["nome_func"].ToString();
                cel_func = tabela_memoria.Rows[0]["cel_func"].ToString();
                email_func = tabela_memoria.Rows[0]["email_func"].ToString();
                dataNascimento_func = tabela_memoria.Rows[0]["dataNascimento_func"].ToString();
                cpf_func = tabela_memoria.Rows[0]["cpf_func"].ToString();
                telEmergencia_func = tabela_memoria.Rows[0]["telEmergencia_func"].ToString();
                sexo_func = tabela_memoria.Rows[0]["sexo_func"].ToString();
                tipo_func = tabela_memoria.Rows[0]["tipo_func"].ToString();
                cep_func = tabela_memoria.Rows[0]["cep_func"].ToString();
                endereco_func = tabela_memoria.Rows[0]["endereco_func"].ToString();
                bairro_func = tabela_memoria.Rows[0]["bairro_func"].ToString();
                numero_func = tabela_memoria.Rows[0]["numero_func"].ToString();
                complemento_func = tabela_memoria.Rows[0]["complemento_func"].ToString();
                salario_func = Convert.ToDouble(tabela_memoria.Rows[0]["salario_func"].ToString());
                login_func = tabela_memoria.Rows[0]["login_func"].ToString();
                senha_func = tabela_memoria.Rows[0]["senha_func"].ToString();
               

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
            carregar_tabela("select * from funcionarios where cod_func = '" + Pesq + "'");

            try
            {
                cod_func = Convert.ToInt32(tabela_memoria.Rows[0]["cod_func"].ToString());
                nome_func = tabela_memoria.Rows[0]["nome_func"].ToString();
                cel_func = tabela_memoria.Rows[0]["cel_func"].ToString();
                email_func = tabela_memoria.Rows[0]["email_func"].ToString();
                dataNascimento_func = tabela_memoria.Rows[0]["dataNascimento_func"].ToString();
                cpf_func = tabela_memoria.Rows[0]["cpf_func"].ToString();
                telEmergencia_func = tabela_memoria.Rows[0]["telEmergencia_func"].ToString();
                sexo_func = tabela_memoria.Rows[0]["sexo_func"].ToString();
                tipo_func = tabela_memoria.Rows[0]["tipo_func"].ToString();
                cep_func = tabela_memoria.Rows[0]["cep_func"].ToString();
                endereco_func = tabela_memoria.Rows[0]["endereco_func"].ToString();
                bairro_func = tabela_memoria.Rows[0]["bairro_func"].ToString();
                numero_func = tabela_memoria.Rows[0]["numero_func"].ToString();
                complemento_func = tabela_memoria.Rows[0]["complemento_func"].ToString();
                salario_func = Convert.ToDouble(tabela_memoria.Rows[0]["salario_func"].ToString());
                login_func = tabela_memoria.Rows[0]["login_func"].ToString();
                senha_func = tabela_memoria.Rows[0]["senha_func"].ToString();

               
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void alterar(string nome, string cel, string email, string dataNascimento, string cpf, string telEmer,
            string sexo, string tipo, string cep, string endereco, string bairro, string numero, string complemento, string salario,
            string login, string senha, string cod)
        {

            string DataCorreta = conversorData(dataNascimento);

            carregar_tabela("update funcionarios set nome_func='" + nome + "',cel_func='" + cel + "',email_func='" + email +
                "', dataNascimento_func='" + DataCorreta + "',cpf_func='" + cpf + "',telEmergencia_func='" + telEmer + "',sexo_func='" + sexo +
                "',tipo_func='" + tipo + "',cep_func='" + cep + "', endereco_func='" + endereco + "',bairro_func='" + bairro +
                "',numero_func='" + numero + "',complemento_func='" + complemento +
                "',salario_func='" + salario.Replace(",", ".") + "',login_func='" + login +
                "',senha_func='" + senha + "' where cod_func=" + cod + ";");
        }

        public void excluir(string codPesq)
        {
            carregar_tabela("delete from funcionarios where cod_func = " + codPesq + ";");
        }

    }
}
