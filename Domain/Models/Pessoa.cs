namespace Domain.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Pessoa(string nome, int idade, string login, string senha)
        {
            Nome = nome;
            Idade = idade;
            Login = login;
            Senha = senha;
        }

    }
}
