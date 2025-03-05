namespace WindowsApp
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void btLoginCandidatos_Click(object sender, EventArgs e)
        {
            LoginCandidato proximoForm = new LoginCandidato();
            this.Visible = false;
            proximoForm.ShowDialog();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CandidatoOuEmpresa proximoForm = new CandidatoOuEmpresa();
            this.Visible = false;
            proximoForm.ShowDialog();
        }

        private void btLoginEmpresas_Click(object sender, EventArgs e)
        {
            LoginEmpresa proximoForm = new LoginEmpresa();
            this.Visible = false;
            proximoForm.ShowDialog();
        }
    }
}
