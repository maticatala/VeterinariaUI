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

namespace CapaDatos.Repository
{
    public class VeterinarioRepository : MasterRepository, IGenericRepository<Veterinario,string>
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public VeterinarioRepository() {
            selectAll = "SELECT * FROM veterinarios";
        }
        public int Add(Veterinario vet)
        {
            throw new NotImplementedException();
        }

        public int Remove(string matricula)
        {
            throw new NotImplementedException();
        }

        public int Update(Veterinario vet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veterinario> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listVeterinarios = new List<Veterinario>();

            foreach(DataRow item in tableResult.Rows)
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
