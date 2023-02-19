using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //Se crea todas las propiedades(BD) de la clase Producto
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca oMarca { get; set; }
        //oMarca = Objeto de la clase marca referenciando al IdMarca
        public Categoria oCategoria { get; set; }
        //oCategoria = Objeto de la clase Categoria referenciando al IdCategoria
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }
    }
}
