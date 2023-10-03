using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidadaes.Entities;

using CapaNegocio.Models;

namespace VentanaPrincipal.Forms.RazasEspecies
{
    public partial class razasEspeciesForm : Form
    {
        private CN_Especie cN_Especie = new CN_Especie();
        private CN_Raza cN_Raza = new CN_Raza();
        private Especie especieSeleccionada;
        public razasEspeciesForm()
        {
            InitializeComponent();
        }

        private void razasEspeciesForm_Load(object sender, EventArgs e)
        {
            dgvEspecies.DataSource = cN_Especie.getAll();
        }

        private void txtBuscarEspecie_TextChanged(object sender, EventArgs e)
        {
            dgvEspecies.DataSource = cN_Especie.findByNombre(txtBuscarEspecie.Text);
        }

        private void dgvEspecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvEspecies.SelectedRows[0];
            this.especieSeleccionada = filaSeleccionada.DataBoundItem as Especie;
            dgvRazas.DataSource = cN_Especie.findRazas(especieSeleccionada.CodEspecie);
        }

        private void txtBuscarRaza_TextChanged(object sender, EventArgs e)
        {
            dgvRazas.DataSource = cN_Raza.findByNombreAndEspecie(txtBuscarRaza.Text, especieSeleccionada.CodEspecie);
        }

        private void btnAddEspecie_Click(object sender, EventArgs e)
        {
            formAdd formAddEspecie = new formAdd();
            formAddEspecie.ShowDialog();
            dgvEspecies.DataSource = cN_Especie.getAll();
        }

        private void btnAddRaza_Click(object sender, EventArgs e)
        {
            formAdd formAddRaza = new formAdd(especieSeleccionada.CodEspecie);
            formAddRaza.ShowDialog();
            dgvRazas.DataSource = cN_Especie.findRazas(especieSeleccionada.CodEspecie);
        }
    }
}
