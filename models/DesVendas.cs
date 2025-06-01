using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace EXEMPLOF.models
{
    public class DesVendas
    {   
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // classe do Newton que serve para substituir o nome
        //que esta no json para o nome do atributo abaixo da declaração da classe no caso aqui, PRODUTO.
        public string Produto { get; set; } = "";
        public decimal Preço { get; set; }
        
        public DateTime Datatual { get; set; }
    }
}