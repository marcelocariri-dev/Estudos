using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace EXEMPLOF.models
{///<summary>
/// REPRESENTA UMA PESSOA FÍSICA
/// </summary>

    public class Pessoa
    {
        public string _nome = "";
    public string Nome {
        
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("o NOME não pode ser vazio");
                }
                else
                {
                   _nome = value;
                }
            }
    }

        public int Idade { get; set; }
    public string Endereco { get; set; } ="";

    public int quantidadeImpressao { get; set; }
    public int contadorw {get; set;}
public void Apresentar() {
Console.WriteLine($"Ola, meu nome é {Nome}, tenho {Idade} de idade, e meu Endereço é {Endereco}");
}


public void Imprimir () {
Console.WriteLine("IMPRIMIU");
}

public void ImpressaoF() {
for(int contador =  1; contador <= quantidadeImpressao; contador ++ )
{
    Imprimir();
}
}

public void ImpressaoFW() {
while(contadorw <= 2) {
    Imprimir();
    contadorw ++;
}

if(quantidadeImpressao < 2){
    
}
}
   
   
}
}