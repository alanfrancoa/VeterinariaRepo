﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.Models;

namespace VeterinariaServices.DAOs
{
    public class DAOMascotas
    {
        /// <summary>
        /// Este Metodo realiza una conexion a la DB a partir del connectionString
        /// </summary>
        ///<returns>Retorna la conexion a DB</returns>
        private IDbConnection PrepararConexion()
        {
            string ConnectionString = "Server=PCGAMINGALAN\\SQLEXPRESS; Database=VeterinariaDB; Integrated Security =true";

            SqlConnection conexion = new SqlConnection(ConnectionString);

            conexion.Open();

            return conexion;
        }

        /// <summary>
        /// Este metodo recorre la DB y lo guarda en una list de Mascotas
        /// </summary>
        ///<returns>Retorna una lista de Mascotas</returns>
        public List<Mascota> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand Comando = conexion.CreateCommand();

            Comando.CommandText = "SELECT ID,NOMBRE,PESO,FECHA_NACIMIENTO,ID_CLIENTE,ID_ESPECIE,ESTADO FROM MASCOTAS";

            IDataReader lector = Comando.ExecuteReader();

            var ListaMascotas = new List<Mascota>();

            while (lector.Read())
            {
                Mascota mascota = new Mascota()
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Peso = lector.GetDecimal(2),
                    FechaNacimiento = lector.GetDateTime(3),
                    IdCliente = lector.GetInt32(4),
                    IdEspecie = lector.GetInt32(5),
                    Estado = lector.GetString(6),
                };
                ListaMascotas.Add(mascota);
            }
            conexion.Close();
            return ListaMascotas;
        }

        public bool Insert(Mascota mascota)
        {
            string Query = $"INSERT INTO MASCOTAS(NOMBRE,PESO,FECHA_NACIMIENTO,ID_CLIENTE,ID_ESPECIE) VALUES ('{mascota.Nombre}',{mascota.Peso},'{mascota.FechaNacimiento}',{mascota.IdCliente},{mascota.IdEspecie} )";

            var conexion = this.PrepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = Query;
            int RowsAffected = comando.ExecuteNonQuery();

            conexion.Close();

            return RowsAffected > 0;

        }

        public DataTable GetAllListasdo()
        {
            IDbConnection conexion = this.PrepararConexion();

            string Query = @"
                SELECT 
                    M.ID,
                    M.NOMBRE,
                    M.PESO,
                    M.FECHA_NACIMIENTO,
                    CLIENTES.NOMBRE AS NOMBRE_CLIENTE,
                    CLIENTES.TELEFONO AS TELEFONO_CLIENTE,
                    ESPECIES.NOMBRE AS NOMBRE_ESPECIE,
                    M.ESTADO
                FROM 
                    MASCOTAS AS M
                JOIN 
                    CLIENTES ON M.ID_CLIENTE = CLIENTES.ID
                JOIN 
                    ESPECIES ON M.ID_ESPECIE = ESPECIES.ID";

            IDbCommand Comando = conexion.CreateCommand();

            Comando.CommandText = Query;

            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);

            DataTable dt = new DataTable();

            Adaptador.Fill(dt);

            return dt;

        }
        public DataTable GetAllListasdoActivos()
        {
            IDbConnection conexion = this.PrepararConexion();

            string Query = @"
                SELECT 
                    M.ID,
                    M.NOMBRE,
                    M.PESO,
                    M.FECHA_NACIMIENTO,
                    CLIENTES.NOMBRE AS NOMBRE_CLIENTE,
                    CLIENTES.TELEFONO AS TELEFONO_CLIENTE,
                    ESPECIES.NOMBRE AS NOMBRE_ESPECIE,
                    M.ESTADO
                FROM 
                    MASCOTAS AS M
                JOIN 
                    CLIENTES ON M.ID_CLIENTE = CLIENTES.ID
                JOIN 
                    ESPECIES ON M.ID_ESPECIE = ESPECIES.ID
                WHERE M.ESTADO = 'ACTIVO'";

            IDbCommand Comando = conexion.CreateCommand();

            Comando.CommandText = Query;

            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);

            DataTable dt = new DataTable();

            Adaptador.Fill(dt);

            return dt;

        }
        public DataTable GetAllListadoInactivos()
        {
            IDbConnection conexion = this.PrepararConexion();

            string Query = @"
                SELECT 
                    M.ID,
                    M.NOMBRE,
                    M.PESO,
                    M.FECHA_NACIMIENTO,
                    CLIENTES.NOMBRE AS NOMBRE_CLIENTE,
                    CLIENTES.TELEFONO AS TELEFONO_CLIENTE,
                    ESPECIES.NOMBRE AS NOMBRE_ESPECIE,
                    M.ESTADO
                FROM 
                    MASCOTAS AS M
                JOIN 
                    CLIENTES ON M.ID_CLIENTE = CLIENTES.ID
                JOIN 
                    ESPECIES ON M.ID_ESPECIE = ESPECIES.ID
                WHERE M.ESTADO = 'INACTIVO'";

            IDbCommand Comando = conexion.CreateCommand();

            Comando.CommandText = Query;

            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);

            DataTable dt = new DataTable();

            Adaptador.Fill(dt);

            return dt;

        }
        /// <summary>
        /// Este Metodo realiza una query para editar los detalles de una mascota existente en la DB y verifica que se haya modificado correctamente.
        /// </summary>
        /// <param name="query">Recibe un string con la query de actualización para ejecutar en la DB</param>
        ///<returns>Retorna un valor true en caso de que se haya actualizado correctamente.</returns>
        public bool Edit(string query)
        {
            var conexion = this.PrepararConexion();
            var comando = conexion.CreateCommand();
            comando.CommandText = query;
            int RowsAffected = comando.ExecuteNonQuery();
            conexion.Close();
            return RowsAffected > 0;
        }

    }
}
