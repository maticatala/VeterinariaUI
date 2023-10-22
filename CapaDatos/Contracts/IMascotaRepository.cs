using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
    public interface IMascotaRepository : IGenericRepository<Mascota, int>
    {
        List<Mascota> buscarPorDueño(int idCliente);
        int getCount();
    }
}
