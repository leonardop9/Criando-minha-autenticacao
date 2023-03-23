namespace Criando_minha_autenticacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            btn_Cadastro cadastro = new btn_Cadastro();
            this.Hide();
            cadastro.Closed += fecharFormulario;
            cadastro.Show();

        }
        private void fecharFormulario(object? enviado, EventArgs args)
        {
            this.Close();
        }

    }
}