using System.Collections.Generic;
using System.Linq;

//Referencias
//using MySql.Data.MySqlClient;
using CapaDatos.Repository;
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using System;
using System.Windows.Forms;

namespace CapaNegocio.Models
{
    public class CN_Cliente
    {
        private IClienteRepository clienteRepository;
        private List<Cliente> listClientes; //Esta variable la utilizamos para que guarde  todos los datos de los clientes de la base de datos, para que se pueda utilizar en los metodos como FindById sin tener que estar recurriendo constantemente a la base de datos.

        //Constructor
        public CN_Cliente()
        {
            clienteRepository = new ClienteRepository(); //Inicializamos la interfaz del repositorio, No usamos directamente la clase concreta ClienteRepository, lo hacemos mediante su interfaz, donde estan declarados los metodos. De esta manera tendremos bajo acoplamiento y mantenemos encapsulada la clase concreta.
        }

        public string Add(Cliente c)
        {
            clienteRepository.Add(c);
            return "Registrado correctamente";
        }
        
        public string Update(Cliente c, string oldNroDoc, string oldTipoDoc)
        {
            clienteRepository.Update(c, oldNroDoc, oldTipoDoc);
            return "Modificado correctamente";
        }

        public string Delete(string nroDoc, string tipoDoc)
        {
            clienteRepository.Remove(nroDoc, tipoDoc);
            return "Eliminado correctamente";
        }


        public List<Cliente> getAll()
        {
            var clienteDataModel = clienteRepository.GetAll();
            listClientes = new List<Cliente>();
            listClientes = clienteDataModel.ToList();
            return listClientes;
        }

        public IEnumerable<Cliente> FindById(string filter) 
        {
            return listClientes.FindAll(e => e.NumeroDocumento.Contains(filter));
        }

        public IEnumerable<Cliente> FindByFilter(string filter) 
        {
            return listClientes.FindAll(
                e => e.NumeroDocumento.Contains(filter) || 
                e.TipoDocumento.Contains(filter) || 
                e.Nombre.ToLower().Contains(filter.ToLower()) || 
                e.Apellido.ToLower().Contains(filter.ToLower()) || 
                e.Calle.ToLower().Contains(filter.ToLower()) ||
                e.Altura.ToString().Contains(filter)); //Consulta lambda
        }

        public int getCount()
        {
            return clienteRepository.getCount();
        }
    }
}
