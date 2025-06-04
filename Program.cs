using System.Globalization;
using System.Net.Http.Headers;
using EXEMPLOF.models;
using Newtonsoft.Json;

// or = ||, AND = && !choveu = operador !not, negando os valores
//operadores aritimétricos somar {x + Y} / subtrair {x - y}. multiplicar {X * Y}, dividir {X / Y}
Pessoa p = new Pessoa(); 

p.Nome = "NOME TESTE";




p.Idade = 15;
p.Endereco = "RUA TESTE";

p.Apresentar();

int quantidade  = 1;

decimal dinheiro = 1.80m;

double altura = 1.80;

int v = 4;

DateTime dataatual = DateTime.Now.AddDays(v);



int a = int.Parse("5");

int inteiro = 5;
double D = inteiro;

// ACIMA AQUI temos cast, coversão de um tipor menor para um tipo maior
Console.WriteLine($"a quantidade é {quantidade}, o dinheiro é {dinheiro}, altura é {altura.ToString("0.00")}");

Console.WriteLine(dataatual);


//covertendo de maneira segura

string caractere = "16*";

int segura = 0;

int.TryParse(caractere, out segura);
// o string tem um caractere especial para converter de maneira segura para int
//é preciso fazer um TRYPARSE, ele vai ver caractere se é possivel converter
// se sim ele converter para variável segura, se nao ele deixa segura original.


//operadores condicionais 

int estoque = 40;

int quantidadecompra = 36;
bool possivelvenda = quantidadecompra > 0 && estoque >= quantidadecompra;
bool vendainvalida = quantidadecompra == 0;

if(vendainvalida) {
    Console.WriteLine("É preciso ter quantidade no carrinho");
}
else if(possivelvenda) {
    estoque = estoque - quantidadecompra ;
    Console.WriteLine(estoque);
}
else 
{
Console.WriteLine("a quantidade de estoque não é suficiente");

}

Console.WriteLine("escreva uma letra");

string? letra = Console.ReadLine(); //interrogação é para aceitar a string como valor anulável


if(letra == "a" || letra == "e"|| letra == "i"){
    Console.WriteLine("vogal");
} else{

Console.WriteLine("NÃO É UMA VOGAL");
}

///SWITCH CASE

switch(letra)
{
case  "a":
case "i":
case "e":
case "o":
case "u":

Console.WriteLine("vogal");
break;

default:
Console.WriteLine("Não é uma vogal");

break;



}
p.quantidadeImpressao = 2;
p.ImpressaoF();

///arrays
int[] arrayinteiro = new int [3]; // posição do array máxima

arrayinteiro[0] = 0;


arrayinteiro[1] = 50;
arrayinteiro[2] = 000;


 
for (int contadorr = 0; contadorr < arrayinteiro.Length; contadorr ++){
    Console.WriteLine($"contador: {contadorr} - {arrayinteiro[contadorr]}" );
}

//temos o foreach também

foreach (int valor in arrayinteiro)
{
    Console.WriteLine(valor);
}


///redimensionar um array

//Array.Resize(ref arrayinteiro, arrayinteiro.Length * 2); redemesiona trazendo um cópia

int[] arraydobrado =  new int[arrayinteiro.Length * 2];
Array.Copy(arrayinteiro, arraydobrado, arrayinteiro.Length);
 

 //// listas
 
 List <string> listastring = new List<string>();
listastring.Add("ROMA");
listastring.Add("ESCOCIA");

listastring.Add("MOSCOU");

listastring.Add("GENEBRA");

foreach (string cidades in listastring)
{
    Console.WriteLine(cidades);
}

for (int contadorl = 0; contadorl < listastring.Count; contadorl++)
{
    Console.WriteLine($"CONTADOR {contadorl}, conteúdo {listastring[contadorl]}");
}


