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
        private CN_Usuario CN_Usuario = new CN_Usuario();
        public usuarioForm()
        {
            InitializeComponent();
            
        }

        private void usuarioForm_Load(object sender, EventArgs e)
        {
            
            this.usuariosTableAdapter.Fill(this.veterinariaDataSet.usuarios);
            cargarTablas();
            if (cgvUsuarios.Rows.Count > 0)
            {
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
                cgvUsuarios.DataSource = CN_Usuario.getAll();
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
                cgvUsuarios.DataSource = CN_Usuario.FindByFilter(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
