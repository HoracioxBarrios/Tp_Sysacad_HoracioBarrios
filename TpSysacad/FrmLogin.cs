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
            if (textUsuario.Text == "root" && textContrase�a.Text == "root")
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