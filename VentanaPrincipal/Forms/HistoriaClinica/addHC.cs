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
        CN_Mascota mascotaNegocio = new CN_Mascota();
        Cliente cliente = new Cliente();
        Veterinario veterinario = new Veterinario();
        List<Mascota> listaMascotas;
        public addHC()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }


        
        private void cargarDueños()
        {
            CN_Cliente cN_Cliente = new CN_Cliente();
            List<Cliente> owners = cN_Cliente.getAll(); // Implementa esta función para obtener la lista de dueños

            foreach (Cliente dueño in owners)
            {
                cbxDueño.Items.Add(dueño.Nombre);
            }

        }

        private void cargarVeterinarios()
        {
            CN_Veterinario cN_Veterniario = new CN_Veterinario();
            List<Veterinario> veterinarios = cN_Veterniario.getAll(); // Implementa esta función para obtener la lista de dueños

            foreach (Veterinario veterinario in veterinarios)
            {
                cbxVeterinario.Items.Add(veterinario.Nombre);
            }
        }


        private void addHC_Load(object sender, EventArgs e)
        {
            cargarDueños();
            //verificarMascotas();
            cargarVeterinarios();
            cargarPracticas();
        }
        private void cargarMascotas()
        {
            cbxMascota.ValueMember = "nroHC";
            cbxMascota.DisplayMember = "nombre";
            cbxMascota.DataSource = listaMascotas;
        }

        private void verificarMascotas()
        {
            CN_Cliente cN_cliente = new CN_Cliente();
            listaMascotas = cN_cliente.getMacotas(cliente.IdCliente);

            if (listaMascotas.Count != 0)
            {
                cargarMascotas();
                mascotaNegocio.State = EntityState.Modified;
                cbxMascota.Enabled = true;
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
        }
        private void findMascotas()
        {
            cbxMascota.DataSource = null;
            cbxMascota.Items.Clear();

            int nroHC = Convert.ToInt32(cbxDueño.SelectedValue.ToString());
            cbxMascota.ValueMember = "nroHC";
            cbxMascota.DisplayMember = "nombre";

            CN_Mascota cN_Mascota = new CN_Mascota();
            cbxMascota.DataSource = cN_Mascota.findByDueño(nroHC);
        }

        private void cbxDueño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            findMascotas();
            cbxMascota.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbxDueño_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Cliente cN_cliente = new CN_Cliente();
            listaMascotas = cN_cliente.getMacotas(cliente.IdCliente);

            if (listaMascotas.Count != 0)
            {
                cargarMascotas();
                mascotaNegocio.State = EntityState.Modified;
                cbxMascota.Enabled = true;
            }
        }
    }
}
