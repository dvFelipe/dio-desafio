using Usando_a_Classe.Models;

//Convertendo de Maneira Segura | Aula 8
string a = "15-";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Convertido com sucesso!");



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