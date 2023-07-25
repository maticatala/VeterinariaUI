using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class mascotasForm : Form
    {
        private static mascotasForm instancia = null;

        public static mascotasForm singletonMascotas()
        {
            if (instancia == null)
            {
                instancia = new mascotasForm();
            }
            return instancia;
        }
        public mascotasForm()
        {
            InitializeComponent();
        }
    }
}
