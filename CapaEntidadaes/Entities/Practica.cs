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
        private float precio;

        [Required(ErrorMessage = "El campo Practica es requerido")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int codPractica { get =>CodPractica; set =>CodPractica = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
