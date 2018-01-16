using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    class acessoFuncionariosObjetivos
    {
        int cod_objetivo;

        public int Cod_objetivo
        {
            get { return cod_objetivo; }
            set { cod_objetivo = value; }
        }

        double peso, meta_peso, altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Meta_peso
        {
            get { return meta_peso; }
            set { meta_peso = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        string estilo;

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

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

        public void inserir(String peso,String altura,String metaPeso,String estilo)
        {
            carregar_tabela("insert into Objetivos values(0,'" + peso.Replace(',', '.') + "','" + altura.Replace(',', '.') + "','" + metaPeso.Replace(',', '.') + "','" + estilo + "')");
        }

        public void alterarObjetivo(String peso, String altura, String metaPeso, String estilo, String codObj)
        {
            carregar_tabela("update Objetivos set peso='" + peso.Replace(',', '.') + "', altura='" + altura.Replace(',', '.') + "', meta_peso='" + metaPeso.Replace(',', '.') + "', estilo='" + estilo + "' where cod_objetivo =" + codObj + ";");
        }

        public Boolean pesquisar(String Pesq)
        {
            try
            {
                carregar_tabela("select * from Objetivos where cod_objetivo='"+Pesq+"'");

                cod_objetivo = Convert.ToInt32(tabela_memoria.Rows[0]["cod_objetivo"].ToString());
                altura = Convert.ToDouble(tabela_memoria.Rows[0]["altura"].ToString());
                meta_peso = Convert.ToDouble(tabela_memoria.Rows[0]["meta_peso"].ToString());
                peso = Convert.ToDouble(tabela_memoria.Rows[0]["peso"].ToString());
                estilo = tabela_memoria.Rows[0]["estilo"].ToString();

         

                return true;
            }
            catch
            {
                return false;

            }
        }

        


    }
}
