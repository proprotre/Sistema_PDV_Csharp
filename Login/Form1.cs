namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = new DialogResult();

            dialogo = MessageBox.Show("Quer mesmo sair?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar usuario
                var db = new SistemaPdv();
                var usuario = db.Usuarios.Where(u => u.UsuarioId == 1).Select(u => u.Login).FirstOrDefault();
                var senha = db.Usuarios.Where(u => u.UsuarioId == 1).Select(u => u.Senha).FirstOrDefault();

                if (txtUsuario.Text.Equals(usuario) && txtSenha.Text.Equals(senha))
                {
                    var menu = new MenuRestrito();
                    menu.Show();

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Falha no login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtUsuario.Focus();
                txtSenha.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex} - Entre em contato com o suporte!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}