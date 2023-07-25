using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private MySqlConnection conexion = new MySqlConnection();

        public MySqlConnection abrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.ConnectionString = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;
                    conexion.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("No se logro conectar a la base de datos" + ex.ToString());
            }
            return conexion;
        }
        public MySqlConnection cerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
