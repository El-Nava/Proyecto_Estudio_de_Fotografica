﻿using MySql.Data.MySqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Estudio_de_Fotografica.Functions {
    public static class Database {
        // Conexión a Base de Datos
        static string[] connectionStrings = {
            "Server=localhost;Database=un_instante;User ID=root;Password=JesusNava(15);",//Conexion Nava
            "Server=localhost;Database=un_instante;User ID=root;Password='h)~e6q?5;~CWk/><hVJ';", //Conexion Jorge
            "Server=localhost;Database=un_instante;User ID=root;Password='20200321a';"//Conexion Diego
        };

        public static MySqlConnection Abrir_Conexion() {

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
            DateTime fechaCita,
            int servicioId,
            float monto,
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
        // --------------------- Sección de Ver Citas Agendadas ------------------------------
        public class Cita {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public DateTime FechaCita { get; set; }
            public string Paquete { get; set; }
            public float Monto { get; set; }
        }

        public static List<Cita> ObtenerCitas() {
            var citas = new List<Cita>();

            using (MySqlConnection connection = Abrir_Conexion()) {
                using (MySqlCommand cmd = new MySqlCommand("SELECT CitaID, Nombre,"
                        + "Apellido_paterno, Apellido_materno, FechaAgendada,"
                        + "NombreServicio FROM view_citas_pendientes", connection)) {
                    try {
                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                var cita = new Cita {
                                    Id = reader.GetInt32("CitaID"),
                                    Nombre = reader.GetString("Nombre"),
                                    ApellidoPaterno = reader.GetString("Apellido_paterno"),
                                    ApellidoMaterno = reader.GetString("Apellido_materno"),
                                    FechaCita = reader.GetDateTime("FechaAgendada"),
                                    Paquete = reader.GetString("NombreServicio"),
                                    Monto = 0 // Como la vista no incluye monto, se pone 0
                                };
                                citas.Add(cita);
                            }
                        }
                    }
                    catch (MySqlException ex) {
                        Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                        throw;
                    }
                }
            }

            return citas;
        }
    }
}
