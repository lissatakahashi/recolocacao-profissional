namespace Domain.Models
{
    internal class AreaProfissional
    {
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public AreaProfissional(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;
        }
    }
}
