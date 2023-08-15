using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Exceptions
{
    public class RegistroInexistenteException : Exception
    {
        public RegistroInexistenteException(string message) : base(message)
        {
        }
    }
}
