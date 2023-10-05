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
using CapaEntidades.Entities;
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
            
            string nameColumn = dgvEspecies.Columns[e.ColumnIndex].Name;
            if (nameColumn == "borrarEspecie")
            {
                
                DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente la especie?", "Cuidado",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(opt == DialogResult.OK)
                {
                    string result = cN_Especie.Delete(especieSeleccionada.CodEspecie);
                    MessageBox.Show(result);
                    dgvEspecies.DataSource = cN_Especie.getAll();
                }
            }
            else
            {
                dgvRazas.DataSource = cN_Especie.findRazas(especieSeleccionada.CodEspecie);
            }
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

        private void dgvEspecies_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el evento se haya producido en una celda del cuerpo del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = dgvEspecies.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    dgvEspecies.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    dgvEspecies.Cursor = Cursors.Default;
                }
            }
        }

        private void dgvRazas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el evento se haya producido en una celda del cuerpo del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = dgvRazas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    dgvRazas.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    dgvRazas.Cursor = Cursors.Default;
                }
            }
        }

        private void dgvRazas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvRazas.SelectedRows[0];
            Raza razaSeleccionada = filaSeleccionada.DataBoundItem as Raza;

            string nameColumn = dgvRazas.Columns[e.ColumnIndex].Name;
            if (nameColumn == "borrarRaza")
            {

                DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente la raza?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opt == DialogResult.OK)
                {
                    string result = cN_Raza.Delete(razaSeleccionada.CodRaza);
                    MessageBox.Show(result);
                    dgvRazas.DataSource = cN_Especie.findRazas(especieSeleccionada.CodEspecie);
                }
            }
        }

        private void dgvEspecies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow filaSeleccionada = dgvRazas.SelectedRows[0];
            //especieSeleccionada = filaSeleccionada.DataBoundItem as Especie;

            formAdd formModifyEspecie = new formAdd(especieSeleccionada);
            formModifyEspecie.ShowDialog();
            dgvEspecies.DataSource = cN_Especie.getAll();
        }

        private void dgvRazas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvRazas.SelectedRows[0];
            Raza razaSeleccionada = filaSeleccionada.DataBoundItem as Raza;

            formAdd formModifyRaza = new formAdd(razaSeleccionada);
            formModifyRaza.ShowDialog();
            dgvRazas.DataSource = cN_Especie.findRazas(especieSeleccionada.CodEspecie);
        }
    }
}
