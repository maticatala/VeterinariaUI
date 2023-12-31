﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Entities;
using CapaDatos.Exceptions;
using System.Data.SqlClient;
using CapaDatos.Contracts;
using NPOI.SS.Formula.Functions;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities.Collections;
using System.Data;
using CapaEntidadaes.Entities;

namespace CapaDatos.Repository
{
    public class PracticaRepository: MasterRepository, IPracticaRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public PracticaRepository()
        {
            selectAll = "SELECT * FROM practicas";
            insert = "INSERT INTO practicas VALUES (@descripcion,@precio)";
            update = "UPDATE practicas SET descripcion=@descripcion, precio=@precio where codPractica=@oldPractica";
            delete = "DELETE FROM practicas WHERE codPractica=@codPractica";
        }
       
        public int Add(Practica practica)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@descripcion", practica.Descripcion));
            parameters.Add(new SqlParameter("@precio", practica.Precio));

            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 2627)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }
        }

        public IEnumerable<Practica> GetAll()
        {
            //Declaramos una variable implicita de nombre tableResult que sera igual método ExecuteReader del repositorio maestro, este metodo requiere que enviemos una cadena de comando sql y devuelve un DataTable
            var tableResult = ExecuteReader(selectAll);
            var listPractica = new List<Practica>();
            //Por cada iteracion agregamos un nuevo objeto empleado a la lista de empleados
            foreach (DataRow item in tableResult.Rows)
            {
                listPractica.Add(new Practica
                {
                    CodPractica = (int)item[0],
                    Descripcion = item[1].ToString(),
                    Precio = Convert.ToDouble(item[2]),
                    
                }) ;
            }
            return listPractica;
        }

        public int Update(Practica practica, int Pra)
        {
            parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@codPractica", practica.CodPractica));
            parameters.Add(new SqlParameter("@descripcion", practica.Descripcion));
            parameters.Add(new SqlParameter("@precio", practica.Precio));
            parameters.Add(new SqlParameter("@oldPractica", Pra));

            return ExecuteNonQuery(update);
        }

        public List<Practica> getPractica(int codPractica)
        {
            string sql = $"select * from practicas where codPractica={codPractica}";
            var tableResult = ExecuteReader(sql);
            var listPracticas = new List<Practica>();

            foreach (DataRow item in tableResult.Rows)
            {
                listPracticas.Add(new Practica
                {
                    CodPractica = Convert.ToInt32(item[0]),
                    Descripcion = item[1].ToString(),
                    Precio = Convert.ToDouble(item[2])
                });
            }
            return listPracticas;
        }

        public int Remove(int codPractica)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@codPractica", codPractica));
            return ExecuteNonQuery(delete);
        }

        public int Update(Practica entity)
        {
            throw new NotImplementedException();
        }
    }

    
}
