using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.Models;

namespace VeterinariaServices.DAOs
{
    public class DAOEspecies
    {
        /// <summary>
        /// Este Metodo realiza una conexion a la DB a partir del connectionString
        /// </summary>
        ///<returns>Retorna la conexion a DB</returns>
        private IDbConnection PrepararConexion()
        {
            string ConnectionString = "Server=DESKTOP-9ADK1UP\\SQLEXPRESS; Database=VeterinariaDB; Integrated Security =true";

            SqlConnection  conexion = new SqlConnection(ConnectionString);

            conexion.Open();

            return conexion;
        }
        /// <summary>
        /// Este metodo recorre la DB y lo guarda en una list de Especies
        /// </summary>
        ///<returns>Retorna una lista de Especies</returns>
        public List<Especie> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = "SELECT ID,NOMBRE,EDAD_MADUREZ,PESO_PROMEDIO FROM ESPECIES";

            IDataReader lector = comando.ExecuteReader();

            var ListaEspecies = new List<Especie>();

            while (lector.Read())
            {
                Especie especie = new Especie()
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    EdadMadurez = lector.GetInt32(2),
                    PesoPromedio = lector.GetDecimal(3)
                };
                ListaEspecies.Add(especie);
            }

            conexion.Close();

            return ListaEspecies;
        }
        /// <summary>
        /// Este Metodo realiza una query para insertar una especie en la DB y verifica que se haya afectado la tabla correctamente
        /// </summary>
        /// <param name="especie">Recibe un objeto Especie para sea agregado a la DB</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        ///Prueba
        public bool Insert(Especie especie)
        {
            string Query = $"INSERT INTO ESPECIES (NOMBRE,EDAD_MADUREZ,PESO_PROMEDIO) VALUES ('{especie.Nombre}',{especie.EdadMadurez},{especie.PesoPromedio})";

            var conexion = this.PrepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            conexion.Close();

            return RowsAffected > 0;
        }
        /// <summary>
        /// Este Metodo realiza una query para borrar una Especie en la DB apartir de su Id y verifica que se haya afectado la tabla correctamente
        /// </summary>
        /// <param name="Id">Recibe el Id del cliente buscado</param>
        ///<returns>Retorna un valor true en caso de que se haya insertado correctamente.</returns>
        public bool Delete(long Id)
        {
            string Query = $"DELETE FROM ESPECIES WHERE ID = {Id}";
            var conexion = this.PrepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            return RowsAffected > 0;
        }


    }
}
