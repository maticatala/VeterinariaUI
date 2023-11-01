using System;
using System.Collections.Generic;
using System.Data;

//Referencias
//using MySql.Data.MySqlClient;
//using MySql.Data;
//using MySqlX.XDevAPI;
//using CapaDatos.Contracts;
using CapaEntidades.Entities;
using CapaDatos.Exceptions;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaDatos.Contracts;

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
            update = "UPDATE clientes SET nroDoc=@nroDoc,tipoDoc=@tipoDoc,nombre=@nombre,apellido=@apellido,calle=@calle,altura=@altura WHERE idCliente=@idCliente";
            delete = "DELETE FROM clientes WHERE idCliente=@idCliente";
        }
        public int Add(Cliente cliente) //Llega como parametro una instancia de cliente desde la capa de negocios. Retorna un entero, que especifica cuantos registros se añadieron 
        {
            parameters = new List<SqlParameter>();
            //Agregamos a la lista de parametros cada uno de ellos utilizando las property de la clase Cliente

            parameters.Add(new SqlParameter("@nroDoc", cliente.NumeroDocumento));
            parameters.Add(new SqlParameter("@tipoDoc", cliente.TipoDocumento));
            parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            parameters.Add(new SqlParameter("@apellido", cliente.Apellido));
            parameters.Add(new SqlParameter("@calle", cliente.Calle));
            parameters.Add(new SqlParameter("@altura", cliente.Altura));


            //Ejecutamos el metodo ExecuteNonQuery de la clase repositorio maestra, este metodo requiere que enviemos un comando sql
            try
            {
                return ExecuteNonQuery(insert);
            } catch (SqlException ex)
            {
                if (ex != null && ex.Number == 2627)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }

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
                    IdCliente = (int)item[0],
                    NumeroDocumento = item[1].ToString(),
                    TipoDocumento = item[2].ToString(),
                    Nombre = item[3].ToString(),
                    Apellido = item[4].ToString(),
                    Calle = item[5].ToString(),
                    Altura = item[6].ToString()
                });
            }
            return listClientes;
        }

        public int Update(Cliente cliente)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@idCliente", cliente.IdCliente));
            parameters.Add(new SqlParameter("@nroDoc", cliente.NumeroDocumento));
            parameters.Add(new SqlParameter("@tipoDoc", cliente.TipoDocumento));
            parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            parameters.Add(new SqlParameter("@apellido", cliente.Apellido));
            parameters.Add(new SqlParameter("@calle", cliente.Calle));
            parameters.Add(new SqlParameter("@altura", cliente.Altura));
            
            return ExecuteNonQuery(update);
        }

        public int Remove(int idCliente)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@idCliente", idCliente));
            return ExecuteNonQuery(delete);
        }

        public Cliente findByDoc(string nroDoc)
        {
            string sql = $"SELECT * FROM clientes WHERE nroDoc='{nroDoc}'";
            DataRow item = ExecuteReader(sql).Rows[0];
            Cliente cliente = new Cliente() 
            {
                IdCliente = (int)item[0],
                NumeroDocumento = item[1].ToString(),
                TipoDocumento = item[2].ToString(),
                Nombre = item[3].ToString(),
                Apellido = item[4].ToString(),
                Calle = item[5].ToString(),
                Altura = item[6].ToString()
            };
            return cliente;
        }

        public List<Mascota> GetMascotas(int idCliente)
        {
            string sql = $"select * from mascotas where idCliente={idCliente}";
            var tableResult = ExecuteReader(sql);
            var listMascotas = new List<Mascota>();

            foreach (DataRow item in tableResult.Rows)
            {
                listMascotas.Add(new Mascota
                {
                    NroHC = Convert.ToInt32(item[0]),
                    FechaNac = (DateTime)item[1],
                    Nombre = item[2].ToString(),
                    Sexo = Convert.ToChar(item[3]),
                    IdCliente = Convert.ToInt32(item[4]),
                    CodRaza = Convert.ToInt32(item[5]),
                    CodEspecie = Convert.ToInt32(item[6])
                });
            }
            return listMascotas;
        }

        public int getCount()
        {
            string query = "SELECT COUNT(*) AS TotalRows FROM clientes";
            var tableResult = ExecuteReader(query);
            DataRow dr = tableResult.Rows[0];
            int resultado = (int)dr[0];
            return resultado;
        }
    }
}
