using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um metodo construtor
       /* Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Vinicius";
        pessoa1.idade = 16;
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Vinicius",
            idade = 16
        };
        pessoa2.Cantar();
        */

        Pessoa pessoa1 = new Pessoa("Vinicius" , 17 , "vinieduardoresende@gmail.com");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Guilherme" , 16 , "guilhermesantos@gmail.com");
        pessoa2.Cantar();
        pessoa2.Informacoes();

        Pessoa pessoa3 = new Pessoa("Gustavo" , 16 , "gustavocouto@gmail.com");
        pessoa3.Cantar();
        pessoa3.Informacoes();
    }
}