using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
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
        cN_Practica practicaNegocio = new cN_Practica();
        Practica practica = new Practica();
        int codPractica = -1;
        public practicaAdd()
        {
            InitializeComponent();
        }
        
        public practicaAdd(Practica practica)
        {
            InitializeComponent();
            this.practica = practica;
            txtDescripcion.Text = practica.Descripcion;
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
            practica.Descripcion = txtDescripcion.Text;
            practicaNegocio.Practica = practica;

            bool valid = new Helps.DataValidation(practica).Validate(); //Si la validacion es true entonces podemos invocar el metodo de guardar cambios.
            if (valid)
            {
                string result = practicaNegocio.SaveChanges();
                MessageBox.Show(result);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
