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
        private string password;
        private string tipo_usuario;

        public int Id { get => id; set => id = value; }
        public string N_usuario { get => n_usuario; set => n_usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
    }
}
