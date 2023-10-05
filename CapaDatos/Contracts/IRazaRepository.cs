using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    public interface IRazaRepository : IGenericRepository<Raza, int>
    {
        List<Raza> findByEspecie(int codEspecie);

        List<Raza> findByNombreAndEspecie(string nombre, int codEspecie);
    }
}
