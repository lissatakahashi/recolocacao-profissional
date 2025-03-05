using Domain.Models;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class EmpresaDAL // Classe que tem acesso à base de dados.
    {
        private SqlConnection _sqlConnection;
        public EmpresaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Juridica juridica)
        {
            _sqlConnection.Open(); // Abre a conexão.
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Juridica(JuridicaID, Nome, Email, Senha, Cnpj) " +
                "values (@juridicaID, @nome, @email, @senha, @cnpj)";
            command.Parameters.AddWithValue("@juridicaID", juridica.JuridicaID);
            command.Parameters.AddWithValue("@nome", juridica.Nome);
            command.Parameters.AddWithValue("@email", juridica.Email);
            command.Parameters.AddWithValue("@senha", juridica.Senha);
            command.Parameters.AddWithValue("@cnpj", juridica.Cnpj);
            command.ExecuteNonQuery(); // É uma atualização, não uma consulta.
            _sqlConnection.Close(); // Fecha a conexão.
        }
    }
}
