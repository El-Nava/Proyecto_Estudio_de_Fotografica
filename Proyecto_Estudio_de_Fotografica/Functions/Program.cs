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
            // Agregar usuario y contrase�a por defecto
           

            // Inicializar configuraci�n de la aplicaci�n
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
