using Domain.Models;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class ProfissaoDAL // Classe que tem acesso à base de dados.
    {
        private SqlConnection _sqlConnection;
        public ProfissaoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Profissao profissao)
        {
            _sqlConnection.Open(); // Abre a conexão.
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Profissao(ProfissaoID, NomeProfissao) " +
                "values (@profissaoID, @nomeProfissao)";
            command.Parameters.AddWithValue("@profissaoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nomeProfissao", profissao.NomeProfissao);
            command.ExecuteNonQuery(); // É uma atualização, não uma consulta.
            _sqlConnection.Close(); // Fecha a conexão.
        }
        public IReadOnlyCollection<Profissao> ObterTodos()
        {
            List<Profissao> profissoes = new List<Profissao>();
            var command = new SqlCommand(
                "select ProfissaoID, NomeProfissao from TB_Profissao order by NomeProfissao", _sqlConnection);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var profissao = new Profissao(
                        reader.GetString(1),
                        profissaoID: reader.GetGuid(0)
                    );
                    profissoes.Add(profissao);
                }
            }

            _sqlConnection.Close();
            return profissoes.AsReadOnly();
        }
        public Profissao ObterPorID(Guid? profissaoID)
        {
            Profissao profissao = null;
            var command = new SqlCommand("select ProfissaoID, NomeProfissao from TB_Profissao " +
                "where ProfissaoID = @profissaoID", _sqlConnection);
            command.Parameters.AddWithValue("@profissaoID", profissaoID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    profissao = new Profissao(reader.GetString(1),
                        profissaoID: reader.GetGuid(0));
                }
            }
            _sqlConnection.Close();
            return profissao;
        }

        public void Gravar(Profissao profissao)
        {
            if (profissao.ProfissaoID == null)
            {
                Inserir(profissao);
            }
            else
            {
                Atualizar(profissao);
            }

        }

        private void Atualizar(Profissao profissao)
        {
            var command = new SqlCommand("update TB_Profissao " +
                "set NomeProfissao = @nomeProfissao where ProfissaoID = @profissaoID", _sqlConnection);
            command.Parameters.AddWithValue("@nomeProfissao", profissao.NomeProfissao);
            command.Parameters.AddWithValue("@profissaoID", profissao.ProfissaoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
