namespace Bank
{

    public class ContaCorrente
    {
        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente (string titularContaCorrente)
        {
            this.titular = titularContaCorrente;
            this.saldo = 200;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"O seu saldo é de R${saldo}");
        }

        public void Depositar()
        {
             Console.WriteLine("Digite o valor que deseja depositar...");
            double valor = double.Parse(Console.ReadLine());
            
        
            if (saldo < 0){
                Console.WriteLine ("Invalido");
            } else {
                saldo += valor;
                Console.WriteLine($"Você depositou R${valor}");
            }
        }

        public void Sacar()
        {
             Console.WriteLine("Digite o valor que deseja sacar...");
            double valor = double.Parse(Console.ReadLine());
            
            if (saldo < 0){
                Console.WriteLine ("Invalido");
            } else {
                saldo -= valor;
                Console.WriteLine($"Você sacou R${valor}");
            }

        }


    }

}










