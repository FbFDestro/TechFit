using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechFit
{
    abstract class dadosFuncParaTodosFrms
    {
        static String codFunc;

        public static String CodFunc
        {
            get { return dadosFuncParaTodosFrms.codFunc; }
            set { dadosFuncParaTodosFrms.codFunc = value; }
        }

     

    }
}
