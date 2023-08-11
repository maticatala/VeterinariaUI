//using MySql.Data.MySqlClient;
using CapaDatos.Contracts;
using CapaDatos.Exceptions;
using CapaEntidadaes.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repository
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;


        //SqlConnection conexion = conexion.getConexion();
        //conexion.Open();
        public UsuarioRepository()
        {
            selectAll = "SELECT * FROM usuarios";
            insert = "INSERT INTO usuarios (n_usuario, password, id, tipo_usuario, conPassword) VALUES(@n_usuario, @password, @id, @tipo_usuario, @conPassword)";
            update = "UPDATE usuarios SET n_usuario=@n_usuario, password=@password, id=@tipo_usuario, tipo_usuario=@tipo_usuario, conPassword=@conPassword";
            delete = "DELETE FROM usuarios WHERE n_usuario=@n_usuario and tipo_usuario=@tipo_usuario";
            
        }

       public int Add(Usuario usuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@id", usuario.Id));
            parameters.Add(new SqlParameter("@conPassword", usuario.ConPassword));
            parameters.Add(new SqlParameter("@tipo_usuario", usuario.Tipo_usuario));

            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 1062)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            
            var tableResult = ExecuteReader(selectAll);
            var listUsuario = new List<Usuario>();
            
            foreach (DataRow item in tableResult.Rows)
            {
                listUsuario.Add(new Usuario
                {
                    Id = (int)item[0],
                    N_usuario = item[1].ToString(),
                    Password = item[2].ToString(),
                    ConPassword = item[3].ToString(),
                    Tipo_usuario = item[4].ToString()
                });
            }
            return listUsuario;
        }

        public bool ExisteUsuario(int id, string usuario)
        {
            using (SqlConnection conexion = new SqlConnection("sqlserverconex")) // Reemplaza "cadena_de_conexion" con tu cadena de conexión real
            {
                conexion.Open();

                string sql = "SELECT id and n_usuario FROM usuarios WHERE n_usuario = @n_usuario and id=@id";
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        





        public int Remove(String n_usuario, String tipo_usuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", n_usuario));
            parameters.Add(new SqlParameter("@tipo_usuario", tipo_usuario));
            return ExecuteNonQuery(delete);

        }

        public int Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }


        public int Update(Usuario usuario, string n_u, string t_u)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@conPassword", usuario.ConPassword));
            parameters.Add(new SqlParameter("@tipo_usuario", usuario.Tipo_usuario));
            parameters.Add(new SqlParameter("@oldN_Usuario", n_u));
            parameters.Add(new SqlParameter("oldT_Usuario",t_u));

            try
            {
                return ExecuteNonQuery(update);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 1062)
                    //Si el registro esta duplicado cramos una instancia de la excepcion personalizada RegistroDuplicadoException a la que le pasamos por parametro el mensaje de debe mostrar.
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    //Si el problema se debe a otro motivo, lanzamos la excepcion generica
                    throw ex;
            }
        }

        IEnumerable<Usuario> IGenericRepository<Usuario, string>.GetAll()
        {
            throw new NotImplementedException();
        }

        public string ctrlLogin(string usuario, string password)
        {
            throw new NotImplementedException();
        }
        //public bool existeUsuario(string usuario)
        //{
        //    SqlDataReader reader;
        //    SqlConnection conexion = Conexion.getConexion();
        //    conexion.Open();

        //    string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
        //    SqlCommand comando = new SqlCommand(sql, conexion);
        //    comando.Parameters.AddWithValue("@usuario", usuario);
        //    reader = comando.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //    { return false; }
        //}

        //public Usuarios porUsuario(string usuario)
        //{
        //    SqlDataReader reader;
        //    SqlConnection conexion = Conexion.getConexion();
        //    conexion.Open();

        //    string sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario";
        //    SqlCommand comando = new SqlCommand(sql, conexion);
        //    comando.Parameters.AddWithValue("@usuario", usuario);
        //    reader = comando.ExecuteReader();
        //    Usuarios usr = null;

        //    while (reader.Read())
        //    {
        //        usr = new Usuarios();
        //        usr.Id = int.Parse(reader["id"].ToString());
        //        usr.Password = reader["password"].ToString();
        //        usr.Nombre = reader["nombre"].ToString();
        //        usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());

        //    }
        //    return usr;
        //}
    }
}
