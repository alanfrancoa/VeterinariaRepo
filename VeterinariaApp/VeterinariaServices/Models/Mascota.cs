using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Models
{
    public class Mascota
    {   
        ///Atributos
        public long Id { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long IdCliente { get; set;}
        public long IdEspecie { get;set;}
        public string Estado { get; set; }

        //Constructores
        public Mascota(string nombre, decimal peso, DateTime fechaNacimiento, long idCliente, long idEspecie)
        {
            Nombre = nombre;
            Peso = peso;
            FechaNacimiento = fechaNacimiento;
            IdCliente = idCliente;
            IdEspecie = idEspecie;
        }

        public Mascota()
        {
        }
        //Metodos
        /// <summary>
        /// Este metodo calcula la edad de la mascota.
        /// Resta el año actual al año de nacimiento de la mascota.
        /// En caso de que el cumpleaños no haya pasado, hace un ajuste a la operacion, restando un año.
        /// Si la mascota ya cumplió, no se realiza el ajuste.
        /// </summary>
        ///<returns>Retorna un nro entero resultado de la resta y redondeo de fecha.</returns>
        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year -
                       (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);
            }
        }
    }
}
