using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechFit
{
    abstract class dadosFinanceirosPraTodosFrms
    {
        static String codOpFinanceiro;

        public static String CodOpFinanceiro
        {
            get { return dadosFinanceirosPraTodosFrms.codOpFinanceiro; }
            set { dadosFinanceirosPraTodosFrms.codOpFinanceiro = value; }


        }
    }
}
