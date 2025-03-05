using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace WindowsApp
{
    public partial class LoginCandidato : Form
    {
        //public static string candidatoConectado;
        //public static string nivelAcesso;
        //public static Guid candidatoSelecionado;

        SqlConnection _conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString);
        public LoginCandidato()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbLoginEmailCandidato.Text != "") && (tbLoginSenhaCandidato.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("select FisicaID, Email, Senha" +
                        " from TB_Fisica" +
                        " where Email = @email and Senha = @senha", _conn);

                    comm.Parameters.Add("@email", SqlDbType.VarChar).Value = tbLoginEmailCandidato.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = tbLoginSenhaCandidato.Text;

                    _conn.Open();

                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {


                        Candidatar proximoForm = new Candidatar();
                        this.Visible = false;
                        proximoForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("O e-mail ou senha estão incorretos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Os campos estão em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
