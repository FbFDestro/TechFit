using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechFit
{
   abstract class opcaoFinanceiraVariaveis
    {
        static double valorMatricula, valorMensalidade, descontoBi, descontoTri, descontoSeme, descontoAnual;

        public static double DescontoAnual
        {
            get { return opcaoFinanceiraVariaveis.descontoAnual; }
            set { opcaoFinanceiraVariaveis.descontoAnual = value; }
        }

        public static double DescontoSeme
        {
            get { return opcaoFinanceiraVariaveis.descontoSeme; }
            set { opcaoFinanceiraVariaveis.descontoSeme = value; }
        }

        public static double DescontoTri
        {
            get { return opcaoFinanceiraVariaveis.descontoTri; }
            set { opcaoFinanceiraVariaveis.descontoTri = value; }
        }

        public static double DescontoBi
        {
            get { return opcaoFinanceiraVariaveis.descontoBi; }
            set { opcaoFinanceiraVariaveis.descontoBi = value; }
        }

        public static double ValorMensalidade
        {
            get { return opcaoFinanceiraVariaveis.valorMensalidade; }
            set { opcaoFinanceiraVariaveis.valorMensalidade = value; }
        }

        public static double ValorMatricula
        {
            get { return opcaoFinanceiraVariaveis.valorMatricula; }
            set { opcaoFinanceiraVariaveis.valorMatricula = value; }
        }

    }
}

