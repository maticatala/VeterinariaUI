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
        private CN_Practica CN_Practica = new CN_Practica();
        public practicasForm()
        {
            InitializeComponent();
        }

       

        private void practicasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet.practicas' table. You can move, or remove it, as needed.
            this.practicasTableAdapter.Fill(this.veterinariaDataSet.usuarios);
            cargarTablaPracticas();
            if(cgvPracticas.Rows.Count > 0) 
            {
                DataGridViewRow filaSeleccionada = cgvPracticas.SelectedRows[0];
                Practica practicaSeleccionada = (Practica)filaSeleccionada.DataBoundItem;
            }
            
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cgvPracticas.DataSource = CN_Practica.findByFilter(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cgvPracticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvPracticas.SelectedRows[0];
            Practica practicaSeleccionada = (Practica)filaSeleccionada.DataBoundItem;

            practicaAdd practicaAdd = new practicaAdd(practicaSeleccionada);
            practicaAdd.ShowDialog();
            cargarTablaPracticas();
        }
        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
        private void cargarTablaPracticas()
        {
            try
            {
                cgvPracticas.DataSource = CN_Practica.getAll();
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
            practicaAdd practicaAdd = new practicaAdd();
            practicaAdd.ShowDialog();
            cargarTablaPracticas();
        }

        private void cgvPracticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void practicasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
