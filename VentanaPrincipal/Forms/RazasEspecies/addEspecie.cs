using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Models;
using CapaEntidadaes.Entities;

namespace VentanaPrincipal.Forms.RazasEspecies
{
    public partial class formAdd : Form
    {
        Especie especie = new Especie();
        CN_Especie cN_Especie = new CN_Especie();

        Raza raza = new Raza();
        CN_Raza cN_Raza = new CN_Raza();
        public formAdd()
        {
            InitializeComponent();
            raza.CodEspecie = -1;
        }

        public formAdd(int codEspecie)
        {
            InitializeComponent();
            raza.CodEspecie = codEspecie;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string result;
            if(raza.CodEspecie == -1) 
            {
                especie.NombreEspecie = txtNombreEspecie.Text;
                result = cN_Especie.add(especie);
            }
            else
            {
                raza.NombreRaza = txtNombreEspecie.Text;
                result = cN_Raza.add(raza);
            }
            
            MessageBox.Show(result);
            this.Close();
        }
    }
}
