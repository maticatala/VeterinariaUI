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
        Cliente c = new Cliente();

        public addOwner(EntityState estado)
        {
            InitializeComponent();
            c.State = estado;
        }

        public void editar(DataGridViewRow filaSeleccionada, string btnText)
        {
            txtNumeroDocumento.Text = filaSeleccionada.Cells[0].Value.ToString();
            cbTipoDocumento.Text = filaSeleccionada.Cells[1].Value.ToString(); 
            txtNombre.Text = filaSeleccionada.Cells[2].Value.ToString(); 
            txtApellido.Text = filaSeleccionada.Cells[3].Value.ToString(); 
            txtCalle.Text = filaSeleccionada.Cells[4].Value.ToString(); 
            txtAltura.Text = filaSeleccionada.Cells[5].Value.ToString(); 
            btnAdd.Text = btnText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.NumeroDocumento = txtNumeroDocumento.Text;
            c.TipoDocumento = cbTipoDocumento.Text;
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.Calle = txtCalle.Text;
            c.Altura = Convert.ToInt32(txtAltura.Text);

            bool valid = new Helps.DataValidation(c).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                try
                {
                    string result = cN_Cliente.SaveChanges(c);//Este método retorna un mensaje, asi que lo guardamos para mostrarlo.
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
