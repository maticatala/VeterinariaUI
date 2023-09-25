using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Models
{
    public class CN_Especie
    {
        private IEspecieRepository especieRepository;
        private List<Especie> listEspecies;
        
        public CN_Especie()
        {
            especieRepository = new EspecieRepository();
        }

        public List<Especie> getAll()
        {
            var especieDataModel = especieRepository.GetAll();
            listEspecies = new List<Especie>();
            listEspecies = especieDataModel.ToList();
            return listEspecies;
        }
        
    }
}
