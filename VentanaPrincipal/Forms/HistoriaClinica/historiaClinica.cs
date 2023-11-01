using CapaEntidadaes.Entities;
using CapaNegocio.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.HistoriaClinica
{ 


    public partial class historiaClinica : Form
    {
        List<Atencion> lista = new List<Atencion>();
        private CN_Atencion cN_Atencion = new CN_Atencion();
        private CN_Atencion CN_Atencion = new CN_Atencion();
    public historiaClinica()
        {
            InitializeComponent();
        }

        private void historiaClinica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinariaDataSet6.atenciones' table. You can move, or remove it, as needed.
            cargarTabla();
            //this.atencionesTableAdapter1.Fill(this.veterinariaDataSet6.atenciones);
            // TODO: This line of code loads data into the 'veterinariaDataSet4.atenciones' table. You can move, or remove it, as needed.
            //this.atencionesTableAdapter.Fill(this.veterinariaDataSet4.atenciones);
            Llenar();

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
            cargarTabla();
            //this.atencionesTableAdapter1.Fill(this.veterinariaDataSet6.atenciones);
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
                        Matricula = cgvAtencion.CurrentRow.Cells[0].Value.ToString(),

                       //FechaYHora = Convert.ToDateTime(cgvAtencion.CurrentRow. Cells[0].Value),

                        Resultado = cgvAtencion.CurrentRow.Cells[0].Value.ToString(),

                        Precio = Convert.ToDouble(cgvAtencion.CurrentRow.Cells[0].Value.ToString()),

                    };
                    addHC agregarHC = new addHC(at);
                    agregarHC.ShowDialog();
                }
                else if (nameColumn == "delete")
                {
                    DialogResult opt = MessageBox.Show("¿Desea eliminar permanentemente la historia clinica?", "Cuidado", MessageBoxButtons.OKCancel);
                    if (opt == DialogResult.OK)
                    {
                        int nroHC = Convert.ToInt32(cgvAtencion.CurrentRow.Cells[0].Value.ToString());
                        
                        string result = CN_Atencion.delete(nroHC);
                    }
                }
                cargarTabla();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            cgvAtencion.DataSource = CN_Atencion.FindByFilter(txtBuscar.Text);
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            Llenar();
            //formReport nuevoFormulario = new formReport();

            //nuevoFormulario.ShowDialog();
            FileStream fs = new FileStream(@"D:\Facultad\Facultad 3 Año\IDE\VETERINARIA UI\VentanaPrincipal\Forms\HistoriaClinica\PDFGenerado.pdf", FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);

            document.OpenDocument();

            document.AddAuthor("Reporte");
            document.AddTitle("Pdf Generado");

            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            document.Add(new Paragraph("Reportes"));
            document.Add(Chunk.NEWLINE);


            PdfPTable tblEjemplo = new PdfPTable(4);
            tblEjemplo.WidthPercentage = 100;

            PdfPCell nroHC = new PdfPCell(new Phrase("NroHC", standarFont));
            //nroHC.BorderWidth = 1;
            //nroHC.BorderWidthBottom = 0.75f;

            PdfPCell matricula = new PdfPCell(new Phrase("Matricula", standarFont));
            //nroHC.BorderWidth = 0;
            //nroHC.BorderWidthBottom = 0.75f;

            PdfPCell resultado = new PdfPCell(new Phrase("Resultado", standarFont));
            //nroHC.BorderWidth = 0;
            //nroHC.BorderWidthBottom = 0.75f;

            PdfPCell fecha = new PdfPCell(new Phrase("Fecha Y Hora", standarFont));
            //nroHC.BorderWidth = 0;
            //nroHC.BorderWidthBottom = 0.75f;

            tblEjemplo.AddCell(nroHC);
            tblEjemplo.AddCell(matricula);
            tblEjemplo.AddCell(resultado);
            tblEjemplo.AddCell(fecha);

            foreach (var atencion in lista)
            {
                nroHC = new PdfPCell(new Phrase(atencion.NroHC.ToString(), standarFont));
                //nroHC.BorderWidth = 1;

                matricula = new PdfPCell(new Phrase(atencion.Matricula.ToString(), standarFont));
                //nroHC.BorderWidth = 0;

                resultado = new PdfPCell(new Phrase(atencion.Resultado.ToString(), standarFont));
                //nroHC.BorderWidth = 0;

                fecha = new PdfPCell(new Phrase(atencion.FechaYHora.ToString(), standarFont));
                //fecha.BorderWidth = 0;


                tblEjemplo.AddCell(nroHC);
                tblEjemplo.AddCell(matricula);
                tblEjemplo.AddCell(resultado);
                tblEjemplo.AddCell(fecha);
            }

            document.Add(tblEjemplo);

            document.Close();
            pw.Close();


            if (File.Exists(@"D:\Facultad\Facultad 3 Año\IDE\VETERINARIA UI\VentanaPrincipal\Forms\HistoriaClinica\PDFGenerado.pdf"))
            {
                Process.Start(@"D:\Facultad\Facultad 3 Año\IDE\VETERINARIA UI\VentanaPrincipal\Forms\HistoriaClinica\PDFGenerado.pdf");
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada.");
            }
        }

        private void Llenar()
        {
            lista = cN_Atencion.getAll();
        }
    }
}
