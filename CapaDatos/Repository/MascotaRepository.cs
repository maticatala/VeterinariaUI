using CapaDatos.Contracts;
using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using CapaEntidades.Entities;
using CapaDatos.Exceptions;
using System.Data.SqlClient;
using MySqlX.XDevAPI;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos.Repository
{
    public class MascotaRepository : MasterRepository, IMascotaRepository
    {
        //Declaramos los campos de forma privada para las 4 operaciones básicas
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //Creamos el constructor e inicializamos los campos
        public MascotaRepository()
        {
            selectAll = "SELECT * FROM mascotas";
            insert = "INSERT INTO mascotas VALUES (@fechaNac,@nombre,@sexo,@idCliente,@codRaza,@codEspecie)";
            update = "UPDATE mascotas SET fechaNac=@fechaNac,nombre=@nombre,sexo=@sexo,idCLiente=@idCliente,codRaza=@codRaza,codEspecie=@codEspecie WHERE nroHC=@nroHC";
            delete = "DELETE FROM mascotas WHERE nroHC=@nroHC";
        }

        public int Add(Mascota mascota)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@fechaNac", mascota.FechaNac));
            parameters.Add(new SqlParameter("@nombre", mascota.Nombre));
            parameters.Add(new SqlParameter("@sexo", mascota.Sexo));
            parameters.Add(new SqlParameter("@idCliente", mascota.IdCliente));
            parameters.Add(new SqlParameter("@codRaza", mascota.CodRaza));
            parameters.Add(new SqlParameter("@codEspecie", mascota.CodEspecie));

            return ExecuteNonQuery(insert);
        }

        public IEnumerable<Mascota> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listMascotas = new List<Mascota>();

            foreach (DataRow item in tableResult.Rows)
            {
                listMascotas.Add(new Mascota
                {
                    NroHC = (int)item[0],
                    FechaNac = (DateTime)item[1],
                    Nombre = item[2].ToString(),
                    Sexo = (char)item[3],
                    IdCliente = (int)item[4],
                    CodRaza = (int)item[5],
                    CodEspecie = (int)item[6],
                });
            }
            return listMascotas;
        }

        public int Remove(int nroHC)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@nroHC", nroHC));
            return ExecuteNonQuery(delete);
        }

        public List<Mascota> findByDueño(int idCliente)
        {
            string sql = $"SELECT * FROM mascotas WHERE idCliente={idCliente}";
            var tableResult = ExecuteReader(sql);
            var listMascotas = new List<Mascota>();

            foreach (DataRow item in tableResult.Rows)
            {
                listMascotas.Add(new Mascota
                {
                    NroHC = (int)item[0],
                    IdCliente = (int)item[1],
                    Nombre = item[2].ToString()
                });
            }
            return listMascotas;
        }
        
        public int Update(Mascota mascota)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@nroHC", mascota.NroHC));
            parameters.Add(new SqlParameter("@fechaNac", mascota.FechaNac));
            parameters.Add(new SqlParameter("@nombre", mascota.Nombre));
            parameters.Add(new SqlParameter("@sexo", mascota.Sexo));
            parameters.Add(new SqlParameter("@idCliente", mascota.IdCliente));
            parameters.Add(new SqlParameter("@codRaza", mascota.CodRaza));
            parameters.Add(new SqlParameter("@codEspecie", mascota.CodEspecie));

            return ExecuteNonQuery(update);
        }
        public int getCount()
        {
            string query = "SELECT COUNT(*) AS TotalRows FROM mascotas";
            var tableResult = ExecuteReader(query);
            DataRow dr = tableResult.Rows[0];
            int resultado = (int)dr[0];
            return resultado;
        }
    }
}
