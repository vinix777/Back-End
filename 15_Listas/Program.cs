using System.Collections.Generic;
using Sesi.Models;
public class Program
{

    public static void Main()
    {
        //Criando uma lista
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[0]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");
        
        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        List<string> listaNomes = new List<string>();

        //Adicionando elementos a lista
        listaNomes.Add("Vinicius"); //posição [0]
        listaNomes.Add("Rayssa"); //posição [1]
        listaNomes.Add("Douglas"); //posição [2]

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNomes[0]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNomes.Count} elementos");

        //Criando uma lista de números ja atribuindo valornues
        List<int> numeros = new List<int> {1, 2, 5, 6, 8, 9};
        Console.WriteLine($"Quantidade de elementos na lista numeros: {numeros.Count}");
        numeros.Remove(2); // Remover o elemento 2
        numeros.RemoveAt(1); // Remover o elemento no indice 1
        numeros.RemoveRange(2,2); // Remover 2
        
        //substituindo informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        foreach(string nome in listaNomes)
        {
            Console.WriteLine(nome);
        }

        //Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Bob", 17));
        listaAlunos.Add(new Aluno("Marley", 18));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Aluno:");

        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }

        //Criando uma nova lista, ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
        Console.WriteLine(aluno);
        }

        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
                            .Where(aluno => aluno.idade == 17) 
                            .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        } 

    }

}