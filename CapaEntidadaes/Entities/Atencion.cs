using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadaes.Entities
{
    public class Atencion
    {
        private int nroHC;
        private int matricula;
        private DateTime fechaYHora;
        private string resultado;
        private double precio;

        public int NroHC { get => nroHC; set => nroHC = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
