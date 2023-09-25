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
            if (cgvOwners.Rows.Count > 0)
            {
                cgvOwners.Rows[0].Selected = true;
                DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
                Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
                List<Mascota> mascotasCliente = new List<Mascota>();
                mascotasCliente = cN_Cliente.getMacotas(clienteSeleccionado.IdCliente);
                dgvMascotas.DataSource = mascotasCliente;
            }
        }

        private void CgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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

            formAdd formAddOwner = new formAdd(clienteSeleccionado);
            formAddOwner.ShowDialog();
            cargarTabla();
        }

        private void cgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
            Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
            List<Mascota> mascotasCliente = new List<Mascota>();
            mascotasCliente = cN_Cliente.getMacotas(clienteSeleccionado.IdCliente);
            dgvMascotas.DataSource = mascotasCliente;
        }

        private void cgvOwners_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
            Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
            List<Mascota> mascotasCliente = new List<Mascota>();
            mascotasCliente = cN_Cliente.getMacotas(clienteSeleccionado.IdCliente);
            dgvMascotas.DataSource = mascotasCliente;
        }
    }
}
