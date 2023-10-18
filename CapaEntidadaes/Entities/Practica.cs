using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CapaEntidadaes.Entities
{
    public class Practica
    {
        private int CodPractica;
        private string descripcion;
        private double precio;

        [Required(ErrorMessage = "El campo Practica es requerido")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int codPractica { get =>CodPractica; set =>CodPractica = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
