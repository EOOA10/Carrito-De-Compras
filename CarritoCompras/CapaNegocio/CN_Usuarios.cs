using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias a las capas Datos y Entidad para hacer llamados de los elementos que estan dentro de las capas
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        //Acceso a todos los metodos de la clase CD_Usuarios
        private CD_Usuarios objCapaDato = new CD_Usuarios();

        //Metodo que retorna el listado de la clase CD_Usuarios
        public List<Usuario> Listar()
        {
            return objCapaDato.Listar();
        }
    }
}