////////////////valores monetários
decimal ValoroMonetário = 10.50M;
Console.WriteLine($"{ValoroMonetário:C}"); // O C formata a string para formato de dinheiro do país da maquina
//porém eu posso mudar a localização com código abaixo:
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");// muda a llocalização do código para US
//POSSO CRIAR espececífico para somente uma classse 
Console.WriteLine(ValoroMonetário.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//
// O C, pode ser feito assim C1 para uma casa decimal no resultado, ou C2 para duas, c8 para 8 no resultado
/// instanciando data e hora
DATA_LUGAR DATA = new DATA_LUGAR();

DATA.Retorno();

DATA.SomenteData();
/////////testando o tryparse para data.
Console.WriteLine("Digite a string data");
string date_place = Console.ReadLine()!;
Console.WriteLine($"Imprimindo STRING {date_place}");
DATA_LUGAR data_lugar = new DATA_LUGAR(date_place);
data_lugar.Conversão();



///testando o leitor
Leitura_log leitura = new Leitura_log();

leitura.Leitor();


leitura.abrirPasta();

leitura.Escrever();


///testando as tuplas
///
Tuplas tuplas = new Tuplas();

var (sucesso, linhas,_) = tuplas.leitura("ARQUIVOS/ArquivoLeitura.txt");
//arquivo acima foi descontruído puxando o retorno do método para declara-lo
//aplicado descarte na última variável.

if (sucesso)
{
    // comentando a quantidade de linhas para descartar Console.WriteLine($"LInhas: {qtdeLinhas}");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("não foi possível ler o arquivo");
}

//////////// testando o Newtonsoft
/// 
DateTime Dataa = DateTime.Now;
List<Venda> vendas = new List<Venda>();
Venda venda = new Venda(1, "CAIXA", 15.00M, Dataa);
Venda venda2 = new Venda(2, "POTE", 15.00M, Dataa);
Venda venda3 = new Venda(3, "POTE", 15.00M, Dataa);
vendas.Add(venda);
vendas.Add(venda2);
vendas.Add(venda3);
 
string json = JsonConvert.SerializeObject(vendas,Formatting.Indented);

Console.WriteLine(json);
Console.WriteLine("ACIMA O JSON SEM SER ESCRITO");

// para escrever
// podia utilizar 
File.WriteAllText("ARQUIVOS/json.json", json);
string[] jsonjson = File.ReadAllLines("ARQUIVOS/json.json");
 foreach (string lerr in jsonjson)

 {
        Console.WriteLine($"Tipo de leitura apos fileWRITER {lerr}");
 }

//ou STRAMwriter abrir a conexão para pasta,transforma em jsonWritwer e passa o writer e o objeto 
// na serialização

using (StreamWriter sw = new StreamWriter("ARQUIVOS/js.json"))
using (JsonWriter writer = new JsonTextWriter(sw))
{
    JsonSerializer serializer = new JsonSerializer();
    serializer.Serialize(writer, venda3);


}

string[] ler = File.ReadAllLines("ARQUIVOS/js.json");
 
 foreach (string lerr in ler)

 {
        Console.WriteLine($"Tipo de leitura apos W stream {lerr}");
 }

///////////////////
///DESERiALIZAR
///
string arquiv = File.ReadAllText("ARQUIVOS/des.json");
List<DesVendas>? des = JsonConvert.DeserializeObject<List<DesVendas>>(arquiv);

foreach (DesVendas item in des)
{
    Console.WriteLine($"{item.Id}, {item.Produto}");
}

var listanonima = des.Select(x => new { x.Id, x.Preço }); // usando tipo anonimo sobre lista

foreach (var lista in listanonima)
{
    Console.WriteLine($"IMPRESSÃO DA VARIAVEL A PARTIR DO TIPO ANONIMO{lista.Id}, {lista.Preço}");
}

////////////// nulos em C#

bool? desejarReceberemail = null; // a interrogação serve para dizer que tipo vai receber resultado diferente do esperado

if (desejarReceberemail.HasValue && desejarReceberemail.Value) // has value ver se não é nulo != nulo
// .value vai pegar o valor, no caso está implicito a verificação se a veriável é true 
{
    Console.WriteLine("Vai receber no email");
}


//tipos anônimos somente leitura

var tiposanonimos = new { nome = "MARCELO", ALTURA = 1.80M, DATA = DateTime.Now };

Console.WriteLine($"{tiposanonimos.nome} {tiposanonimos.ALTURA} {tiposanonimos.DATA}");


/// tipos dinamicos

dynamic dinamico = 3; // ele pode ser qualquer tipo que a ele for atribuído.

Console.WriteLine ( $"Tipo dinamico: {dinamico.GetType()}");
dinamico = "Texto";
Console.WriteLine ( $"Tipo dinamico: {dinamico.GetType()}");



//////// testando classes genericas 



MeuArray<int> inteiroa = new MeuArray<int>(); ///coloquei o tipo int na minha classe generica 


inteiroa.adicionarQuantidade(3); // importei um elemento, contado era 0, e foi colocado o elemento na

Console.WriteLine($"o valor do array é { inteiroa[0]}");
///////


//TODO: Implementar a formula para calcular as horas.
   string[] line1 = Console.ReadLine().Split(" ");
    string[] line2 = Console.ReadLine().Split(" ");
    int finalExpediente = int.Parse(line1[0]);
    
    int presente1 = int.Parse( line2[0]   );
    int presente2 = int.Parse(  line2[1]    );
    
    int totalNecessario =  presente1 + presente2;
    
    if (  totalNecessario >   finalExpediente                             )
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei hoje!");
    }



/// testando a herança e polimorfismo
/// 
ContaCorrente contaCorrente = new ContaCorrente(135749);

contaCorrente.Creditar(50, 2);

contaCorrente.MostrarSaldo();

contaCorrente.MostrarNconta();