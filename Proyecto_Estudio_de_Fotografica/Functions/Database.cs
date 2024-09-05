using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Estudio_de_Fotografica.Functions
{
    public static class Database
    {
        // Conexión a Base de Datos
        static string[] connectionStrings = {
            "Server=localhost;Database=uninstante;User ID=root;Password=JesusNava(15);",//Conexion Nava
            "Server=localhost;Database=uninstante;User ID=root;Password='h)~e6q?5;~CWk/><hVJ';", //Conexion Jorge
            "Server=localhost;Database=uninstante;User ID=root;Password='20200321a';"//Conexion Diego
        };


        public static MySqlConnection Abrir_Conexion()
        {

            MySqlConnection connection = null!;

            foreach (string connectionString in connectionStrings)
            {
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    Console.WriteLine($"Conexión exitosa con: {connection.DataSource}");
                    // Llama a la función que actualiza el estado de las citas
                    ActualizarEstadoCitas(connection);
                    return connection;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"No se pudo conectar con: {connectionString}");
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            return null!;
        }

        public static void ActualizarEstadoCitas(MySqlConnection connection)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("SET SQL_SAFE_UPDATES = 0;CALL actualizar_estado_citas();SET SQL_SAFE_UPDATES = 1;", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    // Ejecuta el procedimiento almacenado
                    command.ExecuteNonQuery();

                    Console.WriteLine("Procedimiento almacenado ejecutado exitosamente.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
        }
        public static void Agregar_Cliente(
            string nombre,
            string apellidoPaterno,
            string apellidoMaterno,
            string telefono,
            float altura,
            string fechaCita,
            string horaAgendada,
            int servicioId,
            double anticipo)
        {

            using (MySqlConnection connection = Abrir_Conexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("InsertarDatos_AgendarCitas", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@p_nombre", nombre);
                    cmd.Parameters.AddWithValue("@p_apellidoP", apellidoPaterno);
                    cmd.Parameters.AddWithValue("@p_apellidoM", apellidoMaterno);
                    cmd.Parameters.AddWithValue("@p_telefono", telefono);
                    cmd.Parameters.AddWithValue("@p_altura", altura);
                    cmd.Parameters.AddWithValue("@p_fecha_cita", fechaCita);
                    cmd.Parameters.AddWithValue("@p_Hora_cita", horaAgendada);
                    cmd.Parameters.AddWithValue("@p_servicio_id", servicioId);
                    cmd.Parameters.AddWithValue("@Pago", anticipo);

                    try
                    {
                        // Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al ejecutar el procedimiento almacenado: {ex.Message}");
                        throw;
                    }
                }
            }
        }

        public static List<KeyValuePair<int, string>> Servicios()
        {
            var resultado = new List<KeyValuePair<int, string>>();

            using (MySqlConnection connection = Abrir_Conexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * from servicio", connection))
                {
                    try
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0); // Asumiendo que el ID está en la primera columna
                                string nombre = reader.GetString(1); // Asumiendo que el nombre está en la segunda columna
                                resultado.Add(new KeyValuePair<int, string>(id, nombre));
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                        throw;
                    }
                }
            }

            return resultado;
        }

        
        public static bool ExisteCita(string fecha, string hora)
        {
            bool citaExiste = false;

            using (MySqlConnection connection = Abrir_Conexion())
            {
                using (MySqlCommand cmd = new MySqlCommand("Citasrepetidas", connection))
                {
                    // Especificar que es un procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@hora", hora);

                    // Agregar parámetro de salida
                    MySqlParameter outputParam = new MySqlParameter("@totalCitas", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    // Ejecutar el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtener el valor del parámetro de salida
                    int count = Convert.ToInt32(outputParam.Value);
                    citaExiste = (count > 0);
                }
            }

            return citaExiste;
        }




        // --------------------- Sección de Ver Citas Agendadas ------------------------------

    }
}
