using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.Models;

namespace VeterinariaServices.DAOs
{
    public class DAOUsuarios
    {
        //Metodos

        /// <summary>
        /// Este Metodo realiza una conexion a la DB a partir del connectionString
        /// </summary>
        ///<returns>Retorna la conexion a DB</returns>
        private IDbConnection prepararConexion()
        {
            string connectionString = "Server=PCGAMINGALAN\\SQLEXPRESS; Database=VeterinariaDB; Integrated Security =true";

            SqlConnection conexion = new SqlConnection(connectionString);

            conexion.Open();

            return conexion;
        }

        /// <summary>
        /// Este Metodo Trae de la DB la tabla de todos los Usuarios
        /// </summary>
        ///<returns>Retorna una lista de usuarios.</returns>
        public List<Usuario> GetAll()
        {
            IDbConnection conexion = this.prepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "SELECT ID,USERNAME, NOMBRE, CLAVE, ESTADO, TIPO_USUARIO FROM USUARIOS";

            IDataReader lector = comando.ExecuteReader();

            var ListaUsuarios = new List<Usuario>();

            while (lector.Read())
            {
                Usuario usuario = new Usuario()
                {
                    Id = lector.GetInt32(0),
                    Username = lector.GetString(1),
                    Nombre = lector.GetString(2),
                    Password = lector.GetString(3),
                    Estado = lector.GetString(4),
                    TipoUsuario = lector.GetString(5),
                };
                ListaUsuarios.Add(usuario);
            }
            conexion.Close();

            return ListaUsuarios;
        }
        /// <summary>
        /// Este Metodo realiza una query para insertar un usuario en la DB y verifica que se haya afectado la tabla correctamente
        /// </summary>
        /// <param name="usuario">Recibe un objeto Usuario para sea agregado a la DB</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Insert(Usuario usuario)
        {
            string query = $"INSERT INTO USUARIOS (USERNAME,NOMBRE,CLAVE) VALUES ('{usuario.Username}', '{usuario.Nombre}', '{usuario.Password}')";

            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = query;
            int RowsAffected = comando.ExecuteNonQuery();

            conexion.Close();

            return RowsAffected > 0;
        }
        /// <summary>
        /// Este Metodo realiza una query para borrar un usuario en la DB apartir de su Id y verifica que se haya afectado la tabla correctamente
        /// </summary>
        /// <param name="Id">Recibe el Id del usuario buscado</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Delete(long Id)
        {
            string Query = $"UPDATE USUARIOS SET ESTADO = 'INACTIVO' WHERE ID = {Id}";
            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            return RowsAffected > 0;
        }
        /// <summary>
        /// Este Metodo realiza una query para modificar el estado de cliente de 'Activo' a 'Inactivo' y verifica que se haya modificado la DB
        /// </summary>
        /// <param name="Id">Recibe el Id del cliente buscado</param>
        public bool Activar(long Id)
        {
            string Query = $"UPDATE USUARIOS SET ESTADO = 'ACTIVO' WHERE ID = {Id}";
            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            return RowsAffected > 0;
        }

        
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        /// <summary>
        /// Este Metodo Trae de la DB la tabla de todos los Usuarios pero no retorna la Password
        /// </summary>
        ///<returns>Retorna una lista de usuarios.</returns>
        public List<Usuario> GetAllSinPass()
        {
            IDbConnection conexion = this.prepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "SELECT ID, USERNAME, NOMBRE, ESTADO FROM USUARIOS";

            IDataReader lector = comando.ExecuteReader();

            var ListaUsuarios = new List<Usuario>();

            while (lector.Read())
            {
                Usuario usuario = new Usuario()
                {
                    Id = lector.GetInt32(0),
                    Username = lector.GetString(1),
                    Nombre = lector.GetString(2),
                    Estado = lector.GetString(3)
                    // No asignamos la contraseña aquí porque no la estamos seleccionando
                };
                ListaUsuarios.Add(usuario);
            }
            conexion.Close();

            return ListaUsuarios;
        }

        /// <summary>
        /// Este Metodo realiza una query para resetear la contrasena de un usuario a su nombre de usuario
        /// </summary>
        /// <param name="id">Recibe el Id del usuario cuyo contraseña será reseteada</param>
        ///<returns>Retorna un valor true en caso de que se haya reseteado correctamente.</returns>
        public bool ResetPassword(long id)
        {
            // Obtener el usuario con el ID especificado para obtener su nombre de usuario
            Usuario usuario = GetAll().FirstOrDefault(u => u.Id == id);

            if (usuario == null)
            {
                return false; // Usuario no encontrado
            }

            string query = $"UPDATE USUARIOS SET CLAVE = '{usuario.Username}' WHERE ID = {id}";

            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = query;
            int RowsAffected = comando.ExecuteNonQuery();

            conexion.Close();

            return RowsAffected > 0;
        }
    }
}
