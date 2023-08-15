using System.Collections.Generic;
using System.Linq;

//Referencias
//using MySql.Data.MySqlClient;
using CapaDatos.Repository;
using CapaDatos.Contracts;
using CapaEntidades.Entities;
using System;
using System.Windows.Forms;
using CapaEntidadaes.Entities;

namespace CapaNegocio.Models
{
    public class CN_Usuario
    {
        private IUsuarioRepository usuarioRepository;
        private List<Usuario> listUsuarios;

        public CN_Usuario()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public string Add(Usuario u)
        {
            usuarioRepository.Add(u);
            return "Registrado Correctamente";
        }

        public List<Usuario> GetAll()
        {
            var usuarioDataModel = usuarioRepository.GetAll();
            listUsuarios = usuarioDataModel.ToList();
            return listUsuarios;
        }

        public Usuario LoginUser(string username, string password)
        {
            return usuarioRepository.getOne(username, password);
        }

    }
}
