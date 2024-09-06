using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estudio_de_Fotografica.Functions {
    public class Fn_ConsultarCita {
        private readonly Menu? _Menu_Instancia; // Acepta valores null

        // Constructor para pasar la instancia de Menu si es necesario
        public Fn_ConsultarCita(Menu menuInstancia) {
            _Menu_Instancia = menuInstancia;
        }

        public void Consultar_Citas(string Nombre_Completo) {
            // Reutiliza la conexión de la clase Database
            using (MySqlConnection conn = Database.Abrir_Conexion()) {


                if (conn == null) {
                    MessageBox.Show("No se pudo establecer una conexión a la base de datos.");
                    return;
                }

                // Consulta SQL para buscar las citas por nombre completo
                string query = "SELECT CitaID, NombreCompletoCliente, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita " +
                               "FROM citas WHERE NombreCompletoCliente LIKE @NombreCompleto";

                MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@NombreCompleto", "%" + Nombre_Completo + "%");

                try {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Acceder al ListView desde _Menu_Instancia
                    ListView lv_VerCitas = _Menu_Instancia.lv_VerCitas;

                    // Limpiar elementos y columnas existentes
                    lv_VerCitas.Items.Clear();

                    // Leer datos del MySqlDataReader y agregarlos al ListView
                    while (reader.Read()) {
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
                catch (Exception ex) {
                    MessageBox.Show("Error al consultar las citas: " + ex.Message);
                }
            }
        }
    }
}