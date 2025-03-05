using Domain.Models;
using Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class CadastroCandidato : Form
    {
        private FisicaDAL _dal = new FisicaDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString));
        public CadastroCandidato()
        {
            InitializeComponent();
            //dgvFisicas.DataSource = _dal.ObterTodos();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {

            try
            {
                if ((tbNomeCandidato.Text != "") && (tbEmailCandidato.Text != "") && (tbSenhaCandidato.Text != "") && (tbCPFCandidato.Text != ""))
                {
                    _dal.Inserir(new Fisica(tbNomeCandidato.Text, tbIdadeCandidato.Text, tbEmailCandidato.Text, tbSenhaCandidato.Text, tbCPFCandidato.Text));
                    MessageBox.Show("Registro gravado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Inicial proximoForm = new Inicial();
                    this.Visible = false;
                    proximoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Existe um ou mais campos em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
