namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.id = 1;
            user.login = "admin";
            user.senha = "123456";
            user.nome = "Administrador do Sistema";
            user.dataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(user);

            user = new Usuario();
            user.id = 2;
            user.login = "user";
            user.senha = "123456789";
            user.nome = "Usuário do Sistema";
            user.dataCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(user);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.ListaUsuarios)
            {
                if (us.login == txtLogin.Text && us.senha == txtSenha.Text)
                {
                    FormMenu form = new FormMenu();
                    form.ShowDialog();
                    return;
                }
            }
            Erro("Usuário não autenticado.");
        }

        private void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
