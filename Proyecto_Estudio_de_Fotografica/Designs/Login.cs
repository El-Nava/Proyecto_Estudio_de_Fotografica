using Proyecto_Estudio_de_Fotografica.Functions;
using System;
using System.Windows.Forms;

namespace Proyecto_Estudio_de_Fotografica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Deshabilitar el botón para evitar múltiples clics
            btn_Login.Enabled = false;

            String user = tb_User.Text;
            String pass = tb_Password.Text;

            try
            {
                if (!Fn_Login.Comprobar(user, pass))
                {
                    MessageBox.Show("Usuario o Contraseña Inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_User.Text = "";
                    tb_Password.Text = "";
                }
                else
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si hay un problema con la conexión
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_User.Text = "";
                tb_Password.Text = "";
            }
            finally
            {
                // Rehabilitar el botón para permitir un nuevo intento
                btn_Login.Enabled = true;
            }
        }
    }
}
