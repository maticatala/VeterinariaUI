﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Exceptions
{
    public class RegistroDuplicadoException: Exception
    {
        public RegistroDuplicadoException(string message) : base(message)
        {
        }
    }
}
