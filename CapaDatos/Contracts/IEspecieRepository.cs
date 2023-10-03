using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    public interface IEspecieRepository : IGenericRepository<Especie, int>
    {
        IEnumerable<Especie> FindByNombre(string nombre);
    }
}
