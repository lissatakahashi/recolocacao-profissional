namespace WindowsApp
{
    public partial class CandidatoOuEmpresa : Form
    {
        public CandidatoOuEmpresa()
        {
            InitializeComponent();
        }

        private void btCandidato_Click(object sender, EventArgs e)
        {
            CadastroCandidato proximoForm = new CadastroCandidato();
            this.Visible = false;
            proximoForm.ShowDialog();
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            CadastroEmpresa proximoForm = new CadastroEmpresa();
            this.Visible = false;
            proximoForm.ShowDialog();
        }
    }
}
