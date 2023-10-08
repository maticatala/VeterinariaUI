using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades.Entities;

//Referencias
using CapaNegocio.Models;
using VentanaPrincipal.Forms.Usuarios;

namespace VentanaPrincipal
{
    public partial class dueñosForm : Form
    {
        private CN_Cliente CN_Mascota = new CN_Cliente();

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
                mascotasCliente = CN_Mascota.getMacotas(clienteSeleccionado.IdCliente);
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
                cgvOwners.DataSource = CN_Mascota.getAll();
                cgvOwners.Rows[0].Selected = true;
                DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
                Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
                List<Mascota> mascotasCliente = new List<Mascota>();
                mascotasCliente = CN_Mascota.getMacotas(clienteSeleccionado.IdCliente);
                dgvMascotas.DataSource = mascotasCliente;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvOwners.DataSource = CN_Mascota.FindByFilter(txtBuscar.Text);
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
            mascotasCliente = CN_Mascota.getMacotas(clienteSeleccionado.IdCliente);
            dgvMascotas.DataSource = mascotasCliente;
        }

        private void cgvOwners_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvOwners.SelectedRows[0];
            Cliente clienteSeleccionado = (Cliente)filaSeleccionada.DataBoundItem;
            List<Mascota> mascotasCliente = new List<Mascota>();
            mascotasCliente = CN_Mascota.getMacotas(clienteSeleccionado.IdCliente);
            dgvMascotas.DataSource = mascotasCliente;
        }

        private void txtMascota_TextChanged(object sender, EventArgs e)
        {
            //dgvMascotas.DataSource = CN_Mascota.FindByFilter(txtMascota.Text);
        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cgvOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mascotaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

