//Sempre que formos utilizar bibliotecas ou classes ja criadas importamos ela com o using
using Sesi.Model;

class Program 
{
   public static void Main()
   {
        //Criando uma variavel aluno1 e instanciando da classe Aluno, ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1 
        aluno1.nome =  "Vinicius";
        aluno1.idade = 16;
        aluno1.turma = "2ºEM";
        //Chamando o metodo da classe aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(3);
        aluno1.ResumirFaltas();


        var aluno2 = new Aluno();
        aluno2.nome = "Guilherme";
        aluno2.idade = 16;
        aluno2.turma = "2ºEM";
        aluno2.Apresentar();
   }
}