using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadaes.Entities
{
    public class Atencion
    {
        private int nroHC;
        private string matricula;
        private DateTime fechaYHora;
        private string resultado;
        private double precio;

        [Required(ErrorMessage = "El campo Nro HC es requerido")]
        public int NroHC { get => nroHC; set => nroHC = value; }
        [Required(ErrorMessage = "El campo Matricula es requerido")]
        public string Matricula { get => matricula; set => matricula = value; }
        [Required(ErrorMessage = "El campo Fecha y Hora es requerido")]
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }
        [Required(ErrorMessage = "El campo Resultado es requerido")]
        public string Resultado { get => resultado; set => resultado = value; }
        [Required(ErrorMessage = "El campo Precio es requerido")]
        public double Precio { get => precio; set => precio = value; }
    }
}
