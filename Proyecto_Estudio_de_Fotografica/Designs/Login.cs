using Proyecto_Estudio_de_Fotografica.Functions;

namespace Proyecto_Estudio_de_Fotografica
{
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            String user = tb_User.Text;
            String pass = tb_Password.Text;

            if (!Fn_Login.Comprobar(user, pass)) {
                MessageBox.Show("Error", "Usuario o Contraseña Invalida");
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
