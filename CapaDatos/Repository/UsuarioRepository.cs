//using MySql.Data.MySqlClient;
using CapaDatos.Contracts;
using CapaDatos.Exceptions;
using CapaEntidades.Entities;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            insert = "INSERT INTO usuarios (n_usuario, password, tipo_usuario) VALUES(@n_usuario, @password, @tipo_usuario)";
            update = "UPDATE usuarios SET n_usuario=@n_usuario, password=@password,tipo_usuario=@tipo_usuario where id=@oldId";
            delete = "DELETE FROM usuarios WHERE id=@id";
            
        }

        public int Add(Usuario usuario)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@tipo_usuario", usuario.Tipo_usuario));

            try
            {
                return ExecuteNonQuery(insert);
            }
            catch (SqlException ex)
            {
                if (ex != null && ex.Number == 2627)
                    throw new RegistroDuplicadoException("Registro duplicado");
                else
                    throw ex;
            }
        }

        IEnumerable<Usuario> IGenericRepository<Usuario, string>.GetAll()
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
                    Tipo_usuario = item[3].ToString()
                });
            }
            return listUsuario;
        }

        public Usuario getOne(string username, string password)
        {
            Usuario usuarioEncontrado = new Usuario();
            string query = $"SELECT * FROM usuarios WHERE n_usuario = '{username}' and password = '{password}' ";
            
            var tableResult = ExecuteReader(query);

            if (tableResult.Rows.Count > 0)
            {
                foreach (DataRow item in tableResult.Rows)
                {
                    usuarioEncontrado.Id = (int)item[0];
                    usuarioEncontrado.N_usuario = item[1].ToString();
                    usuarioEncontrado.Password = item[2].ToString();
                    usuarioEncontrado.Tipo_usuario = item[3].ToString();
                }
            }
            else
            {
                throw new RegistroInexistenteException("Usuario o Contraseña Incorrectos");
            }

            return usuarioEncontrado;
        }


        public int RemoveUsuario(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id",id));
            return ExecuteNonQuery(delete);
        }

        public int Update(Usuario usuario, int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@n_usuario", usuario.N_usuario));
            parameters.Add(new SqlParameter("@password", usuario.Password));
            parameters.Add(new SqlParameter("@tipo_usuario", usuario.Tipo_usuario));
            parameters.Add(new SqlParameter("@oldId", id));


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
        public string ctrlLogin(string usuario, string password)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public int Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
