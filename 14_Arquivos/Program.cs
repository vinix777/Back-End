using System.IO;

public class Progam
{
    public static void Main()
    {
        //GravarArquivo();
        LerArquivo();
    }

    public static void LerArquivo()
    {
        string CaminhoArquivo = "Arquivo/arquivo.txt"
        try
        {
            //Verificar se o arquivo existe
        if (File.Exists(CaminhoArquivo) == false)
        {
            File.Create(CaminhoArquivo);
        }

            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }

    public static void GravarArquivo()
    {
        try
        {
            //Instanciando um objeto da classe StreamWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter("arquivo/arquivo.txt", true))
            {
                Console.WriteLine("Digite uma informação para ser gravada no arquivo");
                arquivo.WriteLine(Console.ReadLine());
                Console.WriteLine("Informações gravadas");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar p arquivo: {erro.Message}");
        }
    }
}
