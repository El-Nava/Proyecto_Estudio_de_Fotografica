using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estudio_de_Fotografica.Functions {
    public static class Fn_Menu {
        
        public static bool No_esta_Vacio(string dato) {
            return !string.IsNullOrWhiteSpace(dato);
        }

        // Método para limpiar los TextBox en el formulario Menu
        public static void LimpiarCampos(Menu menuForm) {
            menuForm.tb_Nombre_Agendar.Clear();
            menuForm.tb_Apellidos_Agendar.Clear();
            menuForm.tb_NumeroDeTelefono_Agendar.Clear();
            menuForm.tb_Altura_Agendar.Clear();
            menuForm.tb_anticipo.Clear();
            menuForm.date_Fecha_Agendar.Value = DateTime.Now;  // Restablecer la fecha actual
            menuForm.date_Hora_Agendar.Value = DateTime.Now;   // Restablecer la hora actual
        }
    }
}
