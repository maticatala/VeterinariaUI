using CapaEntidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contracts
{
   public interface IUsuarioRepository:IGenericRepository<Usuario,string>
    {
        int RemoveUsuario(int id);
        Usuario getOne(string username, string password);
    }
}
