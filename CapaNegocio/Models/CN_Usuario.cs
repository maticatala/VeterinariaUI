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
using CapaNegocio.ValueObjects;
using static System.Windows.Forms.AxHost;
using System.Data.SqlClient;

namespace CapaNegocio.Models
{
    public class CN_Usuario
    {
        private IUsuarioRepository usuarioRepository;
        private List<Usuario> listUsuarios;
        public EntityState State { private get; set; }
        private Usuario usuario;

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public CN_Usuario()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public string Add(Usuario u)
        {
            usuarioRepository.Add(u);
            return "Registrado Correctamente";
        }
        public string SaveChanges()
        {
            string mensaje = null;
            try
            {
                switch (State)
                {
                    case EntityState.Added:
                        usuarioRepository.Add(usuario);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Modified:
                        usuarioRepository.Update(usuario);
                        mensaje = "Modificado correctamente";
                        break;
                    case EntityState.Deleted:
                        usuarioRepository.Remove(usuario.Id.ToString());
                        mensaje = "Eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "Registro duplicado";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;
        }

        //public List<Usuario> GetAll()
        //{
        //    var usuarioDataModel = usuarioRepository.GetAll();
        //    listUsuarios = usuarioDataModel.ToList();
        //    return listUsuarios;
        //}

        public Usuario LoginUser(string username, string password)
        {
            return usuarioRepository.getOne(username, password);
        }

        public List<Usuario> getAll()
        {
            var usuarioDataModel = usuarioRepository.GetAll();
            listUsuarios = new List<Usuario>();
            listUsuarios = usuarioDataModel.ToList();
            return listUsuarios;
        }
        public IEnumerable<Usuario> FindByFilter(string filter)
        {
            return listUsuarios.FindAll(
                e => e.Id.ToString().Contains(filter) ||
                e.N_usuario.ToLower().Contains(filter.ToLower()) ||
                e.Tipo_usuario.ToString().Contains(filter)); //Consulta lambda
        }
    }
}
