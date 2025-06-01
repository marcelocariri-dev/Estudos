using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class Leitura_log
    {   string path = @"ARQUIVOS/ArquivoLeitura.txt";
        public Leitura_log()
        {

            //construtor padrão
        }

        public void Leitor()
        {
            string[] pasta = File.ReadAllLines("ARQUIVOS/ArquivoLeitura.txt");

            foreach (string linha in pasta)
            {
                Console.WriteLine(linha);
            }
        }
        public void Escrever()
        { string path = @"ARQUIVOS/ArquivoLeitura.txt";
            
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
        }

        public void abrirPasta()
        {
            using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()!) != null)
            {
                Console.WriteLine(s);
            }
        }

        }
    }
}