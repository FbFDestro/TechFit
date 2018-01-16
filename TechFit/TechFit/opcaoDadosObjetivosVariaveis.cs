using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechFit
{
    abstract class opcaoDadosObjetivosVariaveis
    {
        static double peso, altura, meta_peso;
        static string estilo;

        public static double Meta_peso
        {
            get { return opcaoDadosObjetivosVariaveis.meta_peso; }
            set { opcaoDadosObjetivosVariaveis.meta_peso = value; }
        }

        public static double Altura
        {
            get { return opcaoDadosObjetivosVariaveis.altura; }
            set { opcaoDadosObjetivosVariaveis.altura = value; }
        }

        public static double Peso
        {
            get { return opcaoDadosObjetivosVariaveis.peso; }
            set { opcaoDadosObjetivosVariaveis.peso = value; }
        }

        public static string Estilo
        {
            get { return opcaoDadosObjetivosVariaveis.estilo; }
            set { opcaoDadosObjetivosVariaveis.estilo = value; }
        }

        static int cod_objetivo;

        public static int Cod_objetivo
        {
            get { return opcaoDadosObjetivosVariaveis.cod_objetivo; }
            set { opcaoDadosObjetivosVariaveis.cod_objetivo = value; }
        }
    }
}
