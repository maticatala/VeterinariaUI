using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Exceptions
{
    internal class EliminadoInvalidoException: Exception
    {
        public EliminadoInvalidoException(string message): base(message) { }
    }
}
