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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            DatosGenerales dg = new DatosGenerales(cliente);
            AddOwnedForm(dg);
            loadform(dg);
        }

        public void cargarCliente(string nroDoc)
        {
            CN_Cliente clienteNegocio = new CN_Cliente();
            this.cliente = clienteNegocio.findByDoc(nroDoc);
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
            DatosGenerales dg;
            if (cliente == null)
                dg = new DatosGenerales();
            else
                dg = new DatosGenerales(cliente);
            AddOwnedForm(dg);
            loadform(dg);
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

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
