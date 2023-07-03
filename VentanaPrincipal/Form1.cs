using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Transitions;
using Color = System.Drawing.Color;
//using Color = System.Drawing.Color;

namespace VentanaPrincipal
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            Controls.Add(leftBorderBtn);
        }
        //Structs
        private struct RGBColors
        {
            //Light mode
            public static Color color_primary = Color.FromArgb(115, 128, 236);
            public static Color color_danger = Color.FromArgb(255, 119, 130);
            public static Color color_success = Color.FromArgb(65, 241, 182);
            public static Color color_warning = Color.FromArgb(255, 187, 85);
            public static Color color_white = Color.FromArgb(255, 255, 255);
            public static Color color_info_dark = Color.FromArgb(125, 141, 161);
            public static Color color_info_light = Color.FromArgb(220, 225, 235);
            public static Color color_dark = Color.FromArgb(54, 57, 73);
            public static Color color_light = Color.FromArgb(238, 238, 238);
            public static Color color_primary_variant = Color.FromArgb(17, 30, 136);
            public static Color color_dark_variant = Color.FromArgb(103, 116, 131);
            public static Color color_background = Color.FromArgb(246, 246, 249);

            //Dark mode
            public static Color color_background_dark = Color.FromArgb(24, 26, 30);
            public static Color color_white_dark = Color.FromArgb(32, 37, 40);
            public static Color color_dark_dark = Color.FromArgb(237, 239, 253);
            public static Color color_dark_variant_dark = Color.FromArgb(163, 189, 204);
            public static Color color_light_dark = Color.FromArgb(0, 0, 0, 1);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.color_light;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.Padding = new Padding(40, 0, 20, 0);

                //Left border panel
                leftBorderBtn.BackColor = RGBColors.color_primary;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(246, 246, 249);
                currentBtn.ForeColor = RGBColors.color_dark;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.color_dark;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Padding = new Padding(10, 0, 20, 0);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_dark);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_dark);
        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_dark);
        }

        private void btnDueños_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_dark);
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_dark);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
    }
}
