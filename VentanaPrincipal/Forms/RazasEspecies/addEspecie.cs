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

        public formAdd(Especie oldEspecie)
        {
            InitializeComponent();
            especie.CodEspecie = oldEspecie.CodEspecie;
            especie.NombreEspecie = oldEspecie.NombreEspecie;
            txtNombreEspecie.Text = especie.NombreEspecie;
            raza.CodEspecie = -1;
        }

        public formAdd(Raza oldRaza)
        {
            InitializeComponent();
            raza.CodRaza = oldRaza.CodRaza;
            raza.NombreRaza = oldRaza.NombreRaza;
            raza.CodEspecie = oldRaza.CodEspecie;
            txtNombreEspecie.Text = raza.NombreRaza;
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
                if (especie.CodEspecie == 0)
                {
                    result = cN_Especie.Add(especie);
                }
                else
                {
                    result = cN_Especie.Update(especie);
                }
            }
            else
            {
                raza.NombreRaza = txtNombreEspecie.Text;
                if (raza.CodRaza == 0)
                {
                    result = cN_Raza.Add(raza);
                }
                else
                {
                    result = cN_Raza.Update(raza);
                }
                
            }
            
            MessageBox.Show(result);
            this.Close();
        }
    }
}
