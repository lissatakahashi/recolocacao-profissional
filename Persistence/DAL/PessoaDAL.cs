using Domain.Models;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class FisicaDAL // Classe que tem acesso à base de dados.
    {
        private SqlConnection _sqlConnection;
        public FisicaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Fisica fisica)
        {
            _sqlConnection.Open(); // Abre a conexão.
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Fisica(FisicaID, Nome, Idade, Email, Senha, Cpf) " +
                "values (@fisicaID, @nome, @idade, @email, @senha, @cpf)";
            command.Parameters.AddWithValue("@fisicaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", fisica.Nome);
            command.Parameters.AddWithValue("@idade", fisica.Idade);
            command.Parameters.AddWithValue("@email", fisica.Email);
            command.Parameters.AddWithValue("@senha", fisica.Senha);
            command.Parameters.AddWithValue("@cpf", fisica.Cpf);
            // command.Parameters.AddWithValue("@datadenascimento", fisica.DataDeNascimento);
            command.ExecuteNonQuery(); // É uma atualização, não uma consulta.
            _sqlConnection.Close(); // Fecha a conexão.
        }
        public IReadOnlyCollection<Fisica> ObterTodos()
        {
            List<Fisica> fisicas = new List<Fisica>();
            var command = new SqlCommand(
                "select FisicaID, Nome, Idade, Email, Senha, Cpf from TB_Fisica order by Nome", _sqlConnection);

            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var fisica = new Fisica(
                        reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),
                        fisicaID: reader.GetGuid(0)
                    );
                    fisicas.Add(fisica);
                }
            }

            _sqlConnection.Close();
            return fisicas.AsReadOnly();
        }
        public Fisica ObterPorID(Guid? fisicaID)
        {
            Fisica fisica = null;
            var command = new SqlCommand("select FisicaID, Nome, Idade, Email, Senha, Cpf from TB_Fisica " +
                "where FisicaID = @fisicaID", _sqlConnection);
            command.Parameters.AddWithValue("@fisicaID", fisicaID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fisica = new Fisica(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5),
                        fisicaID: reader.GetGuid(0));
                }
            }
            _sqlConnection.Close();
            return fisica;
        }
        public void Gravar(Fisica fisica)
        {
            if (fisica.FisicaID == null)
            {
                Inserir(fisica);
            }
            else
            {
                Atualizar(fisica);
            }

        }
        public void Remover(Fisica fisica)
        {
            var command = new SqlCommand("delete from TB_Fisica " +
                "where FisicaID = @fisicaID", _sqlConnection);
            command.Parameters.AddWithValue("@fisicaID", fisica.FisicaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Fisica fisica)
        {
            var command = new SqlCommand("update TB_Fisica " +
                "set Nome = @nome where FisicaID = @fisicaID", _sqlConnection);
            command.Parameters.AddWithValue("@nome", fisica.Nome);
            command.Parameters.AddWithValue("@fisicaID", fisica.FisicaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
