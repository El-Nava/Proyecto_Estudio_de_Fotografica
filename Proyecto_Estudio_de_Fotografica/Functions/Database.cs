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
            string query = "SELECT COUNT(*) FROM Citas WHERE FechaAgendada = @fecha AND HoraAgendada = @hora";

            using (MySqlConnection connection = Abrir_Conexion())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@hora", hora);

                    //connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    citaExiste = (count > 0);
                }
            }
            return citaExiste;
        }



        // --------------------- Sección de Ver Citas Agendadas ------------------------------

    }
}
