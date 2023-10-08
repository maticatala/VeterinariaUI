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
    public partial class Usuarios : Form
    {
        private CN_Usuario Cn_Usuario = new CN_Usuario();

        public object usuariosTableAdapter { get; private set; }

        public Usuarios()
        {
            InitializeComponent();
        }
        private void usuarioForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
            if (cgvUsuarios.Rows.Count > 0)
            {
                cgvUsuarios.Rows[0].Selected = true;
                DataGridViewRow filaseleccionada = cgvUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaseleccionada.DataBoundItem;
            }
        }

        private void cargarTabla()
        {
            try
            {
                cgvUsuarios.DataSource = Cn_Usuario.getAll();
                cgvUsuarios.Rows[0].Selected = true;
                DataGridViewRow filaseleccionada = cgvUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaseleccionada.DataBoundItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnAddOwner_Click(object sender, EventArgs e)
        {

        }

        private void cgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cgvUsuarios.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = cgvUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;

                frmRegistro agregar = new frmRegistro(usuarioSeleccionado);
                agregar.ShowDialog();
                cgvUsuarios.DataSource = Cn_Usuario.getAll();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet1.usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.veterinariaDataSet1.usuarios);

        }

        private void cgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
