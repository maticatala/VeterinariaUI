using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ValueObjects
{
    //Este elemento nos va a servir de forma similar a un combobox donde tendremos 3 estados principales agregado, eliminado y modificado.
    public enum EntityState
    {
        Added,
        Deleted,
        Modified
    }
}
