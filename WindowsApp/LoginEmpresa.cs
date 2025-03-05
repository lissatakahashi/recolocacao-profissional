using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class LoginEmpresa : Form
    {
        SqlConnection _conn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString);

        public LoginEmpresa()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbLoginEmailEmpresa.Text != "") && (tbLoginSenhaEmpresa.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("select JuridicaID, Email, Senha" +
                        " from TB_Juridica" +
                        " where Email = @email and Senha = @senha", _conn);

                    comm.Parameters.Add("@email", SqlDbType.VarChar).Value = tbLoginEmailEmpresa.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = tbLoginSenhaEmpresa.Text;

                    _conn.Open();

                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        Profissoes formTeste = new Profissoes();
                        this.Visible = false;
                        formTeste.ShowDialog();
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
