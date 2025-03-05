using Domain.Models;
using Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsApp
{
    public partial class Profissoes : Form
    {
        private ProfissaoDAL _dal = new ProfissaoDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString));

        private bool _estaCarregandoFormulario = true;
        private Profissao _profissaoAtual;

        public Profissoes()
        {
            InitializeComponent();
            InicializarFormulario();
            dgvFisicas.Columns[0].Visible = false;
            dgvFisicas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvFisicas.Columns.RemoveAt(0);
            //dgvFisicas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                _dal.Inserir(new Profissao(
                      tbNomeProfissao.Text,
                      profissaoID: _profissaoAtual?.ProfissaoID ?? null));

                InicializarFormulario();

                MessageBox.Show("Registro gravado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFisicas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_estaCarregandoFormulario)
            {
                RegistrarProfissaoAtual(dgvFisicas.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    profissaoID: Guid.Parse(
                            dgvFisicas.Rows[e.RowIndex].Cells[0].Value.ToString()));

                tbNomeProfissao.Text = _profissaoAtual.NomeProfissao;
            }
        }

        private void InicializarFormulario()
        {
            dgvFisicas.DataSource = _dal.ObterTodos();
            tbNomeProfissao.Clear();
            _profissaoAtual = null;
        }

        private void RegistrarProfissaoAtual(string profissao, Guid? profissaoID = null)
        {
            _profissaoAtual = new Profissao(profissao, profissaoID: profissaoID);
        }

        private void dgvProfissoes_Shown(object sender, EventArgs e)
        {
            dgvFisicas.ClearSelection();
            _estaCarregandoFormulario = false;
        }
    }
}