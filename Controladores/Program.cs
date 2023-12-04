using mdiarro.Dto;
using mdiarro.Servicios;

namespace mdiarro.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 041223 - MDN
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método controlador de la aplicación
        /// 041223 - MDN
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos las listas necesarias
            List<VajillaDto> listaElementos = new List<VajillaDto>();

            //Instanciamos las clases que contienen los métodos
            MenuInterfaz mi = new MenuImplementacion();
            VajillaInterfaz vi = new VajillaImplementacion();

            //Declaramos variables necesarias
            bool cerrarMenu = false;
            int opcionSeleccionada;

            do
            {
                opcionSeleccionada = mi.mostrarMenu();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] DAR ALTA NUEVO ELEMENTO");
                        vi.añadirElementoVajilla(listaElementos);
                        foreach (VajillaDto vajilla in listaElementos)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("[INFO] ELIMINAR CANTIDAD ELEMENTOS");
                        vi.eliminarElementoVajilla(listaElementos);
                        foreach(VajillaDto vajilla in listaElementos)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFO] LA OPCION SELECCIONADA NO ES VÁLIDA");
                        break;
                }
            } while (!cerrarMenu);
        }
    }
}