using CapaEntidadaes.Entities;
using CapaNegocio.Models;
using System;
using System.Windows.Forms;
using VentanaPrincipal;
using VentanaPrincipal.Helps;

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
                    if (usuarioOriginal == null)
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
    }
}
