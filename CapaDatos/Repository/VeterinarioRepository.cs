using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using System.Data.SqlClient;
using CapaDatos.Exceptions;


namespace CapaDatos.Repository
{
    public class VeterinarioRepository : MasterRepository, IVeterinarioRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public VeterinarioRepository()
        {
            selectAll = "SELECT * FROM veterinarios";
            insert = "INSERT INTO veterinarios VALUES (@nroMatricula,@nombre,@apellido,@calle,@altura,@telefono)";
            delete = "DELETE FROM veterinarios WHERE nroMatricula=@nroMatricula";
            update = "UPDATE veterinarios SET nroMatricula=@nroMatricula, nombre=@nombre, apellido=@apellido, calle=@calle, altura=@altura, telefono=@telefono WHERE nroMatricula=@oldNroMatricula";
        }
        public int Add(Veterinario vet)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@nroMatricula", vet.Matricula));
            parameters.Add(new SqlParameter("@nombre", vet.Nombre));
            parameters.Add(new SqlParameter("@apellido", vet.Apellido));
            parameters.Add(new SqlParameter("@calle", vet.Calle));
            parameters.Add(new SqlParameter("@altura", vet.Altura));
            parameters.Add(new SqlParameter("@telefono", vet.Telefono));

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

        public int Remove(string matricula)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nroMatricula", matricula));
            return ExecuteNonQuery(delete);
        }


        public int Update(Veterinario vet, string matricula)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nroMatricula", vet.Matricula));
            parameters.Add(new SqlParameter("@nombre", vet.Nombre));
            parameters.Add(new SqlParameter("@apellido", vet.Apellido));
            parameters.Add(new SqlParameter("@calle", vet.Calle));
            parameters.Add(new SqlParameter("@altura", vet.Altura));
            parameters.Add(new SqlParameter("@telefono", vet.Telefono));
            parameters.Add(new SqlParameter("@oldNroMatricula", matricula));

            try
            {
                return ExecuteNonQuery(update);
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

        public int Update(Veterinario vet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veterinario> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listVeterinarios = new List<Veterinario>();

            foreach (DataRow item in tableResult.Rows)
            {
                listVeterinarios.Add(new Veterinario
                {
                    Matricula = item[0].ToString(),
                    Nombre = item[1].ToString(),
                    Apellido = item[2].ToString(),
                    Calle = item[3].ToString(),
                    Altura = item[4].ToString(),
                    Telefono = item[5].ToString(),
                });
            }
            return listVeterinarios;
        }
    }
}