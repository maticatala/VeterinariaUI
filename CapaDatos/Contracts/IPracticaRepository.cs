using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
namespace CapaDatos.Contracts
{
    public interface IPracticaRepository:IGenericRepository<Practica,int>
    {
        List<Practica> getPractica(int codPractica);
        int Update(Practica practica, int Pra);
    }
}
