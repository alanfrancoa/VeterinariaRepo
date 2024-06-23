using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Models
{
    public class Usuario
    {   //Atributos
        public long Id { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string TipoUsuario { get; set; }
        //Constructores
        public Usuario(long id, string username, string nombre, string password, string estado, string tipoUsuario)
        {
            Id = id;
            Username = username;
            Nombre = nombre;
            Password = password;
            Estado = estado;
            TipoUsuario = tipoUsuario;
        }

        public Usuario()
        {
        }
    }
}
