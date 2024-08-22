using Proyecto_Estudio_de_Fotografica.Functions;

namespace Proyecto_Estudio_de_Fotografica{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

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
                    MessageBox.Show(cb_metodo.ToString());
                    if (alturaValida && anticipoValido)
                    {
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
                            cb_metodo.ToString()
                        );
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
        }

    private void LoadPaquetes(object? sender, EventArgs e)
        {
            var datos = Database.Servicios();

            cb_Paquete_Agendar.DisplayMember = "Value";
            cb_Paquete_Agendar.ValueMember = "Key";
            cb_Paquete_Agendar.DataSource = datos;

        }

    }

}
