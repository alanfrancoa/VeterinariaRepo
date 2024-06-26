using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaServices.DAOs;
using VeterinariaServices.Models;

namespace VeterinariaServices.Containers
{
    public class ContenedorClientes
    {
        //Atributos 
        public List<Cliente> Clientes { get; private set; }
        private DAOClientes _daoClientes;
        //Constructor
        public ContenedorClientes()
        {
            _daoClientes = new DAOClientes();
            Clientes = new List<Cliente>();
            RefreshClientes();
        }

        //Metodos
        /// Este metodo actualiza la lista de clientes.
        ///<summary>Cada vez que se necesite actualizar la lista para obtenerla completa y actualizada.
        /// Este metodo servirá luego de ejecutar modificaciones o eliminar y matener tanto nuestra lista del container como la tabla, con la misma informacion.
        /// </summary>
        public void RefreshClientes()
        {
            Clientes  = _daoClientes.GetAll();
        }
        public List<Cliente> GetAllClientes()
        {
            return Clientes;
        }
        /// <summary>
        /// Este metodo retorna una lista de clientes activos a partir de la lista que le envia la DB por el DAO
        /// </summary>
        /// <returns>retorna una lista de clientes activos</returns>
        public List<Cliente> GetAllClientesActivos()
        {
            var listaClientes = _daoClientes.GetAll();
            var listaActivos = new List<Cliente>();

            foreach (Cliente cliente in listaClientes)
            {
                if(cliente.Estado == "ACTIVO"){
                    listaActivos.Add(cliente);
                }
            }
            return listaActivos;
        }
        /// <summary>
        /// Este metodo retorna una lista de clientes inactivos a partir de la lista que le envia la DB por el DAO
        /// </summary>
        /// <returns>retorna una lista de clientes inactivos</returns>
        public List<Cliente> GetAllClientesInactivos()
        {
            var listaClientes = _daoClientes.GetAll();
            var listaInactivos = new List<Cliente>();

            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Estado == "INACTIVO")
                {
                    listaInactivos.Add(cliente);
                }
            }
            return listaInactivos;
        }

        public bool ExisteDni(long Dni)
        {
            var listaClientes = _daoClientes.GetAll();

            foreach (Cliente Cliente in listaClientes)
            {
                if (Cliente.Dni == Dni)
                {
                    return true;
                }
            }
            return false;
        }

        public Cliente buscarPorDni(int Dni)
        {
            var ListaClientes = _daoClientes.GetAll();
            Cliente clienteBuscado = null;

            foreach (Cliente cliente in ListaClientes)
            {
                if (cliente.Dni == Dni)
                {
                    clienteBuscado = cliente;
                    break;
                }
            }
            return clienteBuscado;
        }

        public Cliente BuscarClientePorID(int id)
        {
            Cliente clienteBuscado = null;
            var ListaDeClientes = _daoClientes.GetAll();

            foreach (Cliente cliente in ListaDeClientes)
            {
                if (cliente.Id == id)
                {
                    clienteBuscado = cliente;
                    break;
                }
            }
            return clienteBuscado;
        }

        public String datosDeClientePorID(int id) 
        { 
            Cliente clienteBuscado=null;
            var ListaDeClientes = _daoClientes.GetAll();

            foreach (Cliente cliente in ListaDeClientes)
            {
                if (cliente.Id == id) 
                { 
                    clienteBuscado = cliente;
                    break;
                }
            }
            if (clienteBuscado != null) 
            { 
                String nombreCliente = clienteBuscado.Nombre;
                String telefonoCliente = clienteBuscado.Telefono.ToString();

                String infoCliente = $"{nombreCliente} [{telefonoCliente}]";
                return infoCliente;
                           
            }
            return null;
        }
        /// <summary>
        /// Este método busca clientes cuyo nombre contenga el parámetro proporcionado.
        /// </summary>
        /// <param name="nombre">El nombre o parte del nombre a buscar.</param>
        /// <returns>Retorna una lista de clientes cuyos nombres contienen el parámetro proporcionado.</returns>
        public List<Cliente> BuscarClientesPorNombre(string nombre)
        {
            var listaClientes = _daoClientes.GetAll();
            var listaClientesFiltrados = new List<Cliente>();

            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listaClientesFiltrados.Add(cliente);
                }
            }

            return listaClientesFiltrados;
        }

    }
}
