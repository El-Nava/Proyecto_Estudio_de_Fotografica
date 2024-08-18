namespace Proyecto_Estudio_de_Fotografica{
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {
            String user = tb_user.Text;
            String pass = tb_password.Text;

            if(!Funciones_y_Mas.Comprobar(user, pass)) {
                MessageBox.Show("Error","Usuario o Contraseña Invalida");
            }
            else {
                Menu menu = new();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }
    }
}
