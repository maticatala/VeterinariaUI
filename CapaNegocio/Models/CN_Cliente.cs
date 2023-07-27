using System.Collections.Generic;
using System.Linq;

//Referencias
using MySql.Data.MySqlClient;
using CapaDatos.Repository;
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using CapaEntidades.ValueObjects;
using CapaNegocio.Exceptions;

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
        public string SaveChanges(Cliente c)
        {
            string message = null;
            try
            {
                //Dependiendo del estado de la entidad realizaremos un add, update o delete.
                switch (c.State)
                {
                    case EntityState.Added:
                        //Ejecutar reglas de negocio / calculos
                        clienteRepository.Add(c); 
                        message = "Registrado correctamente";
                        break;
                    case EntityState.Modified:
                        clienteRepository.Update(c);
                        message = "Modificado correctamente";
                        break;
                    case EntityState.Deleted:
                        clienteRepository.Remove(c.NumeroDocumento);
                        message = "Eliminado correctamente";
                        break;
                }
            }
            catch (MySqlException ex)
            {
                if (ex != null && ex.Number == 1062)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }
            return message;
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
    }
}
