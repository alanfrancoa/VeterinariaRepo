using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.DAOs;
using VeterinariaServices.Models;

namespace VeterinariaServices.Containers
{
    public class ContenedorEspecies
    {
        //Atributos
        public List<Especie> Especies { get; private set;}
        private DAOEspecies _daoEspecies;

        //Constructor
        public ContenedorEspecies() 
        {
            _daoEspecies = new DAOEspecies();
            Especies = new List<Especie>();
            RefreshEspecies();
        }
        //Metodos
        /// Este metodo actualiza la lista de especies.
        ///<summary>Cada vez que se necesite actualizar la lista para obtenerla completa y actualizada.
        /// Este metodo servirá luego de ejecutar modificaciones o eliminar y matener tanto nuestra lista del container como la tabla, con la misma informacion.
        /// </summary>
        public void RefreshEspecies()
        {
            Especies = _daoEspecies.GetAll();
        }
        /// <summary>
        /// Este metodo retorna una lista de especies a partir de la lista que le envia la DB por el DAO
        /// </summary>
        /// <returns>retorna la lista de especies</returns>
        public List<Especie> GetAllEspecies() 
        { 
            return Especies;
        }
        public Especie BuscarPorNombre(String nombre)
        {
            Especie especieBuscada = null;
            var ListaEspecies = _daoEspecies.GetAll();

            foreach (Especie especie in ListaEspecies)
            {
                if (especie.Nombre == nombre)
                {
                    especieBuscada = especie;
                    break;
                }
            }
            return especieBuscada;
        }
        public String NombrePorID(int id) 
        {
            Especie especieBuscada = null;
            var ListaEspecies = (_daoEspecies.GetAll());

            foreach (Especie especie in ListaEspecies)
            {
                if (especie.Id == id) 
                { 
                    especieBuscada =especie;
                    break;
                }
            }
            if (especieBuscada != null) 
            { 
                return especieBuscada.Nombre;
            }
            return null;
        }
    }

}
