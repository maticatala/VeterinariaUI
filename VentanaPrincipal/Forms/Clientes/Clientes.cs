using System;
using System.Windows.Forms;
using CapaEntidades.Entities;
using CapaEntidades.ValueObjects;

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
            addOwner formAddOwner = new addOwner(EntityState.Added);
            formAddOwner.ShowDialog();
            cargarTabla();
        }

        private void cgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string nameColumn = cgvOwners.Columns[e.ColumnIndex].Name;
                if (nameColumn == "edit")
                {
                    addOwner formAddOwner = new addOwner(EntityState.Modified);
                    formAddOwner.editar(cgvOwners.CurrentRow, "Editar");
                    formAddOwner.ShowDialog();
                    cargarTabla();
                    txtBuscar.Text = string.Empty;
                }
                else if (nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente el cliente?", "Cuidado",MessageBoxButtons.OKCancel);
                    if (opt == DialogResult.OK)
                    {
                        Cliente c = new Cliente();
                        c.NumeroDocumento = cgvOwners.CurrentRow.Cells[0].Value.ToString();
                        c.TipoDocumento = cgvOwners.CurrentRow.Cells[1].Value.ToString();
                        c.State = EntityState.Deleted;
                        string result = cN_Cliente.SaveChanges(c);
                        MessageBox.Show(result);
                        cargarTabla();
                    }
                }
            }
        }

        private void cgvOwners_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el evento se haya producido en una celda del cuerpo del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = cgvOwners.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    cgvOwners.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    cgvOwners.Cursor = Cursors.Default;
                }
            }
        }

    }
}
