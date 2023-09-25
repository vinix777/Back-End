public class Program
{
    public static void Main()
    {
        //Criando uma classe anonima (classe sem definiçao inicial)
        var pessoa1 = new
        {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new
        {
            nome = "Maria",
            email = "maria@aluno.senai.br",
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos ");
        Console.WriteLine($"A pessoa1 é {pessoa2.nome} e tem o e-mail {pessoa2.email} ");

        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de Carro

        var carro1 = new
        {
            marca = "VW",
            modelo = "Golf GTI",
            ano = 2020
        };

        Console.WriteLine($"Marca: {carro1.marca}, Modelo: {carro1.modelo}, Ano: {carro1.ano} ");


    }
}