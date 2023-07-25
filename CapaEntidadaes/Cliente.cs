using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        private string numeroDocumento;
        private string tipoDocumento;
        private string nombre;
        private string apellido;
        private string calle;
        private int altura;

        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Altura { get => altura; set => altura = value; }
    }
}
