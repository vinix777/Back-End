using Bank;

public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("$$ BEM VINDO AO SESI BANK $$");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

        Menu();
    }

    public static void Menu()
    {
        string titular = Console.ReadLine();
        ContaCorrente banco = new ContaCorrente(titular);
        string opcao = "";
        do
        {
            Console.WriteLine("");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    banco.ConsultarSaldo();
                    break;
                case "2":
                    banco.Depositar();
                    break;
                case "3":
                    banco.Sacar();
                    break;
                case "4":
                    Console.WriteLine("Você saiu da sua conta");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            } 


        } while (opcao != "4");

    }

}
