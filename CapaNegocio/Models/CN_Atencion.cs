using CapaDatos.Contracts;
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
    public class CN_Atencion
    {
        private IAtencionRepository atencionRepository;
        private List<Atencion> listAtenciones;
        private Atencion atencion;
        public EntityState State { private get; set; }  
        public Atencion Atencion { get => atencion; set => atencion = value; }

        public CN_Atencion()
        {
            atencionRepository = new AtencionRepository();
        }

        public string SaveChanges()
        {
            string mensaje = null;
            try
            {
                switch (State)
                {
                    case EntityState.Added:
                        atencionRepository.Add(atencion);
                        mensaje = "Añadido correctamente";
                        break;
                    case EntityState.Modified:
                        atencionRepository.Update(atencion);
                        mensaje = "Modificado correctamente";
                        break;
                    case EntityState.Deleted:
                        atencionRepository.Remove(atencion.NroHC);
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

        public List<Atencion> getAll()
        {
            var atencionDataModel = atencionRepository.GetAll();
            listAtenciones = new List<Atencion>();
            listAtenciones = atencionDataModel.ToList();
            return listAtenciones;
        }
    }
}
