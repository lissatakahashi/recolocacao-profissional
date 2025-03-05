namespace Domain.Models
{
    public class Fisica
    {
        public Guid? FisicaID { get; private set; }
        public string Nome { get; private set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; private set; }
        // public DateTime DataDeNascimento { get; set; }
        public Fisica(string nome, string idade, string email, string senha, string cpf/*, Guid? fisicaID = null*/)
        {
            //FisicaID = fisicaID == null ? Guid.NewGuid() : fisicaID;
            //FisicaID = fisicaID;
            Nome = nome;
            Idade = idade;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            // DataDeNascimento = dataDeNascimento;
        }
        public Fisica(string nome, string idade, string email, string senha, string cpf, Guid? fisicaID) : this(nome, idade, email, senha, cpf)
        {
            FisicaID = fisicaID;
        }

        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }

        //Métodos relativos a identidade do objeto
        public override bool Equals(object obj)
        {
            if (!(obj is Fisica)) return false;

            if ((obj as Fisica).FisicaID.Equals(FisicaID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (FisicaID == null ? 1 : FisicaID.GetHashCode());
        }

        public override string ToString()
        {
            return $"ID: {FisicaID}\nNome: {Nome}\nIdade: {Idade}\nE-mail: {Email}\nSenha: {Senha}\nCPF: {Cpf}";
        }
    }
}
