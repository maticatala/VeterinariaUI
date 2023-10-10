using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
using MySqlX.XDevAPI;
using System;
using System.Windows.Forms;
using VentanaPrincipal;
using VentanaPrincipal.Forms.Clientes;
using VentanaPrincipal.Helps;

namespace Sistema
{
    public partial class frmRegistro : Form
    {
        CN_Usuario usuarioNegocio = new CN_Usuario();
        Usuario usuario = new Usuario();
        int id = -1;

        public frmRegistro()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            usuarioNegocio.State = EntityState.Added;
        }

        public frmRegistro(Usuario oldusuario)
        {
            InitializeComponent();
            usuario.N_usuario = oldusuario.N_usuario;
            usuario.Tipo_usuario = oldusuario.Tipo_usuario.ToString();
            usuario.Password = oldusuario.Password;
            txtNombre.Text = usuario.N_usuario;
            txtPassword.Text = usuario.Password;
            cbUsuario.Text = usuario.Tipo_usuario;
            usuarioNegocio.State = EntityState.Modified;
            
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            CN_Usuario usuarioNegocio = new CN_Usuario();
            Usuario usuarioActual = new Usuario();
            usuarioActual.N_usuario = txtNombre.Text;
            usuarioActual.Tipo_usuario = cbUsuario.Text;


            bool valid = new DataValidation(usuarioActual).Validate();

            if (txtPassword.Text == txtConPassword.Text)
                usuarioActual.Password = txtPassword.Text;
            else
            {
                lblConfirmar.Text = "Las contraseñas no coinciden";
                valid = false;
            }
                

            if (valid)
            {
                try
                {
                    string result;
                    if (usuario == null)
                    {
                        result = usuarioNegocio.Add(usuarioActual);
                    }
                    this.Close();

                    MainForm frm = new MainForm(usuarioActual);
                    frm.Visible = true;
                    this.Visible = false;

                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }


        }
        private void Limpiar()
        {
            txtConPassword.Text = string.Empty;
            cbUsuario.SelectedItem = null;
            txtNombre.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_2(object sender, EventArgs e)
        {
            usuario.N_usuario = txtNombre.Text;
            usuario.Password = txtPassword.Text;
            usuario.Tipo_usuario = cbUsuario.Text;
            usuarioNegocio.Usuario = usuario;

            bool valid = new VentanaPrincipal.Helps.DataValidation(usuario).Validate();
            if (valid)
            {
                string result = usuarioNegocio.SaveChanges();
                MessageBox.Show(result);
                this.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            usuarioNegocio.State = EntityState.Deleted;
            usuarioNegocio.Usuario = usuario;
            string result = usuarioNegocio.SaveChanges();
            MessageBox.Show(result);
            this.Close();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
