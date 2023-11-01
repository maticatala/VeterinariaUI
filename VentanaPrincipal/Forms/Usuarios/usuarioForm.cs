using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.Usuarios
{
    public partial class usuarioForm : Form

    {
        private CN_Usuario Cn_Usuario = new CN_Usuario();
        public usuarioForm()
        {
            InitializeComponent();
            
        }

        private void usuarioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet3.usuarios' table. You can move, or remove it, as needed.
           // this.usuariosTableAdapter.Fill(this.veterinariaDataSet3.usuarios);

            cargarTablas();
        }
        private void cgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = cgvUsuarios.SelectedRows[0];
            Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;
            frmRegistro addUsuario = new frmRegistro(usuarioSeleccionado);
            addUsuario.ShowDialog();
            cargarTablas();
        }

        private void cargarTablas()
        {
            try
            {
                cgvUsuarios.DataSource = Cn_Usuario.getAll();
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
            frmRegistro addUsuario = new frmRegistro();
            addUsuario.ShowDialog();
            cargarTablas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cgvUsuarios.DataSource = Cn_Usuario.FindByFilter(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nameColumn = cgvUsuarios.Columns[e.ColumnIndex].Name;
                if (nameColumn == "edit")
                {
                    Usuario usua = new Usuario()
                    {
                        Id = Convert.ToInt32(cgvUsuarios.CurrentRow.Cells[0].Value),
                        N_usuario = cgvUsuarios.CurrentRow.Cells[1].Value.ToString(),
                        Password = cgvUsuarios.CurrentRow.Cells[2].Value.ToString(),
                        Tipo_usuario = cgvUsuarios.CurrentRow.Cells[2].Value.ToString(),

                    };
                    frmRegistro usuarioNuevo = new frmRegistro(usua);
                    usuarioNuevo.ShowDialog();

                }
                else if (nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente el Usuario?", "Cuidado", MessageBoxButtons.OKCancel);
                    if (opt == DialogResult.OK)
                    {
                        string codPractica = cgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                        string result = Cn_Usuario.delete(Convert.ToInt32(codPractica));
                    }
                }
                cargarTablas();
            }
        }

        private void cgvUsuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = cgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    cgvUsuarios.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    cgvUsuarios.Cursor = Cursors.Default;
                }
            }
        }
    }
}
