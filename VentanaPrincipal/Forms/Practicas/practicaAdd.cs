using CapaEntidadaes.Entities;
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

namespace VentanaPrincipal.Forms.Practicas
{
    public partial class practicaAdd : Form
    {
        CN_Practica practicaNegocio = new CN_Practica();
        Practica practica = new Practica();
        public practicaAdd()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            practicaNegocio.State = EntityState.Added;
        }
        
        public practicaAdd(Practica practica)
        {
            InitializeComponent();
            this.practica = practica;
            txtPractica.Text = practica.Descripcion;
            float precioFloat = practica.Precio;
            txtPrecio.Text = precioFloat.ToString();
            practicaNegocio.State = EntityState.Modified;
        }
        private void practicaAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            practica.Descripcion = txtPractica.Text;
            practica.Precio = float.Parse(txtPrecio.Text);
            practicaNegocio.Practica = practica;

            bool valid = new Helps.DataValidation(practica).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                string result = practicaNegocio.SaveChanges();
                MessageBox.Show(result);
                }
        }

        private void Limpiar()
        {
            txtPractica.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            practicaNegocio.State = EntityState.Deleted;
            practicaNegocio.Practica = practica;
            string result = practicaNegocio.SaveChanges();
            MessageBox.Show(result);
            this.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
