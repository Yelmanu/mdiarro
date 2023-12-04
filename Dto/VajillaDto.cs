using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdiarro.Dto
{
    /// <summary>
    /// Clase para declarar el objeto Vajilla
    /// 041223 - MDN
    /// </summary>
    internal class VajillaDto
    {
        //Atributos
        long idElemento;

        private string codigoElemento = "aaaa";

        private string nombreElemento = "aaaa";

        private string descripcionElemento = "aaaa";

        private int cantidadElemento = 0;

        //Getters y Setters
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //Constructores
        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public VajillaDto() 
        {
            
        }
        //To String
        override
            public string ToString()
        {
            string vajillaString = "Id Elemento:" + this.idElemento
                + " Codigo Elemento:" + this.codigoElemento
                + " Nombre Elemento:" + this.nombreElemento
                + " Descripcion Elemento:" + this.descripcionElemento
                + " Cantidad Elemento:" + this.cantidadElemento;
            return vajillaString;
        }

    }
}
