using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CapaDatos.Repository
{
    //Este repositorio se encarga de realizar la conexion con la base de datos.
    //Clase publica y abstracta, esta clase no puiede ser instanciada, pero si se puede heredar y las clases hijas seran las encargadas de agregar la funcionalidad a los metodos abstractos si es que los tuviesen. Las interfaces y las clases abstractas son similares, pero las interfaces son 100% abstractas en cambio una clase abstracta puede tener funcionalidades ya definidas.
    public abstract class Repository
    {
        private readonly string connectionString; 

        public Repository()//Constructor
        {
            connectionString = ConfigurationManager.ConnectionStrings["sqlserverconex"].ConnectionString;//Obtiene el connectionString del app.config de la capa de presentacion
        }

        //Este metodo es protegido ya que quiero que solo pueda ser utilizado por la misma clase y las clases que deriven de ellas
        protected SqlConnection GetConnection() //Método protegido para obtener la conexion
        {
            return new SqlConnection(connectionString);
        }
    }
}
