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

        public List<Raza> findByNombreAndEspecie(string nombre, int codEspecie)
        {
            return razaRepository.findByNombreAndEspecie(nombre, codEspecie);
        }

        public string Add(Raza raza)
        {
            string message;
            try
            {
                razaRepository.Add(raza);
                message = "Añadido exitosamente";
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            return message;
        }

        public string Delete(int codRaza)
        {
            string message;
            try
            {
                razaRepository.Remove(codRaza);
                message = "Eliminada exitosamente";
            }
            catch(Exception ex)
            {
                message=ex.ToString();
            }
            return message;
        }

        public string Update(Raza raza)
        {
            string message;
            try
            {
                razaRepository.Update(raza);
                message = "Modificado exitosamente";
            }
            catch(Exception ex)
            {
                message = (ex.ToString());
            }
            return message;
        }
    }
}
