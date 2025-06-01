using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class Tuplas

    {
        public void tuplas()
        {
            (int id, string Nome, string sobrenome, decimal altura) tupla = (1, "leonardo", "buta", 10.5M);
            Console.WriteLine(tupla.id);
            Console.WriteLine(tupla.Nome);
        }

        public (bool sucesso, string[] linhas, int QuantidadeLinhas) leitura(string caminho)
        { try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());


            } catch {
                return (true, new string[0], 0);
            }
        }
    }
}