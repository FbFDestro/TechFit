using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechFit
{
   abstract class dadosAlunosParaTodosFrms
    {

        static string codAluno;

        public static string CodAluno
        {
            get { return dadosAlunosParaTodosFrms.codAluno; }
            set { dadosAlunosParaTodosFrms.codAluno = value; }
        }


    }
}
