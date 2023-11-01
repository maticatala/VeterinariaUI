using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadaes.Entities
{
    public class Raza
    {
        private int codRaza;
        private int codEspecie;
        private string nombreRaza;

        public int CodRaza { get => codRaza; set => codRaza = value; }
        public int CodEspecie { get => codEspecie; set => codEspecie = value; }
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "El Nombre Raza solo debe contener letras (sin espacios)")]
        public string NombreRaza { get => nombreRaza; set => nombreRaza = value; }
    }
}
