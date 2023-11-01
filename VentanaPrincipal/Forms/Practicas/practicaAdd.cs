using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
//using MySqlX.XDevAPI;
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
        private Practica practicaOriginal;
        public practicaAdd()
        {
            InitializeComponent();
            
             //practicaNegocio.State = EntityState.Added;
        }
        
        public practicaAdd(Practica practica)
        {
            InitializeComponent();
            practicaOriginal = practica;
            //this.practica = practica;
            txtPractica.Text = practica.Descripcion;
            double precioFloat = practica.Precio;
            txtPrecio.Text = precioFloat.ToString();
            //practicaNegocio.State = EntityState.Modified;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CN_Practica cN_Practica = new CN_Practica();
            Practica practica = new Practica();

            practica.Descripcion = txtPractica.Text;
            practica.Precio = Convert.ToDouble(txtPrecio.Text);
            //practicaNegocio.Practica = practica;

            bool valid = new Helps.DataValidation(practica).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                string result;
                if (practicaOriginal != null)
                {
                    result = cN_Practica.Update(practica, practicaOriginal.CodPractica);
                }
                else
                {
                    result = cN_Practica.Add(practica);
                }

                MessageBox.Show(result);
                Close();
            }
        }

        private void Limpiar()
        {
            txtPractica.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //practicaNegocio.State = EntityState.Deleted;
            //practicaNegocio.Practica = practica;
            //string result = practicaNegocio.SaveChanges();
            //MessageBox.Show(result);
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
