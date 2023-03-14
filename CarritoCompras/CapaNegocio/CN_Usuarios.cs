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

        //Metodo que retorna el registro de usuarios de la clase CD_Usuarios
        public int Registrar(Usuario obj, out string Mensaje) 
        {
            Mensaje = string.Empty;

            //Validacion de campos vacios
            if(string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El Nombre del Usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Apellido) || string.IsNullOrWhiteSpace(obj.Apellido))
            {
                Mensaje = "El Apellido del Usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "El Correo del Usuario no puede ser vacio";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                string clave = "test123";
                //Encriptacion de contraseña
                obj.Clave = CN_Recursos.ConvertirSha256(clave);

                return objCapaDato.Registrar(obj, out Mensaje);
            }
            else
            {
                return 0;
            }
        }

        //Metodo que retorna la modificacion de usuarios de la clase CD_Usuarios
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            //Validacion de campos vacios
            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El Nombre del Usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Apellido) || string.IsNullOrWhiteSpace(obj.Apellido))
            {
                Mensaje = "El Apellido del Usuario no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje = "El Correo del Usuario no puede ser vacio";
            }


            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCapaDato.Editar(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }

        //Metodo que retorna la Eliminacion de usuarios de la clase CD_Usuarios
        public bool Eliminar(int id, out string Mensaje)
        {
            return objCapaDato.Eliminar(id, out Mensaje);
        }
    }
}
