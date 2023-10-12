using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Models;
using CapaEntidadaes.Entities;

namespace VentanaPrincipal.Forms.Practicas
{
    public partial class practicasForm : Form
    {
        private CN_Practica cN_Practica = new CN_Practica();
        public practicasForm()
        {
            InitializeComponent();
        }

       

        private void practicasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet2.practicas' table. You can move, or remove it, as needed.
            //this.practicasTableAdapter.Fill(this.veterinariaDataSet2.practicas);
            // TODO: This line of code loads data into the 'veterinariaDataSet3.practicas' table. You can move, or remove it, as needed.
            //this.practicasTableAdapter.Fill(this.veterinariaDataSet3.practicas);

            cargarTablaPracticas();
            if(cgvPracticas.Rows.Count > 0) 
            {
                DataGridViewRow filaSeleccionada = cgvPracticas.SelectedRows[0];
                Cliente clienteSeleccionado = (Cliente) filaSeleccionada.DataBoundItem;
            }
            
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cgvPracticas.DataSource = cN_Practica.findByFilter(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
        private void cargarTablaPracticas()
        {
            try
            {
                cgvPracticas.DataSource = cN_Practica.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void cgvPracticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvPracticas.SelectedRows[0];
        }

        private void practicasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            practicaAdd practicaAdd = new practicaAdd();
            practicaAdd.ShowDialog();
            cargarTablaPracticas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgvPracticas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvPracticas.SelectedRows[0];
            Practica practicaSeleccionada = (Practica)filaSeleccionada.DataBoundItem;

            practicaAdd addPractica = new practicaAdd(practicaSeleccionada);
            addPractica.ShowDialog();
            cargarTablaPracticas();
        }
    }
}
