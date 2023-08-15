using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencias
using CapaNegocio.Models;
using CapaEntidades.Entities;

namespace VentanaPrincipal.Forms.Veterinarios
{
    public partial class veterinariosForm : Form
    {
        private CN_Veterinario cN_Veterinario = new CN_Veterinario();
        public veterinariosForm()
        {
            InitializeComponent();
        }

   

        private void veterinariosForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
            
        }

        private void cargarTabla()
        {
            try
            {
                cgvVeterinarios.DataSource = cN_Veterinario.getAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cgvVeterinarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el evento se haya producido en una celda del cuerpo del DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la celda sobre la que el mouse ha entrado
                DataGridViewCell cell = cgvVeterinarios.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Verificar si la celda contiene una imagen (icono, etc.)
                if (cell is DataGridViewImageCell && cell.Value != null)
                {
                    cgvVeterinarios.Cursor = Cursors.Hand;
                }
                else
                {
                    // Cambiar el cursor a su valor predeterminado en caso contrario
                    cgvVeterinarios.Cursor = Cursors.Default;
                }
            }
        }

        private void btnAddVeterinario_Click(object sender, EventArgs e)
        {
            addVeterinario formAddVeterinario = new addVeterinario();
            formAddVeterinario.ShowDialog();
            cargarTabla();
        }

        private void cgvVeterinarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string nameColumn = cgvVeterinarios.Columns[e.ColumnIndex].Name;
                if(nameColumn == "editar")
                {
                    Veterinario vet = new Veterinario()
                    {
                        Matricula = cgvVeterinarios.CurrentRow.Cells[0].Value.ToString(),
                        Nombre = cgvVeterinarios.CurrentRow.Cells[1].Value.ToString(),
                        Apellido = cgvVeterinarios.CurrentRow.Cells[2].Value.ToString(),
                        Calle = cgvVeterinarios.CurrentRow.Cells[3].Value.ToString(),
                        Altura = cgvVeterinarios.CurrentRow.Cells[4].Value.ToString(),
                        Telefono = cgvVeterinarios.CurrentRow.Cells[5].Value.ToString(),

                    };
                    addVeterinario formAddOwner = new addVeterinario(vet);
                    formAddOwner.ShowDialog();
                    
                }
                else if(nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente el Veterinario?", "Cuidado", MessageBoxButtons.OKCancel);
                    if(opt == DialogResult.OK)
                    {
                        string matricula = cgvVeterinarios.CurrentRow.Cells[0].Value.ToString();
                        string result = cN_Veterinario.delete(matricula);
                    }
                }
                cargarTabla();
            }
        }
    }
}
