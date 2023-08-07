using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referencias
using System.Data;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CapaDatos.Repository
{
    //Se encarga de ejecutar los comandos SQL, la usaremos en todos los repositorios
    public abstract class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;

        //Se utiliza para ejecutar métodos de no consulta, como insertar, editar y eliminar datos
        protected int ExecuteNonQuery(string sql) {
            //El objeto sqlconnection existira hasta que las lineas dentro de los corchetes terinen de ejecutarse, al terminar el objeto sera desechado y liberado los recursos. De esta manera se liberamos espacio, pero desechar un objeto depende mucho de lo que se quiera hacer, puede ser que necesitemos mantener activo un objeto por mas tiempo y recuperar los valores. Sin embargo el tiempo de vida por defecto se mantendra vivo hasta que no tenga ninguna referencia.
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;//No es recomendado el uso de procedimientos almacenados que contengan lógica de negocios ya que se sacrifica el mantenimiento a cambio de rendimiento
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();//Ejecuta un comando transact sql y retorna el número de filas afectadas, por esa razón guardamos el resultado en esta variable y retornamos cuantas filas fueron afectadas editadas o eliminadas. Sin embargo esto es opcional, podemos declarar el retorno del metodo como VOID si no queremos devolver la cantidad de filas afectadas
                    parameters.Clear();
                    return result;
                }
            }
        }

        //Se utiliza para ejecutar métodos de consulta, es decir para leer filas de tablas y mostrar los datos de una tabla
        protected DataTable ExecuteReader(string sql) 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();//Ejecuta el lector para leer filas de tablas
                    using (var table = new DataTable()) //Creamos un objeto DataTable
                    {
                        table.Load(reader);//Cargamos el resultado del lector a la tabla
                        reader.Dispose();//Desechamos el lector
                        return table;
                    }
                }
            }
        }

        //Esta clase es generica para todas las clases repositorios, si tenemos funciones comunes en muchas clases es mejor crear una funcion generica que sirva a todos. Tambien tenemos que tener en cuenta el tiempo de vida de un objeto al crear una instancia, lo que se hace es separar espacio en la memoria ram, si no tenemos cuidado con ello simplemente llenaremos la memoria ram. Por lo tanto no debemos crear instancias por doquier. La interfaz iDisposable permite desechar la instancia y liberar los cursos utilizados
    }
}
