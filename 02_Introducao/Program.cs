//Somente declarando uma variavel do tipo inteira e sem valor
//int num1;

//Declarando uma variavel do tipo inteira e atribuindo valor 5
//int num2 = 5;

//Declarando variavel String
//string nomeAluno = "Paulo";

//Variavel do tipo (true ou false)
//bool resultado = true;

//Variavel do tipo double valor com varias casas decimais 
//double coordenada = 1.09876543;

//Variavel do tipo decimal - utilizando para valores
//decimal valor = 1.80M;  

int idade = 16;
string meuNome = "Vinicius";
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

Console.WriteLine("Em qual cidade você nasceu?");
//Readline serve apenas para que eu receba uma informação do usuário e armazeno em um variavel 
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");