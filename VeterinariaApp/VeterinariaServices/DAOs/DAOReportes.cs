using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.DAOs
{
    public class DAOReportes
    {
        private SqlConnection PrepararConexion()
        {
            // Reemplaza con tu cadena de conexión
            string connectionString = "Server=LAPTOP-EI9SSRR5\\SQLEXPRESS; Database=VeterinariaDB; Integrated Security =true";
            return new SqlConnection(connectionString);
        }

        public DataTable GetAllListadoCantidadMascotas()
        {
            using (SqlConnection conexion = PrepararConexion())
            {
                string Query = @"
                    SELECT 
                        CLIENTES.NOMBRE AS NOMBRE_CLIENTE,
                        CLIENTES.TELEFONO AS TELEFONO_CLIENTE,
                        COUNT(MASCOTAS.ID) AS CANTIDAD_ANIMALES
                    FROM 
                        MASCOTAS
                    JOIN 
                        CLIENTES ON MASCOTAS.ID_CLIENTE = CLIENTES.ID
                    WHERE 
                        MASCOTAS.ESTADO = 'ACTIVO'
                    GROUP BY 
                        CLIENTES.NOMBRE, CLIENTES.TELEFONO
                    ORDER BY 
                        CANTIDAD_ANIMALES ASC;";

                using (SqlCommand Comando = new SqlCommand(Query, conexion))
                {
                    SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
                    DataTable dt = new DataTable();
                    Adaptador.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
