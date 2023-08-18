using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Models
{
    public class CN_Raza
    {
        private IRazaRepository razaRepository;
        
        public CN_Raza()
        {
            razaRepository = new RazaRepository();
        }

        public List<Raza> findByEspecie(int codEspecie)
        {
            return razaRepository.findByEspecie(codEspecie);
        }
    }
}
