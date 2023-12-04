using mdiarro.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la operativa de la aplicación
    /// 041223 - MDN
    /// </summary>
    internal class VajillaImplementacion : VajillaInterfaz
    {

        MenuInterfaz mi = new MenuImplementacion();

        /// <summary>
        /// Método para añadir a la lista nuevos elementos vajilla
        /// 041223 - MDN
        /// </summary>
        /// <param name="listaElementos"></param>
        public void añadirElementoVajilla(List<VajillaDto> listaElementos)
        {
            VajillaDto vajilla = nuevoElementoVajilla();

            listaElementos.Add(vajilla);
        }

        public void eliminarElementoVajilla(List<VajillaDto> listaElementos)
        {
            string codigoABuscar = mi.pedirCodigoElemento();

            foreach(VajillaDto vajilla in listaElementos)
            {
                if (vajilla.CodigoElemento.Equals(codigoABuscar))
                {
                    Console.WriteLine("Indique la cantidad a eliminar: ");
                    int numeroARestar = Convert.ToInt32(Console.ReadLine());
                    vajilla.CantidadElemento -= numeroARestar;
                }
            }
        }

        /// <summary>
        /// Método para crear un nuevo elemento vajilla 
        /// 041223 - MDN
        /// </summary>
        /// <returns></returns>
        private VajillaDto nuevoElementoVajilla()
        {
            VajillaDto nuevaVajilla = new VajillaDto();

            Console.WriteLine("Introduzca el id del elemento: ");
            nuevaVajilla.IdElemento = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del elemento: ");
            nuevaVajilla.NombreElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la descripcion del elemento: ");
            nuevaVajilla.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la cantidad del elemento: ");
            nuevaVajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());
            nuevaVajilla.CodigoElemento = nuevaVajilla.IdElemento + nuevaVajilla.NombreElemento;
            return nuevaVajilla;
        }
    }
}
