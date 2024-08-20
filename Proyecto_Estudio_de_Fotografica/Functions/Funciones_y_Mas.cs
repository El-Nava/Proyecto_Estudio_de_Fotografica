namespace Proyecto_Estudio_de_Fotografica.Functions
{
    public static class Funciones_y_Mas
    {
        static string Usuario = "u";
        static string Contra = "123";

        public static bool Comprobar(string user, string pass)
        {
            if (Usuario == user || Contra == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
