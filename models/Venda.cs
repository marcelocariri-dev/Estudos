using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace EXEMPLOF.models
{
    public class Venda
    {
        public Venda(int id, string nome, decimal preço, DateTime dataatual)
        {
            Id = id;
            Nome = nome;
            Preço = preço;
            Datatual = dataatual;
        }
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preço { get; set; }
        
        public DateTime Datatual { get; set; }
    }
}