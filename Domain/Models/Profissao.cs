namespace Domain.Models
{
    public class Profissao
    {
        public Guid? ProfissaoID { get; private set; }
        public string NomeProfissao { get; private set; }

        public Profissao(string nomeProfissao)
        {
            NomeProfissao = nomeProfissao;
        }

        public Profissao(string nomeProfissao, Guid? profissaoID) : this(nomeProfissao)
        {
            ProfissaoID = profissaoID;
        }
        public void AtualizarNome(string nomeProfissao)
        {
            NomeProfissao = nomeProfissao;
        }

        //Métodos relativos a identidade do objeto
        public override bool Equals(object obj)
        {
            if (!(obj is Profissao)) return false;

            if ((obj as Profissao).ProfissaoID.Equals(ProfissaoID)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ProfissaoID == null ? 1 : ProfissaoID.GetHashCode());
        }

        public override string ToString()
        {
            return $"ID: {ProfissaoID}\nNome: {NomeProfissao}";
        }

    }
}
