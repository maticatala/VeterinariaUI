using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CapaEntidades.ValueObjects;

namespace CapaEntidades.Entities
{
    public class Cliente
    {
        private string numeroDocumento;
        private string tipoDocumento;
        private string nombre;
        private string apellido;
        private string calle;
        private int altura;
        private EntityState state;

        //PROPIEDADES /VALIDACIONES DE DATOS
        [Required(ErrorMessage = "El campo Numero de Documento es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El numero de documento solo deben ser numeros")]
        [StringLength(maximumLength:8,MinimumLength =8,ErrorMessage ="El numero de documento debe contener 8 digitos")]
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Altura { get => altura; set => altura = value; }
        public EntityState State { get => state; set => state = value; }
    }
}
