using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.DAOs;
using VeterinariaServices.Models;

namespace VeterinariaServices.Containers
{
    public class ContenedorMascotas
    {
        //Atributos
        public List<Mascota> mascotas {  get; private set; }
        private DAOMascotas _daoMascota;
        //Constructor
        public ContenedorMascotas()
        {
            _daoMascota = new DAOMascotas();
            mascotas = new List<Mascota>();
            RefreshMascotas();
        }
        //Metodo
        ///<summary>Cada vez que necesite actualizar la lista para obtenerla completa y actualizada. 
        ///Este metodo servirá luego de ejecutar modificaciones o eliminar y matener tanto nuestra lista del container como la tabla, con la misma informacion.
        ///</summary>
        public void RefreshMascotas()
        {
            mascotas = _daoMascota.GetAll();
        }
        public List<Mascota> GetAllMascotas()
        {
            return mascotas;
        }
        /// <summary>
        /// Este metodo retorna una lista de mascotas activas a partir de la lista que le envia la DB por el DAO
        /// </summary>
        /// <returns>retorna una lista de mascotas activas</returns>
        public List<Mascota> GetAllMascotasActivos()
        {
            var listaMascotas = _daoMascota.GetAll();
            var listaActivos = new List<Mascota>();

            foreach (Mascota mascota in listaMascotas)
            {
                if (mascota.Estado == "ACTIVO")
                {
                    listaActivos.Add(mascota);
                }
            }
            return listaActivos;
        }
        /// <summary>
         /// Este metodo retorna una lista de mascotas inactivas a partir de la lista que le envia la DB por el DAO
         /// </summary>
         /// <returns>retorna una lista de mascotas inactivas</returns>
        public List<Mascota> GetAllMascotasInactivos()
        {
            var listaMascotas = _daoMascota.GetAll();
            var listaInactivos = new List<Mascota>();

            foreach (Mascota mascota in listaMascotas)
            {
                if (mascota.Estado == "INACTIVO")
                {
                    listaInactivos.Add(mascota);
                }
            }
            return listaInactivos;
        }
        /// <summary>
        /// Busca una mascota en la lista de todas las mascotas por su ID.
        /// </summary>
        /// <param name="id">El ID de la mascota a buscar.</param>
        /// <returns>Retorna la mascota con el ID especificado, o null si no se encuentra.</returns>
        public Mascota buscarPorID(int id)
        { 
            var ListaMascotas = _daoMascota.GetAll();
            Mascota mascotaBuscada = null;

            foreach (Mascota mascota in ListaMascotas)
            {
                if (mascota.Id == id) 
                { 
                    mascotaBuscada = mascota;
                    break;
                }
            }
            return mascotaBuscada;  
        }

        /// <summary>
        /// Retorna una lista de mascotas asociadas a un cliente específico por su ID.
        /// </summary>
        /// <param name="idCliente">El ID del cliente.</param>
        /// <returns>Retorna una lista de mascotas que pertenecen al cliente especificado.</returns>
        public List<Mascota> BuscarMascotasPorIdCliente(int idCliente)
        {
            var listaMascotas = _daoMascota.GetAll();
            var mascotasCliente = new List<Mascota>();

            foreach (Mascota mascota in listaMascotas)
            {
                if (mascota.IdCliente == idCliente)
                {
                    mascotasCliente.Add(mascota);
                }
            }
            return mascotasCliente;
        }

    }
}
