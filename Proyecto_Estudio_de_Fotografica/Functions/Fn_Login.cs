namespace Proyecto_Estudio_de_Fotografica.Functions
{
    public static class Fn_Login
    {
        static string Usuario = "1";
        static string Contra = "1";

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
