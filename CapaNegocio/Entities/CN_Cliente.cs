using CapaDatos.DAO;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private clienteDAO cDao = new clienteDAO();
        public List<Cliente> obtenerClientes(string dato) {
            return cDao.filtrarPorDato(dato);
        }
    }
}
