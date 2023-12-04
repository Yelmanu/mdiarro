using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del menú
    /// 041223 - MDN
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método para mostrar el menú
        /// 041223 - MDN
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0. Cerrar Menú");
            Console.WriteLine("1. Añadir Elemento");
            Console.WriteLine("2. Modificar cantidad Elemento");

            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionada;
        }
    }
}
