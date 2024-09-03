using MySql.Data.MySqlClient;
using Proyecto_Estudio_de_Fotografica.Functions;

namespace Proyecto_Estudio_de_Fotografica
{
    public partial class Menu : Form
    {

        private readonly Fn_VerCitas fn_vercitas;
        public Menu()
        {
            InitializeComponent();
            MaximizeBox = false;

            lv_VerCitas.FullRowSelect = true;
            lv_VerCitas.MultiSelect = false;
            fn_vercitas = new Fn_VerCitas(this);

            // Crea Conexión a Base de Datos
            Database.Abrir_Conexion();
            LoadPaquetes(null, EventArgs.Empty);
        }

        private void btn_AgendarCita_Agendar_Click(object sender, EventArgs e)
        {
            // Crear lista para comprobar campos
            TextBox[] campos = { tb_Nombre_Agendar, tb_Apellidos_Agendar, tb_NumeroDeTelefono_Agendar };

            if (campos.Any(campo => !Fn_Menu.No_esta_Vacio(campo.Text)))
            {
                MessageBox.Show("Dato Faltante", "Ingrese todos los Datos");
            }
            else
            {
                // Separar Apellidos
                string[] Separar_Apellidos = tb_Apellidos_Agendar.Text.Split(' ');
                string Apellido_Paterno = Separar_Apellidos.Length > 0 ? Separar_Apellidos[0] : string.Empty;
                string Apellido_Materno = Separar_Apellidos.Length > 1 ? Separar_Apellidos[1] : string.Empty;

                // Obtener el valor seleccionado del ComboBox
                var paqueteSeleccionado = cb_Paquete_Agendar.SelectedValue;
                if (paqueteSeleccionado != null)
                {
                    float altura;
                    float anticipo;

                    // Intentar convertir los valores de los TextBox a float
                    bool alturaValida = float.TryParse(tb_Altura_Agendar.Text, out altura);
                    bool anticipoValido = float.TryParse(tb_anticipo.Text, out anticipo);
                    MessageBox.Show(date_Hora_Agendar.Text);
                    if (alturaValida && anticipoValido)
                    {
                        string fecha = date_Fecha_Agendar.Text; // Usar Value para obtener la fecha
                        string hora = date_Hora_Agendar.Text; // Usar Value para obtener la hora

                        // Verificar si ya existe una cita en la misma fecha y hora
                        if (!Database.ExisteCita(fecha, hora))
                        {
                            Database.Agregar_Cliente(
                                tb_Nombre_Agendar.Text,  // Cambiado a Text en lugar de ToString()
                                Apellido_Paterno,
                                Apellido_Materno,
                                tb_NumeroDeTelefono_Agendar.Text,  // Cambiado a Text en lugar de ToString()
                                altura,
                                fecha,
                                hora,
                                Convert.ToInt32(paqueteSeleccionado),
                                anticipo
                            );
                        }
                        else
                        {
                            MessageBox.Show("Ya existe una cita programada en esta fecha y hora. Por favor, elija otra.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese valores válidos para altura y anticipo.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un paquete.");
                }
            }

            // Limpiar Espacios de las Texts Box
            Fn_Menu.LimpiarCampos(this);
        }

        private void LoadPaquetes(object? sender, EventArgs e)
        {
            var datos = Database.Servicios();

            cb_Paquete_Agendar.DisplayMember = "Value";
            cb_Paquete_Agendar.ValueMember = "Key";
            cb_Paquete_Agendar.DataSource = datos;
        }

        // ------------------ Proceso de Pestaña de "Ver Citas Agendadas" -----------------------------
        private void lv_VerCitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_EliminarDato_Click(object sender, EventArgs e)
        {
            // Verifica si hay un elemento seleccionado en el ListView
            if (lv_VerCitas.SelectedItems.Count > 0)
            {
                // Obtén el ID de la cita seleccionada (asumiendo que es la primera columna)
                string citaID = lv_VerCitas.SelectedItems[0].Text;

                // Confirma la eliminación con el usuario
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta cita?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Llama al método para eliminar la cita de la base de datos
                    EliminarDato(citaID);

                    // Refresca el ListView para reflejar los cambios
                    fn_vercitas.CargarBaseDeDatos(1);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita para eliminar.");
            }
        }

        private static void EliminarDato(string citaID)
        {
            using (MySqlConnection conn = Database.Abrir_Conexion())
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer una conexión a la base de datos.");
                    return;
                }

                string query = "DELETE FROM citas WHERE CitaID = @CitaID";
                MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@CitaID", citaID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cita eliminada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la cita: " + ex.Message);
                }
            }
        }

        private void btn_VerTodas_VerCitas_Click(object sender, EventArgs e)
        {
            fn_vercitas.CargarBaseDeDatos(1);
        }

        private void bt_CitasVencidas_VerCitas_Click(object sender, EventArgs e)
        {
            lv_VerCitas.Items.Clear();
            fn_vercitas.CargarBaseDeDatos(2);
        }

        private void bt_CitasdelDia_VerCitas_Click(object sender, EventArgs e)
        {
            lv_VerCitas.Items.Clear();
            fn_vercitas.CargarBaseDeDatos(3);
        }

        private void bt_CitasPendientes_VerCitas_Click(object sender, EventArgs e)
        {
            lv_VerCitas.Items.Clear();
            fn_vercitas.CargarBaseDeDatos(4);
        }
    }
}
