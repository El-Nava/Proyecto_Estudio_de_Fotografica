using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto_Estudio_de_Fotografica.Functions
{
    internal class Fn_VerCitas
    {
        private Menu _menuInstance;

        public Fn_VerCitas(Menu menuInstance)
        {
            _menuInstance = menuInstance;
        }

        public void CargarBaseDeDatos(int opcion)
        {
            // Reutiliza la conexión de la clase Database
            using (MySqlConnection conn = Database.Abrir_Conexion())
            {
                if (conn == null)
                {
                    MessageBox.Show("No se pudo establecer una conexión a la base de datos.");
                    return;
                }

                string query;

                // FALTA CORREGIR (El Lunes le doy)
                // Seleccionar la consulta SQL según la opción
                switch (opcion) {
                    case 1: //Ver Todas las Citas
                        query = "SELECT CitaID, ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita FROM citas";
                        break;
                    case 2: // Ver Citas Vencidas
                        query = "SELECT CitaID, ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita " +
                                "FROM citas WHERE EstadoCita != 'Completada' AND CONCAT(FechaAgendada, ' ', HoraAgendada) < NOW()";
                        break;
                    case 3: // Ver Citas del Día
                        query = "SELECT CitaID, ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita " +
                                "FROM citas WHERE DATE(FechaAgendada) = CURDATE()";
                        break;
                    case 4: // Ver Citas Pendientes
                        query = "SELECT CitaID, ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita " +
                                "FROM citas WHERE EstadoCita != 'Completada'";
                        break;
                    default:
                        MessageBox.Show("Opción inválida.");
                        return;
                }

                MySqlCommand cmd = new(query, conn);

                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Acceder al ListView desde _menuInstance
                    ListView lv_VerCitas = _menuInstance.lv_VerCitas;

                    // Establecer la vista en detalles para que se muestren las columnas
                    lv_VerCitas.View = View.Details;

                    // Limpiar elementos y columnas existentes
                    lv_VerCitas.Items.Clear();
                    lv_VerCitas.Columns.Clear();

                    // Configurar columnas del ListView según la estructura de la tabla
                    lv_VerCitas.Columns.Add("Cita ID", 70);
                    lv_VerCitas.Columns.Add("Cliente ID", 80);
                    lv_VerCitas.Columns.Add("Fecha Agendada", 100);
                    lv_VerCitas.Columns.Add("Hora Agendada", 100);
                    lv_VerCitas.Columns.Add("Servicio ID", 80);
                    lv_VerCitas.Columns.Add("Pago", 80);
                    lv_VerCitas.Columns.Add("Estado de Cita", 100);

                    // Leer datos del MySqlDataReader y agregarlos al ListView
                    while (reader.Read())
                    {
                        // Crear un nuevo ListViewItem con el primer dato (CitaID)
                        ListViewItem item = new ListViewItem(reader["CitaID"].ToString());

                        // Añadir los subitems (el resto de los datos)
                        item.SubItems.Add(reader["ClienteID"].ToString());
                        item.SubItems.Add(reader["FechaAgendada"].ToString());
                        item.SubItems.Add(reader["HoraAgendada"].ToString());
                        item.SubItems.Add(reader["ServicioID"].ToString());
                        item.SubItems.Add(reader["Pago"].ToString());
                        item.SubItems.Add(reader["EstadoCita"].ToString());

                        // Añadir el item completo al ListView
                        lv_VerCitas.Items.Add(item);
                    }

                    reader.Close(); // Cierra el reader después de completar la lectura
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
    }
}
