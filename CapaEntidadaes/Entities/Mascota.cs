using System;
using System.Collections.Generic;
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

        public int NroHC { get => nroHC; set => nroHC = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int CodRaza { get => codRaza; set => codRaza = value; }
        public int CodEspecie { get => codEspecie; set => codEspecie = value; }
    }
}
