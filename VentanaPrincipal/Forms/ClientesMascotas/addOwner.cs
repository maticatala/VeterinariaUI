using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Markup;
using CapaEntidadaes.Entities;

//Referencias
using CapaEntidades.Entities;
using CapaNegocio.Models;
using FontAwesome.Sharp;
using VentanaPrincipal.Forms.Clientes;
using VentanaPrincipal.Forms.ClientesMascotas;

namespace VentanaPrincipal
{
    public partial class formAdd : Form
    {
        private Button currentBtn;
        public Cliente cliente;

        public formAdd()
        {
            InitializeComponent();
            btnMascotas.Enabled = false;

            currentBtn = btnCliente;
            DatosGenerales dg = new DatosGenerales();
            AddOwnedForm(dg);
            loadform(dg);
        }

        public formAdd(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        public void cargarCliente(Cliente cliente)
        {
            this.cliente = cliente;
            btnMascotas.Enabled = true;
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(220, 225, 235);
                currentBtn.ForeColor = Color.FromArgb(40, 42, 54);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(170, 180, 193);
                currentBtn.ForeColor = Color.FromArgb(54, 57, 73);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (cliente == null)
            {
                DatosGenerales dg = new DatosGenerales();
                AddOwnedForm(dg);
                loadform(dg);
            } else
            {
                loadform(new DatosGenerales(cliente));
            }
            
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            loadform(new DatosMascotasForm(cliente));
        }

        public void loadform(Form form)
        {
            if (this.panelDisplay.Controls.Count > 0)
            {
                this.panelDisplay.Controls.RemoveAt(0);
            }
            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
