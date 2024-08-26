using Proyecto_Estudio_de_Fotografica.Functions;

namespace Proyecto_Estudio_de_Fotografica{
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
            MaximizeBox = false;

            // Crea Conexión a Base de Datos
            Database.Abrir_Conexion();
            LoadPaquetes(null, EventArgs.Empty);

            // Configura las Columnas de la Tabla de Ver Citas Agendadas al Iniciar Programa
            ConfigurarListView();

            // Carga las Citas por 1era vez (lo hará despúes cd Segundo Gracias al Contador)
            CargarCitas();
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

                // Obtener el valor seleccionado del ComboBox
                var paqueteSeleccionado = cb_Paquete_Agendar.SelectedValue;
                if (paqueteSeleccionado != null) {
                    float altura;
                    float anticipo;

                    // Intentar convertir los valores de los TextBox a float
                    bool alturaValida = float.TryParse(tb_Altura_Agendar.Text, out altura);
                    bool anticipoValido = float.TryParse(tb_anticipo.Text, out anticipo);
                    MessageBox.Show(cb_metodo.SelectedItem.ToString());
                    if (alturaValida && anticipoValido) {
                        Database.Agregar_Cliente(
                            tb_Nombre_Agendar.Text,  // Cambiado a Text en lugar de ToString()
                            Apellido_Paterno,
                            Apellido_Materno,
                            tb_NumeroDeTelefono_Agendar.Text,  // Cambiado a Text en lugar de ToString()
                            altura,
                            date_Fecha_Agendar.Value,  // Usado Value en lugar de DateTimePicker
                            Convert.ToInt32(paqueteSeleccionado),
                            anticipo,
                            date_liquidar.Value,  // Usado Value en lugar de DateTimePicker
                            cb_metodo.SelectedItem.ToString()
                        );
                    }
                    else {
                        MessageBox.Show("Por favor, ingrese valores válidos para altura y anticipo.");
                    }
                }
                else {
                    MessageBox.Show("Por favor, seleccione un paquete.");
                }
            }
        }

        private void LoadPaquetes(object? sender, EventArgs e) {
            var datos = Database.Servicios();

            cb_Paquete_Agendar.DisplayMember = "Value";
            cb_Paquete_Agendar.ValueMember = "Key";
            cb_Paquete_Agendar.DataSource = datos;
        }

        private void t_Actualizar_Citas_VerCitas_Tick(object sender, EventArgs e) {
            CargarCitas(); // Actualiza si hay nuevas Citas cada 1 Segundo de acuerdo al Timer
        }

        // ------------------ Proceso de Pestaña de "Ver Citas Agendadas" -----------------------------
        private void CargarCitas() {
            var citas = Database.ObtenerCitas();
            lv_VerCitas.Items.Clear();

            foreach (var cita in citas) {
                var item = new ListViewItem(cita.Id.ToString());
                item.SubItems.Add(cita.Nombre);
                item.SubItems.Add(cita.ApellidoPaterno);
                item.SubItems.Add(cita.ApellidoMaterno);
                item.SubItems.Add(cita.FechaCita.ToString("dd/MM/yyyy"));
                item.SubItems.Add(cita.Paquete);

                lv_VerCitas.Items.Add(item);
            }
        }


        // --- Configuras las Columnas que van en la List View ---
        private void ConfigurarListView() {
            lv_VerCitas.View = View.Details;
            lv_VerCitas.Columns.Add("ID", 50);
            lv_VerCitas.Columns.Add("Nombre", 150);
            lv_VerCitas.Columns.Add("Apellido Paterno", 150);
            lv_VerCitas.Columns.Add("Apellido Materno", 150);
            lv_VerCitas.Columns.Add("Fecha de Cita", 150);
            lv_VerCitas.Columns.Add("Paquete", 150);
        }
    }
}
