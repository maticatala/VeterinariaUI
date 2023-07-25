using CapaEntidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos.DAO
{
    public class clienteDAO : ICRUD<Cliente>
    {
        private CD_Conexion conexion = new CD_Conexion();
        public void add(Cliente t)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> getAll()
        {
            throw new NotImplementedException();
        }

        public Cliente getOne(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Cliente t)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> filtrarPorDato(string dato)
        {
            MySqlDataReader reader;
            List<Cliente> clientes = new List<Cliente>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM clientes ORDER BY nombre ASC";
            }
            else
            {
                sql = $"SELECT * FROM clientes WHERE nroDoc LIKE '%{dato}%' OR tipoDoc LIKE '%{dato}%' OR nombre LIKE '%{dato}%' OR apellido LIKE '%{dato}%' OR calle LIKE '%{dato}%' OR altura LIKE '%{dato}%' ORDER BY nombre ASC";
            }

            MySqlConnection conexionBD = conexion.abrirConexion();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.NumeroDocumento = reader.GetString("nroDoc");
                    c.TipoDocumento = reader.GetString("tipoDoc");
                    c.Nombre = reader.GetString("nombre");
                    c.Apellido = reader.GetString("apellido");
                    c.Calle = reader.GetString("calle");
                    c.Altura = int.Parse(reader.GetString("altura"));

                    clientes.Add(c);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
            return clientes;
        }
    }
}
