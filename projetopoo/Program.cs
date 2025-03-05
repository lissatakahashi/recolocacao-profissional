using Domain.Models;
using Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace projetopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString; // String de conexão
            ProfissaoDAL dal = new ProfissaoDAL(new SqlConnection(connectionString));

            // Inserção
            // ========
            Profissao profissao = new Profissao("Testeeeee");
            dal.Inserir(profissao);

            // Recuperação de todos
            // ====================
            //var fisicas = dal.ObterTodos();
            //foreach (var e in fisicas)
            //{
            //    Console.WriteLine(e);
            //}

            // Recuperação por ID
            // ==================
            //Console.WriteLine($"Nome: {dal.ObterPorID(Guid.NewGuid())?.Nome}");
            //Console.WriteLine($"Nome: {dal.ObterPorID(Guid.Parse("c4b08009-97fc-41f8-acb7-2067a0917cb0"))?.Nome}");

            // Atualização de um objeto
            // ========================
            //var fisica = dal.ObterPorID(Guid.Parse("c4b08009-97fc-41f8-acb7-2067a0917cb0"));
            //fisica.AtualizarNome("Valéria");
            //dal.Gravar(fisica);

            // Remoção de um objeto
            // ========================
            //var fisica = dal.ObterPorID(Guid.Parse("c4b08009-97fc-41f8-acb7-2067a0917cb0"));
            //dal.Remover(fisica);

            Console.WriteLine("Registro realizado.");
            Console.ReadKey();
        }
    }
}
