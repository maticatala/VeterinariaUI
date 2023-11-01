using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades.Entities;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Models;
using CapaEntidadaes.Entities;
using VentanaPrincipal.Forms.Veterinarios;

namespace VentanaPrincipal.Forms.Practicas
{
    public partial class practicasForm : Form
    {
        private CN_Practica cN_Practica = new CN_Practica();
        private Practica practicaSeleccionada;
        public practicasForm()
        {
            InitializeComponent();
        }

       

        private void practicasForm_Load(object sender, EventArgs e)
        {

            cargarTablaPracticas();
           

            
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cgvPracticas.DataSource = cN_Practica.findByFilter(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
        private void cargarTablaPracticas()
        {
            try
            {
                cgvPracticas.DataSource = cN_Practica.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void cgvPracticas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nameColumn = cgvPracticas.Columns[e.ColumnIndex].Name;
                if (nameColumn == "edit")
                {
                    Practica pra = new Practica()
                    {
                        CodPractica = Convert.ToInt32(cgvPracticas.CurrentRow.Cells[0].Value),
                        Descripcion = cgvPracticas.CurrentRow.Cells[1].Value.ToString(),
                    Precio = Convert.ToDouble(cgvPracticas.CurrentRow.Cells[2].Value),

                    };
                    practicaAdd practicaAdd = new practicaAdd(pra);
                    practicaAdd.ShowDialog();

                }
                else if (nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente la practica?", "Cuidado", MessageBoxButtons.OKCancel);
                    if (opt == DialogResult.OK)
                    {
                        string codPractica = cgvPracticas.CurrentRow.Cells[0].Value.ToString();
                        string result = cN_Practica.Delete(Convert.ToInt32(codPractica));
                    }
                }
                cargarTablaPracticas();
            }

        }

        private void practicasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            practicaAdd practicaAdd = new practicaAdd();
            practicaAdd.ShowDialog();
            cargarTablaPracticas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvPracticas.DataSource = cN_Practica.FindByFilter(txtBuscar.Text);
        }

        private void cgvPracticas_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cgvPracticas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = cgvPracticas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    cgvPracticas.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    cgvPracticas.Cursor = Cursors.Default;
                }
            }
        }
    }
}
