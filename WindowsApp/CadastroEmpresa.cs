using Domain.Models;
using Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class CadastroEmpresa : Form
    {
        private EmpresaDAL _dal = new EmpresaDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString));
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void btGravarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbNomeEmpresa.Text != "") && (tbEmailEmpresa.Text != "") && (tbSenhaEmpresa.Text != "") && (tbCNPJEmpresa.Text != ""))
                {
                    _dal.Inserir(new Juridica(tbNomeEmpresa.Text, tbEmailEmpresa.Text, tbSenhaEmpresa.Text, tbCNPJEmpresa.Text));
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
