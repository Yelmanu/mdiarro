using mdiarro.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro.Servicios
{
    /// <summary>
    /// Interfaz que se va a encargar de toda la operativa en torno a la vajilla(añadir, eliminar y mostrar)
    /// 041223 - MDN
    /// </summary>
    internal interface VajillaInterfaz
    {
        /// <summary>
        /// Método para dar de alta un nuevo elemento vajilla
        /// 041223 - MDN
        /// </summary>
        /// <param name="listaElementos"></param>
        public void añadirElementoVajilla(List<VajillaDto> listaElementos);

        /// <summary>
        /// Método para eliminar cantidad de elemento vajilla
        /// 041223 - MDN
        /// </summary>
        /// <param name="listaElementos"></param>
        public void eliminarElementoVajilla(List<VajillaDto> listaElementos);
    }
}
