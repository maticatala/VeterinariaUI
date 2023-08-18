using CapaNegocio.ValueObjects;
using CapaEntidades.Entities;
using CapaNegocio.Models;
using MySqlX.XDevAPI.Common;
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
        List<Mascota> listaMascotas;

        public DatosMascotasForm(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            cargarEspecies();
            verificarMascotas();
            //Recuperar mascotas del cliente
            //Si no tiene mascotas deshabilitar campos y no hacer nada hasta que se haga click en agregar mascota
            //Si tiene mascotas Habilitar campos con sus datos y poner el estado en modificado
        }

        private void verificarMascotas()
        {
            CN_Cliente cN_cliente = new CN_Cliente();
            listaMascotas = cN_cliente.getMacotas(cliente.IdCliente);

            if (listaMascotas.Count != 0)
            {
                cargarMascotas();
                mascotaNegocio.State = EntityState.Modified;
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
            btnDelete.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            dtpFecha.Enabled = false;
            cbxSexo.Enabled = false;
            cbxRaza.Enabled = false;
            cbxEspecie.Enabled = false;
            cbxMascota.Enabled = false;
        }

        private void cargarMascotas()
        {
            //Llena el cbx de mascotas
            cbxMascota.Enabled = false;
            cbxMascota.DataSource = null;
            cbxMascota.Items.Clear();
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

            cbxEspecie.SelectedItem = null;
        }

        private void cbxEspecie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxRaza.DataSource = null;
            cbxRaza.Items.Clear();

            int codEspecie = Convert.ToInt32(cbxEspecie.SelectedValue.ToString());
            cbxRaza.ValueMember = "codRaza";
            cbxRaza.DisplayMember = "nombreRaza";

            CN_Raza cN_Raza = new CN_Raza();
            cbxRaza.DataSource = cN_Raza.findByEspecie(codEspecie);

            cbxRaza.SelectedItem = null;
            cbxRaza.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mascota mascotaActual = new Mascota();
            dtpFecha.CustomFormat = "MM-dd-yyyy";
            mascotaActual.FechaNac = dtpFecha.Value.Date;
            mascotaActual.Nombre = txtNombre.Text;
            mascotaActual.Sexo = Convert.ToChar(cbxSexo.Text);
            mascotaActual.IdCliente = cliente.IdCliente;
            mascotaActual.CodEspecie = Convert.ToInt32(cbxEspecie.SelectedValue.ToString());
            mascotaActual.CodRaza = Convert.ToInt32(cbxRaza.SelectedValue.ToString());

            mascotaNegocio.Mascota = mascotaActual;
           
            bool valid = new Helps.DataValidation(mascotaActual).Validate();
            if (valid)
            {
                string result = mascotaNegocio.SaveChanges(); ;
                MessageBox.Show(result);
                verificarMascotas();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mascotaNegocio.State = EntityState.Added;
            habilitarCampos();
        }

        private void cbxMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llena los campos del formulario
            Mascota masctotaActual = listaMascotas[cbxMascota.SelectedIndex];
            dtpFecha.Value = masctotaActual.FechaNac;
            txtNombre.Text = masctotaActual.Nombre;
            cbxSexo.Text = Convert.ToString(masctotaActual.Sexo);
            cbxEspecie.SelectedValue = Convert.ToString(masctotaActual.CodEspecie);
            cbxEspecie.SelectedValue = Convert.ToString(masctotaActual.CodRaza);
        }
    }
}
