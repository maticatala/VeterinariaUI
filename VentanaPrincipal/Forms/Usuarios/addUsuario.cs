using CapaEntidadaes.Entities;
using CapaNegocio.Models;
using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmRegistro : Form
    {
        Usuario usuarioOriginal;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            CN_Usuario usuarioNegocio = new CN_Usuario();
            Usuario usuarioActual = new Usuario();
            usuarioActual.Nombre = txtNombre.Text;
            usuarioActual.Password = txtPassword.Text;
            usuarioActual.ConPassword = txtConPassword.Text;
            usuarioActual.Nombre = txtNombre.Text;
            usuarioActual.TipoUsuario = cbUsuario.Text;

            bool valid = new VentanaPrincipal.Helps.DataValidation(usuarioActual).Validate();

            if (valid)
            {
                try
                {
                    string result;
                    if (usuarioOriginal == null)
                    {
                        result = usuarioNegocio.Add(usuarioActual);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
