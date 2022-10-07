using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();


//////////////////////////////////////////////////////////
//Refatorando o menu | Aula 10 | Estruturas de Repetição
// string? opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3": 
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4": 
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou!");






////////////////////////////////////////////////////////////////////
//Construindo um menu interativo | Aula 9 | Estruturas de Repetição
// string? opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2": 
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3": 
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4": 
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }





//Introdução ao DO WHILE | Aula 7 | Estruturas de Repetição
// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
    
// } while(numero != 0);

// Console.WriteLine($"Total de soma dos números digitados é: {soma}");




///////////////////////////////////////////////////////////////////////
//Interrompendo o fluxo de execução | Aula 6 | Estruturas de Repetição
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
    
// if (contador == 5)
//     {
//         break;
//     }
// }




/////////////////////////////////////////////////////////
//Introdução ao WHILE | Aula 4 | Estruturas de repetição
//  int numero = 5;
//  int contador = 0;

//  while (contador <= 10)
//  {
//      Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//      contador++;
    
//  }

////////////////////////////////////////////////////
//Introdução ao FOR | Aula 2 | Estruturas de repetição
// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }




////////////////////////////////////////////////////////////////
//Calculando Raiz Quadrada | Aula 6 | Operadores Aritméticos
// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);



///////////////////////////////////////////////////////////////////
//Incremento e Decremento | Aula 5 | Operadores Aritméticos
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroIncremento++;

// int numeroDecremento = 20;

// Console.WriteLine("Decrementando o 10");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);



//////////////////////////////////////////////////////////////////////
//Funções Trigonométricas | Aula 4 | Operadores Aritméticos 
// Calculadora calc = new Calculadora();
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);


//Criando a nossa classe Calculadora | aula 1 | Operadores Aritméticos
//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// calc.Potencia(3, 3);


//////////////////////////////////////////////////////////
//Operador NOT na prática | Aula 6 | Operadores Lógicos
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar!");
// }else {
//     Console.WriteLine("Vou pedalar outro dia!");
// }



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