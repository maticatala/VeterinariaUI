﻿using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Models
{
    public class CN_Practica
    {
        private IPracticaRepository practicaRepository;
        private List<Practica> listPracticas;
        private Practica practica;
        public EntityState State { private get; set; }
        public Practica Practica { get => practica; set => practica = value; }

        public CN_Practica()
        {
            practicaRepository = new PracticaRepository();
        }
        public string SaveChanges()
        {
            string mensaje = null;
            try
            {
                switch (State)
                {
                    case EntityState.Added:
                        practicaRepository.Add(practica);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Modified:
                        practicaRepository.Update(practica);
                        mensaje = "Modificado correctamente";
                        break;
                    case EntityState.Deleted:
                        practicaRepository.Remove(practica.codPractica);
                        mensaje = "Eliminado correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "Registro duplicado";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;
        }

        public List<Practica> getAll()
        {
            var practicaDataModel = practicaRepository.GetAll();
            listPracticas = new List<Practica>();
            listPracticas = practicaDataModel.ToList();
            return listPracticas;
        }
        public IEnumerable<Practica> findByFilter(string filter)
        {
            return listPracticas.FindAll(
                e => e.codPractica.ToString().Contains(filter) ||
                e.Descripcion.Contains(filter.ToLower()));
        }
    }
}