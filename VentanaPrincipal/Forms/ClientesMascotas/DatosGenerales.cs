using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
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
        CN_Cliente clienteNegocio = new CN_Cliente();
        Cliente cliente = new Cliente();
        int idCliente = -1;

        public DatosGenerales()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            clienteNegocio.State = EntityState.Added;
        }

        public DatosGenerales(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lblUserName.Text = cliente.Nombre+" "+cliente.Apellido;
            txtNumeroDocumento.Text = cliente.NumeroDocumento;
            cbTipoDocumento.Text = cliente.TipoDocumento;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCalle.Text = cliente.Calle;
            txtAltura.Text = cliente.Altura;
            clienteNegocio.State = EntityState.Modified;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd ventanaAddOwner = Owner as formAdd;
            cliente.NumeroDocumento = txtNumeroDocumento.Text;
            cliente.TipoDocumento = cbTipoDocumento.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Calle = txtCalle.Text;
            cliente.Altura = txtAltura.Text;

            clienteNegocio.Cliente = cliente;

            bool valid = new Helps.DataValidation(cliente).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                string result = clienteNegocio.SaveChanges();
                MessageBox.Show(result);
                ventanaAddOwner.cargarCliente(cliente.NumeroDocumento);
                this.Close();

                // Verifica si el formulario Form2 está abierto
                if (Application.OpenForms["formAdd"] != null)
                {
                    // Si está abierto, cierra el formulario Form2
                    Application.OpenForms["formAdd"].Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clienteNegocio.State = EntityState.Deleted;
            clienteNegocio.Cliente = cliente;
            string result = clienteNegocio.SaveChanges();
            MessageBox.Show(result);
            this.Close();

            // Verifica si el formulario Form2 está abierto
            if (Application.OpenForms["formAdd"] != null)
            {
                // Si está abierto, cierra el formulario Form2
                Application.OpenForms["formAdd"].Close();
            }
        }
    }
}
