using CapaNegocio.ValueObjects;
using CapaEntidades.Entities;
using CapaNegocio.Models;
//using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Apache.Bzip2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal.Forms.ClientesMascotas
{
    public partial class DatosMascotasForm : Form
    {
        CN_Mascota mascotaNegocio = new CN_Mascota();
        Cliente cliente = new Cliente();
        Mascota mascota = new Mascota();
        List<Mascota> listaMascotas;

        public DatosMascotasForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            cargarEspecies();
            verificarMascotas();
        }

        private void verificarMascotas()
        {
            CN_Cliente cN_cliente = new CN_Cliente();
            listaMascotas = cN_cliente.getMacotas(cliente.IdCliente);

            if (listaMascotas.Count != 0)
            {
                cargarMascotas();
                mascotaNegocio.State = EntityState.Modified;
                btnDelete.Enabled = true;
                cbxMascota.Enabled = true;
            }
            else
                deshabilitarCampos();
        }

        private void habilitarCampos()
        {
            txtNombre.Enabled = true;
            dtpFecha.Enabled = true;
            cbxSexo.Enabled = true;
            cbxRaza.Enabled = false;
            cbxEspecie.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            dtpFecha.Enabled = false;
            cbxSexo.Enabled = false;
            cbxRaza.Enabled = false;
            cbxEspecie.Enabled = false;
            cbxMascota.Enabled = false;
            btnDelete.Enabled = false;

            cbxMascota.DataSource = null;
            cbxMascota.Items.Clear();
            limpiarCampos();
        }

        private void cargarMascotas()
        {
            habilitarCampos();

            cbxMascota.ValueMember = "nroHC";
            cbxMascota.DisplayMember = "nombre";
            cbxMascota.DataSource = listaMascotas;
        }

        private void cargarEspecies()
        {
            cbxRaza.Enabled = false;

            cbxEspecie.DataSource = null;
            cbxEspecie.Items.Clear();

            cbxEspecie.ValueMember = "codEspecie";
            cbxEspecie.DisplayMember = "nombreEspecie";

            CN_Especie cN_Especie = new CN_Especie();
            cbxEspecie.DataSource = cN_Especie.getAll();
        }

        private void findRazas()
        {
            cbxRaza.DataSource = null;
            cbxRaza.Items.Clear();

            int codEspecie = Convert.ToInt32(cbxEspecie.SelectedValue.ToString());
            cbxRaza.ValueMember = "codRaza";
            cbxRaza.DisplayMember = "nombreRaza";

            CN_Raza cN_Raza = new CN_Raza();
            cbxRaza.DataSource = cN_Raza.findByEspecie(codEspecie);
        }

        private void limpiarCampos()
        {
            txtNombre.Text = string.Empty;
            cbxSexo.SelectedItem = null;
            cbxEspecie.SelectedItem = null;
            cbxRaza.SelectedItem = null;
        }

        //EVENTOS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "MM-dd-yyyy";
            mascota.FechaNac = dtpFecha.Value.Date;
            mascota.Nombre = txtNombre.Text;
            mascota.Sexo = Convert.ToChar(cbxSexo.Text);
            mascota.IdCliente = cliente.IdCliente;
            mascota.CodEspecie = Convert.ToInt32(cbxEspecie.SelectedValue.ToString());
            mascota.CodRaza = Convert.ToInt32(cbxRaza.SelectedValue.ToString());

            mascotaNegocio.Mascota = mascota;

            bool valid = new Helps.DataValidation(mascota).Validate();
            if (valid)
            {
                string result = mascotaNegocio.SaveChanges();
                MessageBox.Show(result);
                verificarMascotas();
            }
        }

        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llena los campos del formulario
            Mascota masctotaActual = listaMascotas[cbxMascota.SelectedIndex];
            dtpFecha.Value = masctotaActual.FechaNac;
            txtNombre.Text = masctotaActual.Nombre;
            cbxSexo.Text = Convert.ToString(masctotaActual.Sexo);
            cbxEspecie.SelectedItem = Convert.ToString(masctotaActual.CodEspecie);
            findRazas();
            cbxRaza.Enabled = true;
            cbxRaza.SelectedItem = Convert.ToString(masctotaActual.CodRaza);

            mascota = masctotaActual;
        }

        private void cbxEspecie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            findRazas();
            cbxRaza.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mascotaNegocio.State = EntityState.Added;
            limpiarCampos();
            habilitarCampos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mascotaNegocio.State = EntityState.Deleted;
            mascotaNegocio.Mascota = mascota;
            string result = mascotaNegocio.SaveChanges();
            MessageBox.Show(result);
            verificarMascotas();
        }

        private void cbxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
