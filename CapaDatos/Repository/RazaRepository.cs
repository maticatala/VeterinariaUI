using CapaDatos.Contracts;
using CapaDatos.Exceptions;
using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.Repository
{
    public class RazaRepository : MasterRepository, IRazaRepository
    {
        //Atributos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //Constructor
        public RazaRepository()
        {
            selectAll = "SELECT * FROM razas";
            insert = "INSERT INTO razas VALUES (@codEspecie, @nombreRaza)";
            update = "UPDATE razas SET nombreRaza=@nombreRaza, codEspecie=@codEspecie WHERE codRaza=@codRaza";
            delete = "DELETE FROM razas WHERE codRaza=@codRaza";
        }
        //Metodos
        public int Add(Raza raza)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombreRaza", raza.NombreRaza));
            parameters.Add(new SqlParameter("@codEspecie", raza.CodEspecie));

            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 2627)
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    throw ex;
            }
        }

        public List<Raza> findByEspecie(int codEspecie)
        {
            string sql = $"SELECT * FROM razas WHERE codEspecie={codEspecie}";
            var tableResult = ExecuteReader(sql);
            var listRazas = new List<Raza>();

            foreach (DataRow item in tableResult.Rows)
            {
                listRazas.Add(new Raza
                {
                    CodRaza = (int)item[0],
                    CodEspecie = (int)item[1],
                    NombreRaza = item[2].ToString()
                });
            }
            return listRazas;
        }

        public List<Raza> findByNombreAndEspecie(string nombre, int codEspecie)
        {
            string sql = $"SELECT * FROM razas WHERE codEspecie={codEspecie} and nombreRaza like '%{nombre}%'";
            var tableResult = ExecuteReader( sql );
            var listRazas = new List<Raza>();

            foreach (DataRow item in tableResult.Rows)
            {
                listRazas.Add(new Raza
                {
                    CodRaza = (int)item[0],
                    CodEspecie = (int)item[1],
                    NombreRaza = item[2].ToString()
                });
            }
            return listRazas;
        }

        public IEnumerable<Raza> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listRazas = new List<Raza>();

            foreach (DataRow item in tableResult.Rows) 
            {
                listRazas.Add(new Raza
                {
                    CodRaza = (int)item[0],
                    CodEspecie = (int)item[1],
                    NombreRaza = item[2].ToString()
                });
            }
            return listRazas;
        }

        public int Remove(int codRaza)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codRaza", codRaza));

            try
            {
                return ExecuteNonQuery(delete);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(Raza raza)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codRaza", raza.CodRaza));
            parameters.Add(new SqlParameter("@codEspecie", raza.CodEspecie));
            parameters.Add(new SqlParameter("@nombreRaza", raza.NombreRaza));

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
