using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.DAOs;
using VeterinariaServices.Models;

namespace VeterinariaServices.Containers
{
    public class ContenedorUsuarios
    {   
        //Atributos
            public List<Usuario> Usuarios { get; private set; }
            private DAOUsuarios _daoUsuarios;
            //Constructor
            public ContenedorUsuarios()
            {
                _daoUsuarios = new DAOUsuarios();
                Usuarios = new List<Usuario>();
                RefreshUsuarios();
            }

            //Metodos

            /// Este metodo actualiza la lista de usuarios.
            ///Cada vez que se necesite actualizar la lista para obtenerla completa y actualizada.
            /// Este metodo servirá luego de ejecutar modificaciones o eliminar y matener tanto nuestra lista del container como la tabla, con la misma informacion.
            /// </summary>
            public void RefreshUsuarios()
            {
                Usuarios = _daoUsuarios.GetAll();
            }
            /// <summary>
            /// Este método busca un usuario por su nombre de usuario.
            /// </summary>
            /// <param name="username">Nombre de usuario a buscar</param>
            /// <returns>Retorna el objeto Usuario si lo encuentra, de lo contrario retorna null.</returns>
            public Usuario GetUsuarioByUsername(string username)
            {
                return Usuarios.FirstOrDefault(usuario => usuario.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase));
            }

            /// <summary>
            /// Este método retorna la lista de usuarios.
            /// </summary>
            /// <returns>Retorna la lista completa de usuarios.</returns>
            public List<Usuario> GetAllUsuarios()
            {
                return Usuarios;
            }

            /// <summary>
            /// Este método retorna la lista de usuarios sin las contrasenas.
            /// </summary>
            /// <returns>Retorna la lista de usuarios con nombre y username.</returns>
            public List<Usuario> GetUsuariosListadoCompleto()
            {
                return _daoUsuarios.GetAllSinPass();
            }
            /// <summary>
            /// Este método retorna la lista de usuarios que el estado sea Activo
            /// </summary>
            /// <returns>Retorna la lista de usuarios Activos.</returns>
            public List<Usuario> GetUsuariosListadoActivos()
                {
                    var ListaUsuarioSinPas = _daoUsuarios.GetAllSinPass();
                    var listadoActivos = new List<Usuario>();

                    foreach (Usuario Usuario in ListaUsuarioSinPas)
                    {
                        if (Usuario.Estado == "ACTIVO")
                        {
                            listadoActivos.Add(Usuario);
                        }
                    }
                    return listadoActivos;
            }
            /// <summary>
            /// Este método retorna la lista de usuarios que el estado sea Inactivo
            /// </summary>
            /// <returns>Retorna la lista de usuarios Inactivos.</returns>
        public List<Usuario> GetUsuariosListadoInactivos()
        {
            var ListaUsuarioSinPas = _daoUsuarios.GetAllSinPass();
            var listadoInactivos = new List<Usuario>();

            foreach (Usuario Usuario in ListaUsuarioSinPas)
            {
                if (Usuario.Estado == "INACTIVO")
                {
                    listadoInactivos.Add(Usuario);
                }
            }
            return listadoInactivos;
        }

        /// <summary>
        /// Este método retorna la lista de usuarios que el estado sea Activo
        /// </summary>
        /// <returns>Retorna la lista de usuarios Activos.</returns>
        public List<Usuario> GetAllActivos()
            {
                var ListaUsurios = _daoUsuarios.GetAll();
                var ListaActivos = new List<Usuario>();

                foreach (Usuario Usuario in ListaUsurios)
                {
                    if (Usuario.Estado == "ACTIVO")
                    {
                        ListaActivos.Add(Usuario);
                    }
                }
                return ListaActivos;
            }

            public bool ExisteUsername(string username)
            {
                var listaUsuarios = _daoUsuarios.GetAll();

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        }




   
}
