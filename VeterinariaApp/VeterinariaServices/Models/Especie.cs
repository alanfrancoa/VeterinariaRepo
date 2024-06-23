using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaServices.Models
{
    public class Especie
    {   //Atributos
        public long Id { get; set; }
        public string Nombre { get; set; }
        public int EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        //Constructores
        public Especie(long id, string nombre, int edadMadurez, decimal pesoPromedio)
        {
            Id = id;
            Nombre = nombre;
            EdadMadurez = edadMadurez;
            PesoPromedio = pesoPromedio;
        }
        public Especie() 
        { 
        }

    }
}
