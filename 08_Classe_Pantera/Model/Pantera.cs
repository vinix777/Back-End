namespace Sesi.Model
{
    public class Pantera
    {
        public decimal tamanho { get; set; }
        public decimal peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }


        public void Correr(){
            Console.WriteLine("A pantera esta correndo");
        }

        public void Cacar(){
            Console.WriteLine("A pantera esta caçando");
        }

        public void Reproduzir(){
            Console.WriteLine("A pentera esta se reproduzindo");
        }
    }
}