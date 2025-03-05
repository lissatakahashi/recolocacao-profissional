namespace Domain.Models
{
    public class Juridica
    {
        public Guid? JuridicaID { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cnpj { get; private set; }
        public Juridica(string nome, string email, string senha, string cnpj, Guid? juridicaID = null)
        {
            JuridicaID = juridicaID == null ? Guid.NewGuid() : juridicaID;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cnpj = cnpj;
        }
    }
}
