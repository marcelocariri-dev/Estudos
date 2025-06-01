using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class Coonvert
    {
        public int ConvertInt(string numero)
        { //int a = int.Parse("numero")
            return Convert.ToInt32(numero); //quando ele tenta converter através da classe convert um valor nulo, ele convert para 0
        }

       
    }
}