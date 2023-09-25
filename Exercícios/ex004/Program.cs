class programa
{
    public static void Main()
    {
        Console.WriteLine("Digite o número");
        int nrDigitado = int.Parse(Console.ReadLine());

        int valorDobro = Dobro(nrDigitado);
        Console.WriteLine($"O dobro de {nrDigitado} é {valorDobro} ");

        int valorMetade = Metade(nrDigitado);
        Console.WriteLine($"A metade de {nrDigitado} é {valorMetade} ");

        Console.WriteLine("Escreva o numero");
        int n = int.Parse(Console.ReadLine());
        Tabuada(n);

        ResumoSalarios();

    }

    public static int Dobro(int nrDigitado)
    {
        int resultado = nrDigitado * 2;
        return resultado;
    }

    public static int Metade(int nrDigitado)
    {
        int resultado = nrDigitado / 2;
        return resultado;
    }

    //Tabuada com While
    public static void Tabuada(int Valor)
    {
        int n = 0;
        while (n <= 10)
        {
            Console.WriteLine($"{n} x {Valor} = {n * Valor}");
            n++;
        }
    }

    public static void ResumoSalarios()
    {
        int solmaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o saláro do empregado");
            salarioEmpregado = int.Parse(Console.ReadLine());

            if (salarioEmpregado > 0)
            solmaSalarios += salarioEmpregado;
            if (salarioEmpregado > maiorSalario) {
                maiorSalario = salarioEmpregado;
            }
            if(salarioEmpregado < menorSalario && salarioEmpregado > 0){
                menorSalario = salarioEmpregado;
            }

        } while (salarioEmpregado > 0);

        Console.WriteLine($"A soma dos salários são {somaSalarios} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");

    }

}