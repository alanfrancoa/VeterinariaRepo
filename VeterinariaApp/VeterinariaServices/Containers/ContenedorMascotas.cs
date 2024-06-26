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
        public List<Mascota> mascotas { get; private set; }
        private DAOMascotas _daoMascota;
        private ContenedorClientes _contenedorClientes;

        //Constructor
        public ContenedorMascotas()
        {
            _daoMascota = new DAOMascotas();
            _contenedorClientes = new ContenedorClientes();
            mascotas = new List<Mascota>();
            RefreshMascotas();
        }

        //Método
        ///<summary>Cada vez que necesite actualizar la lista para obtenerla completa y actualizada. 
        ///Este método servirá luego de ejecutar modificaciones o eliminar y mantener tanto nuestra lista del container como la tabla, con la misma información.
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
        /// Este método retorna una lista de mascotas activas a partir de la lista que le envía la DB por el DAO.
        /// </summary>
        /// <returns>Retorna una lista de mascotas activas.</returns>
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
        /// Este método retorna una lista de mascotas inactivas a partir de la lista que le envía la DB por el DAO.
        /// </summary>
        /// <returns>Retorna una lista de mascotas inactivas.</returns>
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

        /// <summary>
        /// Retorna una lista de mascotas asociadas a un cliente específico por su DNI.
        /// </summary>
        /// <param name="ClienteDNI">El DNI del cliente.</param>
        /// <returns>Retorna una lista de mascotas que pertenecen al cliente especificado por su DNI.</returns>
        public List<Mascota> BuscarMascotasPorDNICliente(int ClienteDNI)
        {
            // Buscar el cliente por DNI usando el ContenedorClientes
            Cliente cliente = _contenedorClientes.buscarPorDni(ClienteDNI);

            if (cliente == null)
            {
                // Retornar una lista vacía si el cliente no existe
                return new List<Mascota>();
            }

            // Usar el ID del cliente para buscar las mascotas
            return BuscarMascotasPorIdCliente((int)cliente.Id);
        }

        /// <summary>
        /// Retorna una lista de mascotas cuyos nombres contienen la palabra especificada.
        /// </summary>
        /// <param name="nombre">El nombre o parte del nombre a buscar.</param>
        /// <returns>Retorna una lista de mascotas cuyos nombres contienen la palabra especificada.</returns>
        public List<Mascota> BuscarMascotasPorNombre(string nombre)
        {
            var listaMascotas = _daoMascota.GetAll();
            var mascotasFiltradas = new List<Mascota>();

            foreach (Mascota mascota in listaMascotas)
            {
                if (mascota.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    mascotasFiltradas.Add(mascota);
                }
            }
            return mascotasFiltradas;
        }
        /// <summary>
        /// Retorna una lista de mascotas que tienen el ID de especie especificado.
        /// </summary>
        /// <param name="IDEspecie">El ID de la especie a buscar.</param>
        /// <returns>Retorna una lista de mascotas que tienen el ID de especie especificado.</returns>
        public List<Mascota> BuscarMascotasPorIdEspecie(int IDEspecie)
        {
            var listaMascotas = _daoMascota.GetAll();
            var mascotasPorEspecie = new List<Mascota>();

            foreach (Mascota mascota in listaMascotas)
            {
                if (mascota.IdEspecie == IDEspecie)
                {
                    mascotasPorEspecie.Add(mascota);
                }
            }
            return mascotasPorEspecie;
        }
    }
}
