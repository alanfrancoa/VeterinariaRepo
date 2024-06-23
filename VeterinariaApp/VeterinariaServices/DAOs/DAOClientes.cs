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
    public class DAOClientes
    {
        /// <summary>
        /// Este Metodo realiza una conexion a la DB a partir del connectionString
        /// </summary>
        ///<returns>Retorna la conexion a DB</returns>
        private IDbConnection prepararConexion()
        {
            string connectionString = "Server=DESKTOP-9ADK1UP\\SQLEXPRESS; Database=VeterinariaDB; Integrated Security =true";

            SqlConnection conexion = new SqlConnection(connectionString);

            conexion.Open();

            return conexion;
        }
        /// <summary>
        /// Este Metodo Trae de la DB la tabla de todos los Clientes
        /// </summary>
        ///<returns>Retorna una lista de clientes.</returns>
        public List<Cliente> GetAll()
        {
            IDbConnection conexion = this.prepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "SELECT ID,NOMBRE,DNI,TELEFONO,E_MAIL,ESTADO FROM CLIENTES";

            IDataReader lector = comando.ExecuteReader();

            var ListaClientes = new List<Cliente>();

            while (lector.Read())
            {
                Cliente cliente = new Cliente()
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Dni = lector.GetInt32(2),
                    Telefono = lector.GetInt32(3),
                    Email = lector.GetString(4),
                    Estado = lector.GetString(5),
                };
                ListaClientes.Add(cliente);
            }
            conexion.Close();

            return ListaClientes;
        }
        /// <summary>
        /// Este Metodo realiza una query para insertar un cliente en la DB y verifica que se haya afectado la tabla correctamente
        /// </summary>
        /// <param name="cliente">Recibe un objeto Cliente para sea agregado a la DB</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Insert(Cliente cliente)
        {
            string Query = $"INSERT INTO CLIENTES (NOMBRE,DNI,TELEFONO,E_MAIL) VALUES ('{cliente.Nombre}',{cliente.Dni},{cliente.Telefono},'{cliente.Email}')";

            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            conexion.Close();

            return RowsAffected > 0;
        }
        /// <summary>
        /// Este Metodo realiza una query para modificar el estado de cliente de 'Activo' a 'Inactivo' y verifica que se haya modificado la DB
        /// </summary>
        /// <param name="Id">Recibe el Id del cliente buscado</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Delete(long Id)
        {
            string Query = $"UPDATE CLIENTES SET ESTADO = 'INACTIVO' WHERE ID = {Id}";
            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            return RowsAffected > 0;
        }
        /// <summary>
        /// Este Metodo realiza una query para modificar el estado de cliente de 'Inactivo' a 'Activo' y verifica que se haya modificado la DB
        /// </summary>
        /// <param name="Id">Recibe el Id del cliente buscado</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Activar(long Id)
        {
            string Query = $"UPDATE CLIENTES SET ESTADO = 'ACTIVO' WHERE ID = {Id}";
            
            var conexion = this.prepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            return RowsAffected > 0;
        }
    }
}
