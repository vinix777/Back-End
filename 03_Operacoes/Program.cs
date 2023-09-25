Console.WriteLine("Digite o valor do X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de Y");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritiméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //Calculando o resto da divisão de x / 2
int restoDiv3 = y % 2; 

//Console para exibir na tela as variaveis em cada linha 
//Soma: 15
Console.WriteLine($"{soma}");
Console.WriteLine($"{subtracao}");
Console.WriteLine($"{multiplicacao}");
Console.WriteLine($"{divisao}");
Console.WriteLine($"{resto}");

if (restoDiv2 == 0){
    Console.WriteLine($"O número {x} é par");
}
else {
    Console.WriteLine($"O número {x} é impar");
}

if (restoDiv3 == 0){
    Console.WriteLine($"O número {y} é par");
}
else {
    Console.WriteLine($"O número {y} é impar");
}

//Operador ternário
// Condição ? se verdade : senão
string resultado = (restoDiv3 == 0) ? $"O número {y} é par" : $"O número {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3; 
//Aprendendo o Switch Case
switch (diaSemana){
    case 1:
        Console.WriteLine("Hoje é domingo!");
        break;
    case 2:
        Console.WriteLine("Hoje é segunda!");
        break;
    case 3:
        Console.WriteLine("Hoje é terça!");
        break;
    case 4:
        Console.WriteLine("Hoje é quarta!");
        break;
    case 5:
        Console.WriteLine("Hoje é quinta!");
        break;
    case 6:
        Console.WriteLine("Hoje é sexta!");
        break;
    case 7:
        Console.WriteLine("Hoje é sabado!");
        break;
    default:
        Console.WriteLine("Dia inválido");
}