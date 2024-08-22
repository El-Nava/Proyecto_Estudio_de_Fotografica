using Proyecto_Estudio_de_Fotografica.Functions;

namespace Proyecto_Estudio_de_Fotografica{
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();

            // Crea Conexión a Base de Datos
            Database.Abrir_Conexion();
            Database.Servicios();
        }

        private void btn_AgendarCita_Agendar_Click(object sender, EventArgs e) {
            // Crear lista para comprobar campos
            TextBox[] campos = { tb_Nombre_Agendar, tb_Apellidos_Agendar, tb_NumeroDeTelefono_Agendar };

            if (campos.Any(campo => !Fn_Menu.No_esta_Vacio(campo.Text))) {

                MessageBox.Show("Dato Faltante", "Ingrese todos los Datos");
            }
            else {
                // Separar Apellidos
                string[] Separar_Apellidos = tb_Apellidos_Agendar.Text.Split(' ');
                string Apellido_Paterno = Separar_Apellidos.Length > 0 ? Separar_Apellidos[0] : string.Empty;
                string Apellido_Materno = Separar_Apellidos.Length > 1 ? Separar_Apellidos[1] : string.Empty;

                // Tomar Paquete e Introducir a Data Base
                string[] Separar_Paquete = tb_Apellidos_Agendar.Text.Split(' ');
                string Numero_de_Paq = Separar_Paquete.Length > 1 ? Separar_Paquete[1] : string.Empty;

                Database.Agregar_Cliente(
                    tb_Nombre_Agendar.Text,
                    Apellido_Paterno,
                    Apellido_Materno,
                    tb_NumeroDeTelefono_Agendar.Text,
                    tb_Altura_Agendar,
                    date_Fecha_Agendar,
                    





                )
            }
        }

        private void cb_Paquete_Agendar_SelectedIndexChanged(object sender, EventArgs e) {
            Database.Servicios();
        }
    }

}
