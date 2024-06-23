using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Models
{
    public class Cliente
    {   //Atributos
        public long Id { get; set; }   
        public string Nombre { get; set; }
        public long Dni {  get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        //Constructores
        public Cliente(string nombre, long dni, long telefono, string email)
        {
            Nombre = nombre;
            Dni = dni;
            Telefono = telefono;
            Email = email;

        }
          public Cliente() { }

    }
}
