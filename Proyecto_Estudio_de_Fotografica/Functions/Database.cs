using MySql.Data.MySqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Estudio_de_Fotografica.Functions {
    public static class Database {
        // Conexión a Base de Datos
        static String connectionString = "Server=localhost;Database=Un_Instante;User ID=root;Password=studio2024;";

        public static MySqlConnection Abrir_Conexion() {
            try {
                MySqlConnection connection = new(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex) { // Maneja excepciones específicas de MySQL
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                // Puedes volver a lanzar la excepción o manejarla de acuerdo a tus necesidades
                throw;
            }
            catch (Exception ex) {  // Maneja cualquier otra excepción general
                // Aquí puedes manejar excepciones no relacionadas directamente con MySQL
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
                throw;
            }
        }

        public static void Agregar_Cliente(
            string nombre,
            string apellidoPaterno,
            string apellidoMaterno,
            string telefono,
            decimal altura,
            DateTime fechaCita,
            int servicioId,
            decimal monto,
            DateTime fechaPago,
            string metodoPago) {

            using (MySqlConnection connection = Abrir_Conexion()) {
                using (MySqlCommand cmd = new MySqlCommand("add_clientecita", connection)) {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@p_nombre", nombre);
                    cmd.Parameters.AddWithValue("@p_apellidoP", apellidoPaterno);
                    cmd.Parameters.AddWithValue("@p_apellidoM", apellidoMaterno);
                    cmd.Parameters.AddWithValue("@p_telefono", telefono);
                    cmd.Parameters.AddWithValue("@p_altura", altura);
                    cmd.Parameters.AddWithValue("@p_fecha_cita", fechaCita);
                    cmd.Parameters.AddWithValue("@p_servicio_id", servicioId);
                    cmd.Parameters.AddWithValue("@p_monto", monto);
                    cmd.Parameters.AddWithValue("@p_fecha_pago", fechaPago);
                    cmd.Parameters.AddWithValue("@p_metodo_pago", metodoPago);

                    try {
                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex) {
                        Console.WriteLine($"Error al ejecutar el procedimiento almacenado: {ex.Message}");
                        throw;
                    }
                }
            }
        }
    }
}
