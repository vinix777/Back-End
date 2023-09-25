Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());  


int soma = (nota1 + nota2 + nota3) / 3;

if (soma >= 7){
    Console.WriteLine($"{nome} passou de ano e sua nota é {soma}.");
} else {
    Console.WriteLine($"{nome} não passou de ano, sua nota foi {soma}.");
}