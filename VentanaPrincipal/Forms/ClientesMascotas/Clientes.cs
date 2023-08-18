using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades.Entities;

//Referencias
using CapaNegocio.Models;

namespace VentanaPrincipal
{
    public partial class dueñosForm : Form
    {
        private CN_Cliente cN_Cliente = new CN_Cliente();

        public dueñosForm()
        {
            InitializeComponent();
        }

        private void dueñosForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            try
            {
                cgvOwners.DataSource = cN_Cliente.getAll();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvOwners.DataSource = cN_Cliente.FindByFilter(txtBuscar.Text);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            formAdd formAddOwner = new formAdd();
            formAddOwner.ShowDialog();
            cargarTabla();
        }

        private void cgvOwners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
            Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
            MessageBox.Show(clienteSeleccionado.IdCliente.ToString());
        }

        private void cgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
            Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
            MessageBox.Show(cN_Cliente.getMacotas(clienteSeleccionado.IdCliente).Count.ToString());
        }
    }
}
