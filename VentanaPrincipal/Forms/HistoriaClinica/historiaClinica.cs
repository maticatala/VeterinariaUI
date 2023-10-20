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
            // TODO: This line of code loads data into the 'veterinariaDataSet6.atenciones' table. You can move, or remove it, as needed.
            this.atencionesTableAdapter1.Fill(this.veterinariaDataSet6.atenciones);
            // TODO: This line of code loads data into the 'veterinariaDataSet4.atenciones' table. You can move, or remove it, as needed.
            //this.atencionesTableAdapter.Fill(this.veterinariaDataSet4.atenciones);

        }
        private void cargarTabla()
        {
            try
            {
                cgvAtencion.DataSource = CN_Atencion.getAll();
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
            //cargarTabla();
        }

        private void cgvAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string nameColumn = cgvAtencion.Columns[e.ColumnIndex].Name;
                if(nameColumn =="pdf") 
                {
                    report reporte = new report();
                    reporte.ShowDialog();
                }
            }
        }

        private void cgvAtencion_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = cgvAtencion.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    cgvAtencion.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    cgvAtencion.Cursor = Cursors.Default;
                }
            }
        }
    }
}
