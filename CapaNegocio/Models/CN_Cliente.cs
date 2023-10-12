using System.Collections.Generic;
using System.Linq;

//Referencias
//using MySql.Data.MySqlClient;
using CapaDatos.Repository;
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using System;
using System.Windows.Forms;
using CapaNegocio.ValueObjects;
using System.Data.SqlClient;
using CapaEntidadaes.Entities;

namespace CapaNegocio.Models
{
    public class CN_Cliente
    {
        private IClienteRepository clienteRepository;
        private List<Cliente> listClientes; //Esta variable la utilizamos para que guarde  todos los datos de los clientes de la base de datos, para que se pueda utilizar en los metodos como FindById sin tener que estar recurriendo constantemente a la base de datos.
        private Cliente cliente;

        public EntityState State { private get; set; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        //Constructor
        public CN_Cliente()
        {
            clienteRepository = new ClienteRepository(); //Inicializamos la interfaz del repositorio, No usamos directamente la clase concreta ClienteRepository, lo hacemos mediante su interfaz, donde estan declarados los metodos. De esta manera tendremos bajo acoplamiento y mantenemos encapsulada la clase concreta.
        }

        public string SaveChanges()
        {
            string mensaje = null;
            try
            {
                switch (State)
                {
                    case EntityState.Added:
                        clienteRepository.Add(cliente);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Modified:
                        clienteRepository.Update(cliente);
                        mensaje = "Modificado correctamente";
                        break;
                    case EntityState.Deleted:
                        clienteRepository.Remove(cliente.IdCliente);
                        mensaje = "Eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "Registro duplicado";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;
        }

        public List<Cliente> getAll()
        {
            var clienteDataModel = clienteRepository.GetAll();
            listClientes = new List<Cliente>();
            listClientes = clienteDataModel.ToList();
            return listClientes;
        }

        public Cliente findByDoc(string nroDoc)
        {
            return clienteRepository.findByDoc(nroDoc);
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

        public List<Mascota> getMacotas(int idCliente)
        {
            return clienteRepository.getMascotas(idCliente);
        }
    }
}
