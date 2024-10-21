namespace Proyecto_Estudio_de_Fotografica.Functions
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Agregar usuario y contraseña por defecto
           

            // Inicializar configuración de la aplicación
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
