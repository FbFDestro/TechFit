using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace TechFit
{
    class acessoObservacoes
    {

        int cod_obs;
        string nomeDono_obs, tipoDonoObs, assunto_obs, mensagem_obs, prioridade_obs;
        DateTime dataHora_obs;

        public DateTime DataHora_obs
        {
            get { return dataHora_obs; }
            set { dataHora_obs = value; }
        }

        public string NomeDono_obs
        {
            get { return nomeDono_obs; }
            set { nomeDono_obs = value; }
        }

        public string TipoDonoObs
        {
            get { return tipoDonoObs; }
            set { tipoDonoObs = value; }
        }

        public string Assunto_obs
        {
            get { return assunto_obs; }
            set { assunto_obs = value; }
        }

        public string Mensagem_obs
        {
            get { return mensagem_obs; }
            set { mensagem_obs = value; }
        }

        public string Prioridade_obs
        {
            get { return prioridade_obs; }
            set { prioridade_obs = value; }
        }

        public int Cod_obs
        {
            get { return cod_obs; }
            set { cod_obs = value; }
        }

        DataTable tabelaFilto;

        public DataTable TabelaFilto
        {
            get { return tabelaFilto; }
            set { tabelaFilto = value; }
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

        public void inserir(String nomeDono, String tipoDono, String assunto, String mensagem, String prioridade)
        {
            string dataCorreta = conversorData(DateTime.Now.ToShortDateString());

            carregar_tabela("insert into observacoes values(0,'" + nomeDono + "','" + tipoDono + "','" + assunto + "','" + mensagem + "','" + prioridade + "','" + dataCorreta + "')");
        }

        public DataTable listarTudo()
        {
            carregar_tabela("select * from observacoes");
            return tabela_memoria;
        }

        public Boolean pesquisarObjFiltro(string Pesq)
        {
            try
            {
                carregar_tabela("select * from observacoes where assunto_obs like '" + Pesq + "%'");

                cod_obs = Convert.ToInt32(tabela_memoria.Rows[0]["cod_obs"].ToString());
                nomeDono_obs = tabela_memoria.Rows[0]["nomeDono_obs"].ToString();
                tipoDonoObs = tabela_memoria.Rows[0]["tipoDono_obs"].ToString();
                assunto_obs = tabela_memoria.Rows[0]["assunto_obs"].ToString();
                mensagem_obs = tabela_memoria.Rows[0]["mensagem_obs"].ToString();
                prioridade_obs = tabela_memoria.Rows[0]["prioridade_obs"].ToString();
                dataHora_obs = Convert.ToDateTime(tabela_memoria.Rows[0]["dataHora_obs"].ToString());

                if (tabela_memoria.Rows.Count >= 1)
                {
                    tabelaFilto = tabela_memoria;
                }
                else
                {
                    tabelaFilto = null;
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
