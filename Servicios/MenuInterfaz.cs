using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro.Servicios
{
    /// <summary>
    /// Interfaz que se encargará de la funcionalidad del menú
    /// 041223 - MDN
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método para mostrar el menú
        /// 041223 - MDN
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();

        /// <summary>
        /// Método para pedir el codigo del elemento a modificar en cantidad
        /// 041223 - MDN
        /// </summary>
        /// <returns></returns>
        public string pedirCodigoElemento()
        {
            Console.WriteLine("Indica el código del elemento: ");
            string codigoElemento = Console.ReadLine();
            return codigoElemento;
        }
    }
}
