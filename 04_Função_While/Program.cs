//Função em JavaScript
//function nomeFuncao (nome) {
//}

//public static string nomeFuncao(string nome) {
//}

class Sesi
{
    public static void Main()
    {
        //Chamado metodos sem retorno
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem("SESI / SENAI");
        imprimeDataHora();
        //Chamado o metodo Potenciação com o parametro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {potencia} ");

        ContagemRegressiva(10);

        JogoQueNrSouEu();
    }

    public static double Potenciacao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }

    //Metodo sem parametro sem retorno
    public static void imprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOMMMMMMMMMMMMMMMM");
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("              Bem vindo ao Jogo              ");
        Console.WriteLine(" Sorteei um nº de 1 a 20. tente adivinhá-lo  ");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("");

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        Console.WriteLine(nrSorteado);
        int nrDigitado = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
            Console.WriteLine("O número digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns você acertou");
    }

}
