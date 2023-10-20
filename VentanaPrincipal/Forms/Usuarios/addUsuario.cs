using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
using MySqlX.XDevAPI;
using System;
using System.Windows.Forms;
using System.Windows.Interop;
using VentanaPrincipal;
using VentanaPrincipal.Forms.Clientes;
using VentanaPrincipal.Helps;

namespace Sistema
{
    public partial class frmRegistro : Form
    {
        private Usuario usuarioOriginal;

        public frmRegistro()
        {
            InitializeComponent();
            //usuarioNegocio.State = EntityState.Added;
        }

        public frmRegistro(Usuario usuario)
        {
            InitializeComponent();
            usuarioOriginal = usuario;
            txtNombre.Text = usuario.N_usuario;
            txtPassword.Text = usuario.Password;
            cbUsuario.Text = usuario.Tipo_usuario;
            txtConPassword.Text = usuario.Password;
            //usuarioNegocio.State = EntityState.Modified;
            
        }
        private void Limpiar()
        {
            txtConPassword.Text = string.Empty;
            cbUsuario.SelectedItem = null;
            txtNombre.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnRegistrar_Click_2(object sender, EventArgs e)
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
                lblErrorMessage.Visible = true;
                valid = false;
            }


            if (valid)
            {
                try
                {
                    string result;
                    if (usuarioOriginal != null)
                    {

                        result = usuarioNegocio.Update(usuarioActual, usuarioOriginal.Id);
                    }
                    else
                    {
                        result = usuarioNegocio.Add(usuarioActual);
                    }
                    this.Close();
                    MessageBox.Show(result);
                    //MainForm frm = new MainForm(usuarioActual);
                    //frm.Visible = true;
                    //this.Visible = false;

                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
