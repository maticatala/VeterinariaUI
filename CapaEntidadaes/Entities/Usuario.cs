using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entities
{
    public class Usuario
    {
        private int id;
        private string n_usuario;
        private string password;
        private string tipo_usuario;


        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "El Nombre solo debe contener letras (sin espacios)")]
        public string N_usuario { get => n_usuario; set => n_usuario = value; }

        [Required(ErrorMessage = "El campo Contraseña es requerido")]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "El campo Tipo Usuario es requerido")]
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
    }
}
