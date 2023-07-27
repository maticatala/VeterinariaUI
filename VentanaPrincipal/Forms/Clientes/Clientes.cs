using System;
using System.Windows.Forms;

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

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            addOwner formAddOwner = new addOwner();
            if (formAddOwner.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvOwners.DataSource = cN_Cliente.FindByFilter(txtBuscar.Text);
        }
    }
}
