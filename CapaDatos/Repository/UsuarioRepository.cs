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
            insert = "INSERT INTO usuarios (n_usuario, password, nombre, id_tipo) VALUES(@n_usuario, @password, @nombre, @id_tipo)";
            update = "UPDATE usuarios SET usuario=@n_usuario, password=@password, nombre=@nombre, id_tipo=@id_tipo";
            delete = "DELETE FROM usuarios WHERE usuario=@n_usuario and id_tipo=@id_tipo";
            
        }

       public int Add(Usuario usuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
            parameters.Add(new SqlParameter("@id_tipo", usuario.Id_tipo));

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
                    Nombre = item[3].ToString(),
                    Id_tipo = (int)item[4],
                });
            }
            return listUsuario;
        }

        public int Remove(String usuario, String id_tipo)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario));
            parameters.Add(new SqlParameter("@id_tipo", id_tipo));
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


        public int Update(Usuario usuario, string n_usuario, string id_tipo)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
            parameters.Add(new SqlParameter("@id_tipo", usuario.Id_tipo));

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
