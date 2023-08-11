using CapaDatos.Contracts;
using CapaDatos.Repository;
using CapaEntidadaes.Entities;
using Models;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.Usuarios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            
        }
        

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                frmRegistro frm = new frmRegistro();
                frm.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnIngresa_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            if (txtUsuario.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtPassword.Text);
                    if(validLogin == true)
                    {
                        MainForm frm = new MainForm();
                        frm.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        msgErrror("Usuario o Contraseña Incorrectos!");
                        txtUsuario.Clear();
                        txtPassword.Clear();

                    }
                }
                else msgErrror("Por Favor Ingrese la Contraseña!");
            }
            else
            {
                msgErrror("Por Favor Ingrese Nombre de Usuario!");
            }

            //try
            //{
            //    UsuarioRepository ctrl = new UsuarioRepository();
            //    string respuesta = ctrl.ctrlLogin(usuario, password);
            //    if (respuesta.Length > 0)
            //    {
            //        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MainForm frm = new MainForm();
            //        frm.Visible = true;
            //        this.Visible = false;

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        public string ctrlLogin(string usuario, string password)
        {
            UsuarioRepository modelo = new UsuarioRepository();
            string respuesta = "";
            Usuario datosUsuarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos!";
            }
            else
            {
                //datosUsuarios = modelo.porUsuario(usuario);
                if (datosUsuarios == null)
                    {
                        respuesta = "El usuario no existe!";
                    }
                    else
                    {
                        if (datosUsuarios.Password != generarSHA1(password))
                        {
                            respuesta = "El usuario y/o la contraseña no coinciden!";
                        }
                        else
                        {

                            Session.id = datosUsuarios.Id;
                            Session.n_usuario = usuario;
                            Session.password = datosUsuarios.Password;
                            Session.tipo_usuario = datosUsuarios.Tipo_usuario;

                        }
                    }
            }
            return respuesta;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
           
        }
        private void msgErrror(string msg)
        {
            lblErrorMessage.Text = "   "+msg;
            lblErrorMessage.Visible = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
