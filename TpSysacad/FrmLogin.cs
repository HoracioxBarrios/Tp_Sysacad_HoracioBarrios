namespace TpSysacad

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string dni = textUsuario.Text; // de momento se usa el dni de usuario
            string contrase�a = textContrase�a.Text;

            BibliotecaCLases.AutenticacionSession autenticacion = new();

            bool verificado = autenticacion.AutenticarUsuario(dni, contrase�a);

            if (verificado)
            {
                FrmPanelAdmin frmPanelAdmin = new();
                frmPanelAdmin.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contrase�a Incorrecta");
                textUsuario.Text = string.Empty;
                textContrase�a.Text = string.Empty;

            }
        }
    }
}