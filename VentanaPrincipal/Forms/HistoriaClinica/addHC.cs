using CapaEntidadaes.Entities;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using CapaNegocio.ValueObjects;
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
    public partial class addHC : Form
    {
        //CN_Mascota mascotaNegocio = new CN_Mascota();
        CN_Atencion atencionNegocio = new CN_Atencion();
        Atencion atencion = new Atencion();
        Cliente cliente = new Cliente();
        Veterinario veterinario = new Veterinario();
        Mascota mascota = new Mascota();
        List<Atencion> listAtenciones;
        List<Mascota> listaMascotas;
        public addHC()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }


        
        private void cargarDueños()
        {

            cbxDueño.DataSource = null;
            cbxDueño.Items.Clear();


            cbxDueño.ValueMember = "idCliente";
            cbxDueño.DisplayMember = "nombre";

            CN_Cliente cN_Cliente = new CN_Cliente();
            cbxDueño.DataSource = cN_Cliente.getAll();
            cbxDueño.SelectedIndex = -1;

        }

        private void cargarVeterinarios()
        {
            cbxVeterinario.DataSource = null;
            cbxVeterinario.Items.Clear();

            cbxVeterinario.ValueMember = "matricula";
            cbxVeterinario.DisplayMember = "nombre";

            CN_Veterinario cN_Veterinario = new CN_Veterinario();
            cbxVeterinario.DataSource = cN_Veterinario.getAll();
            cbxVeterinario.SelectedIndex = -1;
        }


        private void addHC_Load(object sender, EventArgs e)
        {
            cargarDueños();
            cargarVeterinarios();
            cargarPracticas();
        }
        private void cargarMascotas()
        {

            CN_Mascota cN_Mascota = new CN_Mascota();
            List<Mascota> mascotas = cN_Mascota.getAll();

            foreach (Mascota mascota in mascotas)
            {
                cbxMascota.Items.Add(mascota.Nombre);
            }
        }
       

        private void cargarPracticas()
        {

            cbxPracticas.DataSource = null;
            cbxPracticas.Items.Clear();

            cbxPracticas.ValueMember = "codPractica";
            cbxPracticas.DisplayMember = "descripcion";

            CN_Practica cN_Practica = new CN_Practica();
            cbxPracticas.DataSource = cN_Practica.getAll();
            cbxPracticas.SelectedIndex = -1;
        }
        private void findMascotas()
        {

            cbxMascota.DataSource = null;
            cbxMascota.Items.Clear();

            int idCliente = Convert.ToInt32(cbxDueño.SelectedValue.ToString());

            cbxMascota.ValueMember = "nroHC";
            cbxMascota.DisplayMember = "nombre";

            CN_Cliente cN_Cliente = new CN_Cliente();
            cbxMascota.DataSource = cN_Cliente.getMacotas(idCliente);

        }

        private void cbxDueño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            findMascotas();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "MM-dd-yyyy";
            atencion.NroHC = Convert.ToInt32(cbxMascota.SelectedValue.ToString());
            atencion.Matricula = Convert.ToInt32(cbxVeterinario.SelectedValue.ToString());
            atencion.FechaYHora = dtpFecha.Value.Date;
            atencion.Resultado = txtResultado.Text;
            atencionNegocio.Atencion = atencion;

            bool valid = new Helps.DataValidation(atencion).Validate();
            if (valid)
            {
                string result = atencionNegocio.SaveChanges();
                MessageBox.Show(result);
            }
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
