using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class Candidatar : Form
    {
        SqlConnection _conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString);

        public Candidatar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCandidatar.Text != "")
                {
                    SqlCommand comm = new SqlCommand("select ProfissaoID, NomeProfissao" +
                        " from TB_Profissao" +
                        " where NomeProfissao = @nomeProfissao", _conn);

                    comm.Parameters.Add("@nomeProfissao", SqlDbType.VarChar).Value = tbCandidatar.Text;

                    _conn.Open();

                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();


                    if (reader.Read())
                    {
                        //candidatoConectado = tbLoginEmailCandidato.Text;
                        //nivelAcesso = tbLoginSenhaCandidato.Text;
                        //candidatoSelecionado = reader.GetGuid(0);
                        MessageBox.Show("Você se candidatou a vaga!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Esta profissão que você digitou está indisponível! Por favor, tente outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("O campo está em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
