namespace Models
{
    public class Pessoa
    {
        //Atributos da nossa classe Pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anoNascimento { get; set; }
        
        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }

        //Metodo da Classe Pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, ano de nascimento: {anoNascimento}, E-mail: {email}");
        }
    }
}