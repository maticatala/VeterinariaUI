using CapaEntidadaes.Entities;
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
            this.atencionesTableAdapter1.Fill(this.veterinariaDataSet6.atenciones);
        }

        private void cgvAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nameColumn = cgvAtencion.Columns[e.ColumnIndex].Name;
                if(nameColumn == "edit")
                {
                    Atencion at = new Atencion()
                    {
                        NroHC = Convert.ToInt32(cgvAtencion.CurrentRow.Cells[0].Value.ToString()),
                        Matricula = Convert.ToInt32(cgvAtencion.CurrentRow.Cells[0].Value.ToString()),

                        FechaYHora = Convert.ToDateTime(cgvAtencion.CurrentRow. Cells[0].Value),

                        Resultado = cgvAtencion.CurrentRow.Cells[0].Value.ToString(),

                        Precio = Convert.ToDouble(cgvAtencion.CurrentRow.Cells[0].Value.ToString()),

                    };
                    addHC agregarHC = new addHC(at);
                    agregarHC.ShowDialog();
                }
                else if (nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente el Veterinario?", "Cuidado", MessageBoxButtons.OKCancel);
                    if (opt == DialogResult.OK)
                    {
                        int nroHC = Convert.ToInt32(cgvAtencion.CurrentRow.Cells[0].Value.ToString());
                        string result = CN_Atencion.delete(nroHC);
                    }
                }
                this.atencionesTableAdapter1.Fill(this.veterinariaDataSet6.atenciones);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            report reporte = new report();
            reporte.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvAtencion.DataSource = CN_Atencion.FindByFilter(txtBuscar.Text);
        }
    }
}
