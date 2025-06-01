using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class MeuArray<T>

    {
        private static int quantidade = 12;
        private int contador = 0;
        private T[] array = new T[quantidade];

        public void adicionarQuantidade(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento; // array na posição de [contador] ele importa o elemento
            }
            contador++;
        }
public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
}


    }
}