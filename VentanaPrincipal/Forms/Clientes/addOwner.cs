using System;
using System.Windows.Forms;

//Referencias
using CapaEntidades.Entities;
using CapaEntidades.ValueObjects;
using CapaNegocio.Exceptions;
using CapaNegocio.Models;

namespace VentanaPrincipal
{
    public partial class addOwner : Form
    {
        CN_Cliente cN_Cliente = new CN_Cliente();
        public addOwner()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente 
            {
                NumeroDocumento = txtNumeroDocumento.Text,
                TipoDocumento = cbTipoDocumento.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Calle = txtCalle.Text,
                Altura = Convert.ToInt32(txtAltura.Text),
                State = EntityState.Added
            };

            bool valid = new Helps.DataValidation(c).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                try
                {
                    string result = cN_Cliente.SaveChanges(c);//Este método retorna un mensaje, asi que lo guardamos para mostrarlo.
                    DialogResult = DialogResult.OK;
                    Close();
                    MessageBox.Show(result);
                }
                catch (RegistroDuplicadoException ex)
                {
                    //Muestra el mensaje de la excepcion generada por ser un registro duplicado
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            
        }
        private void Limpiar()
        {
            txtNumeroDocumento.Text = string.Empty;
            cbTipoDocumento.SelectedItem = null;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
        }
    }
}
