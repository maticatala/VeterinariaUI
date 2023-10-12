using CapaNegocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.HistoriaClinica
{ 


    public partial class historiaClinica : Form
    {
        private CN_Atencion CN_Atencion = new CN_Atencion();
    public historiaClinica()
        {
            InitializeComponent();
        }

        private void historiaClinica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet4.atenciones' table. You can move, or remove it, as needed.
            this.atencionesTableAdapter.Fill(this.veterinariaDataSet4.atenciones);

        }
        private void cargarTabla()
        {
            try
            {
                //cgvAtencion.DataSource = CN_Atencion.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            addHC hClinicaNew = new addHC();
            hClinicaNew.ShowDialog();
            cargarTabla();
        }
    }
}
