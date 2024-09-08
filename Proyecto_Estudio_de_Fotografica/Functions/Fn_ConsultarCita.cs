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
            using (MySqlConnection conn = Database.Abrir_Conexion()) {
                if (conn == null) {
                    MessageBox.Show("No se pudo establecer una conexión a la base de datos.");
                    return;
                }

                try {
                    // Primero obtenemos el cliente_id basado en el nombre completo
                    string queryClienteId =
                        "SELECT ClienteID FROM clientes WHERE CONCAT" +
                        "(Nombre,' ', Apellido_paterno,' ', Apellido_materno) = @NombreCompleto";
                    MySqlCommand cmdClienteId = new(queryClienteId, conn);
                    cmdClienteId.Parameters.AddWithValue("@NombreCompleto", Nombre_Completo);

                    object result = cmdClienteId.ExecuteScalar();
                    if (result == null) {
                        MessageBox.Show("Cliente no encontrado.");
                        return;
                    }
                    int clienteId = Convert.ToInt32(result);

                    // Luego, usamos el cliente_id para buscar las citas
                    string queryCitas = "SELECT * FROM citas WHERE ClienteID = @ClienteID";
                    MySqlCommand cmdCitas = new(queryCitas, conn);
                    cmdCitas.Parameters.AddWithValue("@ClienteID", clienteId);

                    MySqlDataReader reader = cmdCitas.ExecuteReader();

                    // Aquí accedemos al ListView y cargamos las citas (como ya lo haces)
                    ListView lv_CitasCliente = _Menu_Instancia.lv_CitasCliente;
                    lv_CitasCliente.Items.Clear();

                    while (reader.Read()) {
                        ListViewItem item = new(reader["FechaAgendada"].ToString());
                        item.SubItems.Add(reader["HoraAgendada"].ToString());
                        item.SubItems.Add(reader["EstadoCita"].ToString());

                        lv_CitasCliente.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error al cargar citas: " + ex.Message);
                }
            }
        }
    }
}