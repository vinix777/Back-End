class Animal
{
    public string cor { get; set; }

    public virtual void Emitirsom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

class Cachorro : Animal
{

    public string tipoPelo { get; set; }
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} esta latindo");
    }
}

class Gato : Animal
{
      public override void Emitirsom()
    {
        Console.WriteLine("O gato esta miando");
    }
}

class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.Emitirsom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.Emitirsom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.Emitirsom();
    }
}