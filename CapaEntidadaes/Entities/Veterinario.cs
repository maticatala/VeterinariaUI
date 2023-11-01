using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entities
{
    public class Veterinario
    {
        private string matricula;
        private string nombre;
        private string apellido;
        private string calle;
        private string altura;
        private string telefono;


        [Required(ErrorMessage = "El campo Matricula es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "La matricula solo debe ser numeros")]
        public string Matricula { get => matricula; set => matricula = value; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "El nombre solo debe contener letras (sin espacios)")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage = "El campo apellido es requerido")]
        [RegularExpression("^[A-Za-zÁ-Úá-ú]+$", ErrorMessage = "El apellido solo debe contener letras (sin espacios)")]
        public string Apellido { get => apellido; set => apellido = value; }
        [Required(ErrorMessage = "El campo calle es requerido")]
        [RegularExpression("^[A-Za-z0-9\\s]+$", ErrorMessage = "La calle solo debe contener letras, números y espacios")]
        public string Calle { get => calle; set => calle = value; }
        [Required(ErrorMessage = "El campo Numero de altura es requerido")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "Debe ingresar un número positivo")]
        public string Altura { get => altura; set => altura = value; }
        [Required(ErrorMessage = "El campo Telefono es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El Telefono solo deben ser numeros")]
        public string Telefono { get => telefono; set => telefono = value; }


    }
}
