using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadaes.Entities
{
    public class Usuario
    {
        private int id;
        private string n_usuario;
        private string nombre;
        private string password;
        private int id_tipo;
        private string conPassword;
        private string tipousuario;

        public int Id { get => id; set => id = value; }
        public string N_usuario { get => n_usuario; set => n_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string TipoUsuario1 { get => tipousuario; set => tipousuario = value; }
        public string TipoUsuario { get; set; }
    }
}
