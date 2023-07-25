using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class dueñosForm : Form
    {
        //SINGLETON
        //private static dueñosForm instancia = null;
        //public static dueñosForm singletonOwner()
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new dueñosForm();
        //    }
        //    return instancia;
        //}
        public dueñosForm()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { 
            string dato = txtBuscar.Text;
            cargarTabla(dato);  
        }

        private void cargarTabla(string dato)
        {
            CN_Cliente cN_Cliente = new CN_Cliente();
            cgvOwners.DataSource = cN_Cliente.obtenerClientes(dato);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            addOwner.singletonAddOwner().Show();
        }
    }
}
