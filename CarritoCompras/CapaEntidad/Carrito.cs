using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //Se crea todas las propiedades(BD) de la clase Carrito
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Cliente oCliente { get; set; }
        //oCliente = Objeto de la clase Cliente referenciando al IdCliente
        public Producto oProducto { get; set; }
        //oProducto = Objeto de la clase Producto referenciando al IdProducto
        public int Cantidad { get; set; }
    }
}
