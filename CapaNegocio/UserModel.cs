using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Repository;

namespace Models
{
    public class UserModel
    {
        UsuarioRepository userDao = new UsuarioRepository();

        public bool LoginUser(string username, string password)
        {
            return userDao.Login(username, password);
        }
    }
}
