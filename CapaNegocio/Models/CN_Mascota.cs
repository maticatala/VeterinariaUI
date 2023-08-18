using CapaDatos.Contracts;
using CapaNegocio.ValueObjects;
using CapaEntidadaes.Entities;
using CapaDatos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Entities;
using System.Data.SqlClient;

namespace CapaNegocio.Models
{
    public class CN_Mascota
    {
        private IMascotaRepository mascotaRepository;
        private List<Mascota> listMascotas;
        private Mascota mascota;

        public EntityState State { private get; set ; }
        public Mascota Mascota { get => mascota; set => mascota = value; }

        public CN_Mascota()
        {
            mascotaRepository = new MascotaRepository();
        }

        public List<Mascota> getAll()
        {
            var mascotaDataModel = mascotaRepository.GetAll();
            listMascotas = new List<Mascota>();
            listMascotas = mascotaDataModel.ToList();
            return listMascotas;
        }

        public string SaveChanges()
        {
            string mensaje=null;
            try
            {
                switch (State)
                {
                    case EntityState.Added:
                        mascotaRepository.Add(mascota);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Modified:
                        mascotaRepository.Add(mascota);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Deleted:
                        mascotaRepository.Remove(mascota.NroHC);
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
    }
}
