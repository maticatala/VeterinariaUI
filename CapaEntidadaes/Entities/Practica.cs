﻿using System;
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
        private int codPractica;
        private string descripcion;
        private double precio;

        [Required(ErrorMessage = "El campo Descripcion es requerido")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CodPractica { get =>codPractica; set =>codPractica = value; }
        [Required(ErrorMessage = "El campo Precio es requerido")]
        public double Precio { get => precio; set => precio = value; }
    }
}
