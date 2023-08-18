using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadaes.Entities
{
    public class Especie
    {
        private int codEspecie;
        private string nombreEspecie;

        public int CodEspecie { get => codEspecie; set => codEspecie = value; }
        public string NombreEspecie { get => nombreEspecie; set => nombreEspecie = value; }
    }
}
