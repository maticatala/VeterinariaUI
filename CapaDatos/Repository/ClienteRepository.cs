using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySqlX.XDevAPI;
using System.Data;
using System.Windows.Forms;

//Referencias
using CapaDatos.Contracts;
using CapaEntidades.Entities;

namespace CapaDatos.Repository
{
    //Esta es la clase concreta del repositorio de cliente donde desarrollaremos los metodos de acceso. Implementaremos el repositorio especifico de cliente y el repositorio maestro para las consultas sql
    public class ClienteRepository : MasterRepository, IClienteRepository
    {
        //Declaramos los campos de forma privada para las 4 operaciones básicas
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //Creamos el constructor e inicializamos los campos
        public ClienteRepository()
        {
            selectAll = "SELECT * FROM clientes";
            insert = "INSERT INTO clientes VALUES (@nroDoc,@tipoDoc,@nombre,@apellido,@calle,@altura)";
            update = "UPDATE clientes SET nroDoc=@nroDoc,tipoDoc=@tipoDoc,nombre=@nombre,apellido=@apellido,calle=@calle,altura=@altura WHERE nroDoc=@nroDoc";
            delete = "DELETE FROM clientes WHERE nroDoc=@nroDoc and tipoDoc=@tipoDoc";
        }
        public int Add(Cliente cliente) //Llega como parametro una instancia de cliente desde la capa de negocios. Retorna un entero, que especifica cuantos registros se añadieron 
        {
            parameters = new List<MySqlParameter>();//Creamos una lista de parametros
            
            //Agregamos a la lista de parametros cada uno de ellos utilizando las property de la clase Cliente
            parameters.Add(new MySqlParameter("@nroDoc", cliente.NumeroDocumento));
            parameters.Add(new MySqlParameter("@tipoDoc", cliente.TipoDocumento));
            parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
            parameters.Add(new MySqlParameter("@apellido", cliente.Apellido));
            parameters.Add(new MySqlParameter("@calle", cliente.Calle));
            parameters.Add(new MySqlParameter("@altura", cliente.Altura));

            //Ejecutamos el metodo ExecuteNonQuery de la clase repositorio maestra, este metodo requiere que enviemos un comando sql
            return ExecuteNonQuery(insert);
        }

        public IEnumerable<Cliente> GetAll()
        {
            //Declaramos una variable implicita de nombre tableResult que sera igual método ExecuteReader del repositorio maestro, este metodo requiere que enviemos una cadena de comando sql y devuelve un DataTable
            var tableResult = ExecuteReader(selectAll); 
            var listClientes = new List<Cliente>();
            //Por cada iteracion agregamos un nuevo objeto empleado a la lista de empleados
            foreach(DataRow item in tableResult.Rows)
            {
                listClientes.Add(new Cliente
                {
                    NumeroDocumento = item[0].ToString(),
                    TipoDocumento = item[1].ToString(),
                    Nombre = item[2].ToString(),
                    Apellido = item[3].ToString(),
                    Calle = item[4].ToString(),
                    Altura = Convert.ToInt32(item[5])
                });
            }
            return listClientes;
        }

        public int Remove(String nroDoc, String tipoDoc)
        {
            parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@nroDoc", nroDoc));
            parameters.Add(new MySqlParameter("@tipoDoc", tipoDoc));
            return ExecuteNonQuery(delete);
        }

        public int Update(Cliente cliente)
        {
            parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@nroDoc", cliente.NumeroDocumento));
            parameters.Add(new MySqlParameter("@tipoDoc", cliente.TipoDocumento));
            parameters.Add(new MySqlParameter("@nombre", cliente.Nombre));
            parameters.Add(new MySqlParameter("@apellido", cliente.Apellido));
            parameters.Add(new MySqlParameter("@calle", cliente.Calle));
            parameters.Add(new MySqlParameter("@altura", cliente.Altura));
            return ExecuteNonQuery(update);
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}
