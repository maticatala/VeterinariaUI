using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entities
{
    public class Mascota
    {
        private int nroHC;
        private DateTime fechaNac;
        private string nombre;
        private char sexo;
        private int idCliente;
        private int codRaza;
        private int codEspecie;

        [Required(ErrorMessage = "El campo Nro HC es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El Nro HC solo debe ser numeros")]
        public int NroHC { get => nroHC; set => nroHC = value; }
        [Required(ErrorMessage = "El campo Fecha Nacimineto es requerido")]
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage = "El campo Sexo es requerido")]
        public char Sexo { get => sexo; set => sexo = value; }
        [Required(ErrorMessage = "El campo Id Cliente es requerido")]
        public int IdCliente { get => idCliente; set => idCliente = value; }
        [Required(ErrorMessage = "El campo Cod Raza es requerido")]
        public int CodRaza { get => codRaza; set => codRaza = value; }
        [Required(ErrorMessage = "El campo Cod Especie es requerido")]
        public int CodEspecie { get => codEspecie; set => codEspecie = value; }
    }
}
