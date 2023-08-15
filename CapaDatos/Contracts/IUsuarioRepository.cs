using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
   public interface IUsuarioRepository:IGenericRepository<Usuario, string>
    {
        int Remove(string id, string id_tipo);
        int Update(Usuario usuario, string id, string id_tipo);
        Usuario getOne(string username, string password);
    }
}
