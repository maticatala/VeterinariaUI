using System;
using System.Collections.Generic;
using System.Data;

//Referencias
//using MySql.Data.MySqlClient;
//using MySql.Data;
//using MySqlX.XDevAPI;
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using CapaDatos.Exceptions;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            update = "UPDATE clientes SET nroDoc=@nroDoc,tipoDoc=@tipoDoc,nombre=@nombre,apellido=@apellido,calle=@calle,altura=@altura WHERE nroDoc=@oldNroDoc and tipoDoc=@oldTipoDoc";
            delete = "DELETE FROM clientes WHERE nroDoc=@nroDoc and tipoDoc=@tipoDoc";
        }
        public int Add(Cliente cliente) //Llega como parametro una instancia de cliente desde la capa de negocios. Retorna un entero, que especifica cuantos registros se añadieron 
        {
            parameters = new List<SqlParameter>();//Creamos una lista de parametros
            
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
                if (ex != null && ex.Number == 1062)
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
                    NumeroDocumento = item[0].ToString(),
                    TipoDocumento = item[1].ToString(),
                    Nombre = item[2].ToString(),
                    Apellido = item[3].ToString(),
                    Calle = item[4].ToString(),
                    Altura = item[5].ToString()
                });
            }
            return listClientes;
        }

        public int Remove(String nroDoc, String tipoDoc)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nroDoc", nroDoc));
            parameters.Add(new SqlParameter("@tipoDoc", tipoDoc));
            return ExecuteNonQuery(delete);

        }

        public int Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Cliente cliente, string nroDoc, string tipoDoc)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nroDoc", cliente.NumeroDocumento));
            parameters.Add(new SqlParameter("@tipoDoc", cliente.TipoDocumento));
            parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
            parameters.Add(new SqlParameter("@apellido", cliente.Apellido));
            parameters.Add(new SqlParameter("@calle", cliente.Calle));
            parameters.Add(new SqlParameter("@altura", cliente.Altura));
            parameters.Add(new SqlParameter("@oldNroDoc", nroDoc));
            parameters.Add(new SqlParameter("@oldTipoDOc", tipoDoc));
            
            try
            {
                return ExecuteNonQuery(update);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 1062)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }
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
