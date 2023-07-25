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
    public partial class addOwner : Form
    {
        //SINGLETON
        private static addOwner instancia = null;
        public static addOwner singletonAddOwner()
        {
            if (instancia == null)
            {
                instancia = new addOwner();
            }
            return instancia;
        }
        public addOwner()
        {
            InitializeComponent();
        }
    }
}
