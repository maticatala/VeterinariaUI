using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencias
using CapaEntidades.Entities;
using CapaNegocio.Models;

namespace VentanaPrincipal.Forms.Veterinarios
{
    public partial class addVeterinario : Form
    {
        private Veterinario veterinarioOriginal;
        public addVeterinario()
        {
            InitializeComponent();
            btnAdd.Text = "Registrar";
        }

        public addVeterinario(Veterinario veterinario)
        {
            InitializeComponent();
            veterinarioOriginal = veterinario;
            txtNombre.Text = veterinario.Nombre;
            txtApellido.Text = veterinario.Apellido;
            txtMatricula.Text = veterinario.Matricula;
            txtCalle.Text = veterinario.Calle;
            txtAltura.Text = veterinario.Altura;
            txtTelefono.Text = veterinario.Telefono;
            btnAdd.Text = "Actualizar";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CN_Veterinario cN_Veterinario = new CN_Veterinario();
            Veterinario veterinario = new Veterinario();

            veterinario.Nombre = txtNombre.Text;
            veterinario.Apellido = txtApellido.Text;
            veterinario.Matricula = txtMatricula.Text;
            veterinario.Calle = txtCalle.Text;
            veterinario.Altura = txtAltura.Text;
            veterinario.Telefono = txtTelefono.Text;

            //Validacion de datos
            bool valid = new Helps.DataValidation(veterinario).Validate();
            if(valid)
            {
                try
                {
                    string result = cN_Veterinario.Add(veterinario);

                    MessageBox.Show(result);
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
