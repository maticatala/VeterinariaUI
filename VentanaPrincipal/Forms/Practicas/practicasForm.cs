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

namespace VentanaPrincipal.Forms.Practicas
{
    public partial class practicasForm : Form
    {
        private cN_Practica CN_Practica = new cN_Practica();
        public practicasForm()
        {
            InitializeComponent();
        }

        private void practicasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet.practicas' table. You can move, or remove it, as needed.
            this.practicasTableAdapter.Fill(this.veterinariaDataSet.practicas);

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

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            practicaAdd addPractica = new practicaAdd();
            addPractica.ShowDialog();
            cargarTablaPracticas();
        }
    }
}
