using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estudio_de_Fotografica.Functions
{
    internal class Fn_ConsultarCita
    {
        private Menu _menuInstance;

        public Fn_ConsultarCita(Menu menuInstance)
        {
            _menuInstance = menuInstance;
        }
        public void CargarConsulta()
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

                MySqlCommand cmd = new(query, conn);

                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Acceder al ListView desde _menuInstance
                    ListView lv_VerCitas = _menuInstance.lv_VerCitas;

                    // Limpiar elementos y columnas existentes
                    lv_VerCitas.Items.Clear();

                    // Leer datos del MySqlDataReader y agregarlos al ListView
                    while (reader.Read())
                    {
                        // Crear un nuevo ListViewItem con el primer dato (CitaID)
                        ListViewItem item = new ListViewItem(reader["CitaID"].ToString());

                        // Añadir los subitems (el resto de los datos)
                        item.SubItems.Add(reader["NombreCompletoCliente"].ToString());
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
