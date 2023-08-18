using CapaDatos.Contracts;
using CapaDatos.Exceptions;
using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repository
{
    public class EspecieRepository : MasterRepository, IEspecieRepository
    {
        //Atributos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //Constructor
        public EspecieRepository()
        {
            selectAll = "SELECT * FROM especies";
            insert = "INSERT INTO especies VALUES (@nombreEspecie)";
            update = "UPDATE especies SET nombreEspecie=@nombreEspecie WHERE codEspecie=@codEspecie";
            delete = "DELETE FROM especies WHERE codEspecie=@codEspecie";
        }


        //Metodos
        public int Add(Especie especie)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombreEspecie", especie.NombreEspecie));

            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Especie> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listEspecies = new List<Especie>();
            foreach (DataRow item in tableResult.Rows)
            {
                listEspecies.Add(new Especie
                {
                    CodEspecie = (int)item[0],
                    NombreEspecie = item[1].ToString()
                });
            }
            return listEspecies;
        }

        public int Remove(int codEspecie)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codEspecie", codEspecie));

            try
            {
                return ExecuteNonQuery(delete);
            } catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(Especie especie)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codEspecie", especie.CodEspecie));
            parameters.Add(new SqlParameter("@nombreEspecie", especie.NombreEspecie));

            try
            {
                return ExecuteNonQuery(update);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
