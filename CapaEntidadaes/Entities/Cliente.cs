using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaEntidades.Entities
{
    public class Cliente
    {
        private string numeroDocumento;
        private string tipoDocumento;
        private string nombre;
        private string apellido;
        private string calle;
        private string altura;

        //PROPIEDADES /VALIDACIONES DE DATOS
        [Required(ErrorMessage = "El campo Numero de Documento es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El numero de documento solo deben ser numeros")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "El numero de documento debe contener 8 digitos")]
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }

        [Required(ErrorMessage ="El campo tipo de documento es requerido")]
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }

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
    }
}
