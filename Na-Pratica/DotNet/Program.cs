using Usando_a_Classe.Models;

//Operador NOT na prática | Aula 6 | Operadores Lógicos
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde){
    Console.WriteLine("Vou pedalar!");
}else {
    Console.WriteLine("Vou pedalar outro dia!");
}



//Operador AND na prática | Aula 4 | Operadores lógicos 
// bool possuiPresencaMinima = false;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado!");
// }else {
//     Console.WriteLine("Reprovado!");
// }



//Operador OR na prática | Aula 2 | Operadores lógicos
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else 
// {
//     Console.WriteLine("Entrada não liberada!");
// }



//////////////////////////////////////////////////////
// Aprendendo o switch case | Aula 5 | Operadores Condicionais
// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
// {

//     Console.WriteLine("Vogal");

// }
// else
// {
//     Console.WriteLine("Não é uma Vogal");
// }



// Console.WriteLine("Digite uma letra");

// string letra = Console.ReadLine();

// if (letra == "a"){

//     Console.WriteLine("Vogal");

// }else if (letra == "e"){

//     Console.WriteLine("Vogal");

// }else if (letra == "i"){

//     Console.WriteLine("Vogal");

// }else if (letra == "o"){

//     Console.WriteLine("Vogal");

// }else if (letra == "u"){

//     Console.WriteLine("Vogal");

// }else {
//     Console.WriteLine("Não é uma vogal");
// }



///////////////////////////////////////
// if Aninhado | Aula 4 | Operadores Condicionais|
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0){

//     Console.WriteLine("Venda inválida");
    
//     }else if (possivelVenda){

//     Console.WriteLine("Venda realizada");

// }else {

//     Console.WriteLine("Desculpe não temos estoque");

// }





//Convertendo de Maneira Segura | Aula 8
// string a = "15-";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Convertido com sucesso!");



//Ordem dos Operadores | Aula 7
// double a = 4 / 2 + 2;
// double b = 4 / (2 + 2);

// Console.WriteLine(a);
// Console.WriteLine(b);


// Cast Implícito| Aula 06
//int a = 5;
//double b = a;

//long a = 5;
//int b = Convert.ToInt32(a);
 
    /* int cabe em um long mas um long não cabe em um int!
int a = int.MaxValue;
long b = a;


Console.WriteLine(b); */



//Conversão de inteiro para string!
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


//  Cast | Casting
//int a = 5;
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");

//Console.WriteLine(a);



// Operadores de atribuição!
// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5; (35)

//c += 5;

//Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.65;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);



//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Felipe";
//pessoa1.Idade = 24;
//pessoa1.Apresentar();