﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidades.Entities;

namespace CapaNegocio.Models
{
    public class CN_Veterinario
    {
        private IVeterinarioRepository veterinarioRepository;
        private List<Veterinario> listVeterinarios;

        public CN_Veterinario()
        {
            veterinarioRepository = new VeterinarioRepository();
        }

        public IEnumerable<Veterinario> getAll()
        {
            var veterinarioDataModel = veterinarioRepository.GetAll();
            listVeterinarios = new List<Veterinario>();
            listVeterinarios = veterinarioDataModel.ToList();
            return listVeterinarios;
        }

        public string Add(Veterinario vet)
        {
            veterinarioRepository.Add(vet);
            return "Registrado correctamente";
        }

        public string delete(string matricula)
        {
            veterinarioRepository.Remove(matricula);
            return "Eliminado correctamente";
        }

        public string Update(Veterinario vet, string oldMatricula)
        {
            veterinarioRepository.Update(vet, oldMatricula);
            return "Actualizado correctamente";
        }
         
    }
}
