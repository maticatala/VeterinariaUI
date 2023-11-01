using CapaDatos.Contracts;
using CapaDatos.Exceptions;
using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repository
{
    public class AtencionRepository: MasterRepository,IAtencionRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public AtencionRepository()
        {
            selectAll = "SELECT * FROM atenciones";
            insert = "INSERT INTO atenciones VALUES (@nroHC,@nroMatricula,@fechaYHora,@resultado, @precio)";
            update = "UPDATE atenciones SET nroHC=@nroHC,nroMatricula=@nroMatricula,fechaYHora=@fechaYHora,resultado=@resultado, precio=@precio WHERE nroHC=@nroHC,nroMatricula=@nroMatricula,fechaYHora=@fechaYHora";
            delete = "DELETE FROM atenciones WHERE nroHC=@nroHC";
        }

        public int Add(Atencion atencion) //Llega como parametro una instancia de cliente desde la capa de negocios. Retorna un entero, que especifica cuantos registros se añadieron 
        {
            parameters = new List<SqlParameter>();
            //Agregamos a la lista de parametros cada uno de ellos utilizando las property de la clase Cliente

            parameters.Add(new SqlParameter("@nroHC", atencion.NroHC));
            parameters.Add(new SqlParameter("@nroMatricula", atencion.Matricula));
            parameters.Add(new SqlParameter("@fechaYHora", atencion.FechaYHora));
            parameters.Add(new SqlParameter("@resultado", atencion.Resultado));
            parameters.Add(new SqlParameter("@precio", atencion.Precio));


            //Ejecutamos el metodo ExecuteNonQuery de la clase repositorio maestra, este metodo requiere que enviemos un comando sql
            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 2627)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }

        }

        public IEnumerable<Atencion> GetAll()
        {
            //Declaramos una variable implicita de nombre tableResult que sera igual método ExecuteReader del repositorio maestro, este metodo requiere que enviemos una cadena de comando sql y devuelve un DataTable
            var tableResult = ExecuteReader(selectAll);
            var listAtenciones = new List<Atencion>();
            //Por cada iteracion agregamos un nuevo objeto empleado a la lista de empleados
            foreach (DataRow item in tableResult.Rows)
            {
                listAtenciones.Add(new Atencion
                {
                    NroHC = (int)item[0],
                    Matricula = item[1].ToString(),
                    FechaYHora = (DateTime)item[2],
                    Resultado = item[3].ToString(),
                    Precio = Convert.ToDouble(item[4])
                });
            }
            return listAtenciones;
        }

        public int Update(Atencion atencion)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@nroHC", atencion.NroHC));
            parameters.Add(new SqlParameter("@nroMatricula", atencion.Matricula));
            parameters.Add(new SqlParameter("@fechaYHora", atencion.FechaYHora));
            parameters.Add(new SqlParameter("@Resultado", atencion.Resultado));
            parameters.Add(new SqlParameter("@precio", atencion.Precio));


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
        public int Remove(int nroHC)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nroHC", nroHC));
            return ExecuteNonQuery(delete);
        }


    }
    
}
