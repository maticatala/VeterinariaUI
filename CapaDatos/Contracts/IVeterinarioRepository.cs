using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using CapaEntidades.Entities;

namespace CapaDatos.Contracts
{
    public interface IVeterinarioRepository : IGenericRepository<Veterinario, string>
    {
        int Update(Veterinario vet, string matricula);
    }
}
