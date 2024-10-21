using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Estudio_de_Fotografica.Functions
{
    public static class Fn_Login
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool AgregarUsuario(string usuario, string contraseña)
        {
            string hashedPassword = HashPassword(contraseña);

            using (MySqlConnection connection = Database.Abrir_Conexion())
            {
                if (connection == null)
                {
                    Console.WriteLine("No se pudo establecer la conexión con la base de datos.");
                    return false;
                }

                try
                {
                    string query = "INSERT INTO encrypt (loginUsuario, loginContraseña) VALUES (@usuario, @contraseña)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", hashedPassword);

                        // Ejecutar la inserción
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Comprobar si la inserción fue exitosa
                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error al insertar en la base de datos: {ex.Message}");
                    return false;
                }
            }
        }
        public static bool Comprobar(string usuario, string contraseña)
        {
            string hashedPassword = HashPassword(contraseña);

            using (MySqlConnection connection = Database.Abrir_Conexion())
            {
                if (connection == null)
                {
                    Console.WriteLine("No se pudo establecer la conexión con la base de datos.");
                    return false;
                }

                try
                {
                    string query = "SELECT COUNT(*) FROM encrypt WHERE loginUsuario = @usuario AND loginContraseña = @contraseña";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", hashedPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error al comprobar las credenciales: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
