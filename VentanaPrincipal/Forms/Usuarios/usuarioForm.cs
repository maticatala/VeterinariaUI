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
            this.usuariosTableAdapter.Fill(this.veterinariaDataSet3.usuarios);

            cargarTablas();
            if (cgvUsuarios.Rows.Count > 0)
            {
                cgvUsuarios.Rows[0].Selected = true;
                DataGridViewRow filaSeleccionada = cgvUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;
            }
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
            DataGridViewRow filaSeleccionada = cgvUsuarios.SelectedRows[0];
            Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;
        }
    }
}
