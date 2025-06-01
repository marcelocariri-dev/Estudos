using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public static class PAR
    {
        public static bool EHPAR(this int numero)
        //this int numero significa que o método EHPAR está sendo adicionado ao tipo int. Isso permite que 
        //qualquer variável do tipo int chame o método EHPAR como se ele fosse um método nativo do tipo int.
        {
            return numero % 2 == 0;
        }
    }
}