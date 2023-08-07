using System;
using System.Windows.Forms;
using System.Windows.Markup;

//Referencias
using CapaEntidades.Entities;
using CapaNegocio.Models;

namespace VentanaPrincipal
{
    public partial class addOwner : Form
    {
        Cliente clienteOriginal;

        public addOwner()
        {
            InitializeComponent();
            btnAdd.Text = "Registrar";
        }
        
        public addOwner(Cliente cliente)
        {
            InitializeComponent();
            this.clienteOriginal = cliente;
            txtNumeroDocumento.Text = cliente.NumeroDocumento;
            cbTipoDocumento.Text = cliente.TipoDocumento;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.Calle;
            txtAltura.Text = cliente.Altura.ToString();
            btnAdd.Text = "Actualizar";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CN_Cliente clienteNegocio = new CN_Cliente();
            Cliente clienteActual = new Cliente();
            clienteActual.NumeroDocumento = txtNumeroDocumento.Text;
            clienteActual.TipoDocumento = cbTipoDocumento.Text;
            clienteActual.Nombre = txtNombre.Text;
            clienteActual.Apellido = txtApellido.Text;
            clienteActual.Calle = txtCalle.Text;
            clienteActual.Altura = txtAltura.Text;

            bool valid = new Helps.DataValidation(clienteActual).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                try
                {
                    string result;
                    if (clienteOriginal == null)
                    {
                        result = clienteNegocio.Add(clienteActual);
                    } else
                    {
                        result = clienteNegocio.Update(clienteActual, clienteOriginal.NumeroDocumento, clienteOriginal.TipoDocumento);
                    }

                    MessageBox.Show(result);
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
            txtNumeroDocumento.Text = string.Empty;
            cbTipoDocumento.SelectedItem = null;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroDocumento_Click(object sender, EventArgs e)
        {

        }
    }
}
