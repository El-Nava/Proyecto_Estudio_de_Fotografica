namespace Proyecto_Estudio_de_Fotografica
{
    public static class Funciones_y_Mas {
        static String Usuario = "u";
        static String Contra = "123";

        public static bool Comprobar(String user, String pass) {
            if (Usuario == user || Contra == pass) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    
}
