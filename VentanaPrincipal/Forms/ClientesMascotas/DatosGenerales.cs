using CapaEntidades.Entities;
using CapaNegocio.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.Clientes
{
    public partial class DatosGenerales : Form
    {
        Cliente clienteOriginal;

        public DatosGenerales()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }

        public DatosGenerales(Cliente cliente)
        {
            InitializeComponent();
            txtNumeroDocumento.Text = cliente.NumeroDocumento;
            cbTipoDocumento.Text = cliente.TipoDocumento;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.Calle;
            txtAltura.Text = cliente.Altura;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd ventanaAddOwner = Owner as formAdd;
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
                        ventanaAddOwner.cargarCliente(clienteNegocio.findByDoc(clienteActual.NumeroDocumento));
                    }
                    else
                    {
                        result = clienteNegocio.Update(clienteActual);
                    }

                    MessageBox.Show(result);
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
    }
}
