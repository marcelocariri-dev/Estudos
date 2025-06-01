using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EXEMPLOF.models
{
    public class EstruturasDados
    {
        private Queue<int> FILA = new Queue<int>();
        private Stack<int> PILHA = new Stack<int>();
        private Dictionary<string, string> Dicionario = new Dictionary<string, string>();

        //////////////FILA

        public void FilaSET(int addfila)
        {
            FILA.Enqueue(addfila);
        }
        public void getlista()
        {
            foreach (int item in FILA)
            {
                Console.WriteLine(item);
            }
        }
        /////////////pilha
        public void PilhaSET(int addpilha)
        {
            PILHA.Push(addpilha);
        }

        public void getpilha()
        {
            foreach (int item in PILHA)
            {
                Console.WriteLine(item);
            }
        }

        public void removePilha()
        {
            PILHA.Pop(); //remove o elemento do topo
        }
        ///////////DICIONÁRIO - CHAVE VALOR 
        ///
        public void dicionarioSET(string chave, string valor)
        {
            Dicionario.Add(chave, valor);
        }

        public void GETdicionario()
        {
            foreach (var tipo in Dicionario)
            {
                Console.WriteLine($"chave: {tipo.Key}, valor {tipo.Value}"); //substituindo o var poderia ser por
                                                                            // KeyValuePair<string, string>
    }
} public void DeleteDicionário(string key)
        {
            Dicionario.Remove(key);
        }
        public void AlterarDicionario(string chave, string valor)
        {
            Dicionario[$"{chave}"] = $"{valor}";
}
        public void buscadorDicionário(string chave, string valor)
        {
            if (Dicionario.ContainsKey(chave))
            {
                Console.WriteLine($"A chave ja existe:{chave}");
            }
            else
            {
                Console.Write("É seguro adicionar");
                Dicionario.Add(chave, valor);
   }
}
    } }