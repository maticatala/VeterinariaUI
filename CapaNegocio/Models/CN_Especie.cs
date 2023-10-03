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
        private IRazaRepository razaRepository;
        private List<Especie> listEspecies;
        private List<Raza> listRazas;

        public CN_Especie()
        {
            especieRepository = new EspecieRepository();
            razaRepository = new RazaRepository();
        }

        public string add(Especie especie)
        {
            string message;
            try
            {
                especieRepository.Add(especie);
                message = "añadido exitosamente";
            }
            catch(Exception ex)
            {
                message = ex.ToString();
            }
            return message;
        } 

        public List<Especie> getAll()
        {
            var especieDataModel = especieRepository.GetAll();
            listEspecies = new List<Especie>();
            listEspecies = especieDataModel.ToList();
            return listEspecies;
        }

        public List<Especie> findByNombre(string nombre)
        {
            var especieDataModel = especieRepository.FindByNombre(nombre);
            listEspecies = new List<Especie>();
            listEspecies = especieDataModel.ToList();
            return listEspecies;
        }

        public List<Raza> findRazas(int codEspecie)
        {
            var razaDataModel = razaRepository.findByEspecie(codEspecie);
            listRazas = new List<Raza>();
            listRazas = razaDataModel.ToList();
            return listRazas;

        }
    }
}
