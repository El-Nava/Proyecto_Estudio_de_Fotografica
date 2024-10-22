using MySql.Data.MySqlClient;
using Proyecto_Estudio_de_Fotografica.Functions;
using System.Collections;
using System.Windows.Forms;


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

                            // Limpiar Base de Datos
                            Fn_Menu.LimpiarCampos(this);
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

        private static void EliminarDato(string clienteID)
        {
            using (MySqlConnection conn = Database.Abrir_Conexion())
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer una conexión a la base de datos.");
                    return;
                }

                // Asegúrate de que el nombre del procedimiento coincida con el que tienes en la base de datos
                string query = "CALL Eliminarcliente(@ClienteID)";
                MySqlCommand cmd = new(query, conn);

                // Asigna el parámetro al comando
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);

                try
                {
                    // Ejecuta el comando
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Citas del cliente eliminadas exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar las citas: " + ex.Message);
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



        // ------------------------- Proceso de Pestaña "Consultar Citas" ----------------------
        public void btn_ConsultarCita_Consultar_Click(object sender, EventArgs e)
        {
            Fn_ConsultarCita _Consulta = new(this);
            _Consulta.Consultar_Citas(tb_NombreCompleto_Consulta.Text);
        }


        // --------------------- PROCESO DE COMPROBACIÓN ----------------------------------------
        // Aplicar Mayusculas al Escribir
        public static void Mayus(TextBox sender)
        {
            // Establecer el texto siempre en mayúsculas
            if (sender is TextBox textBox)
            {
                int posicionCursor = textBox.SelectionStart; // Guarda la posición del cursor
                textBox.Text = textBox.Text.ToUpper();       // Convierte todo el texto a mayúsculas
                textBox.SelectionStart = posicionCursor;     // Restaura la posición del cursor
            }
        }
        private void tb_Nombre_Agendar_TextChanged(object sender, EventArgs e)
        {
            Mayus(tb_Nombre_Agendar);
        }

        private void tb_Apellidos_Agendar_TextChanged(object sender, EventArgs e)
        {
            Mayus(tb_Apellidos_Agendar);
        }

        private void tb_NombreCompleto_Consulta_TextChanged(object sender, EventArgs e)
        {
            Mayus(tb_NombreCompleto_Consulta);
        }

        // Key Press para solo Admitir Números en Cel
        private void tb_NumeroDeTelefono_Agendar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado es un número o una tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es número ni control, cancela el evento (evita que se escriba)
                e.Handled = true;
            }
        }

        private void tb_Altura_Agendar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un dígito, backspace o los separadores permitidos (punto o coma)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Asegura que solo haya un separador (punto o coma)
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void tb_anticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número (controla números del 0 al 9)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea el carácter si no es número, punto o tecla de control (como borrar)
            }

            // Permite un solo punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true; // Si ya hay un punto en el texto, bloquea cualquier otro
            }
        }

        // ----------------- ORGANIZAR ITEMS DE VER CITAS COMO SE DESEE --------------------------
        private SortOrder sortOrder = SortOrder.None;
        private int sortColumn = -1;
        private void lv_VerCitas_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Si la columna es la misma, alternar el orden
            if (e.Column == sortColumn)
            {
                sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Si es una columna diferente, por defecto ordenar ascendente
                sortColumn = e.Column;
                sortOrder = SortOrder.Ascending;
            }

            // Asignar el nuevo comparador al ListView
            lv_VerCitas.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
        }

    }
}

public class ListViewItemComparer : IComparer {
    private int col; // Columna que será comparada
    private SortOrder order; // Orden ascendente o descendente

    // Constructor que toma la columna a comparar y el orden
    public ListViewItemComparer(int column, SortOrder order) {
        col = column;
        this.order = order;
    }

    // Implementación del método Compare para la interfaz IComparer
    public int Compare(object x, object y) {
        int returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);

        // Si el orden es descendente, invierte el valor de comparación
        if (order == SortOrder.Descending) {
            returnVal *= -1;
        }

        return returnVal;
    }
}
