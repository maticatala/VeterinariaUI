namespace VentanaPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnMascotas = new FontAwesome.Sharp.IconButton();
            this.btnDueños = new FontAwesome.Sharp.IconButton();
            this.btnHistoriaClinica = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnMascotas);
            this.panelMenu.Controls.Add(this.btnDueños);
            this.panelMenu.Controls.Add(this.btnHistoriaClinica);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 670);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lblNombre);
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.BackColor = System.Drawing.Color.Transparent;
            this.btnMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMascotas.FlatAppearance.BorderSize = 0;
            this.btnMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnMascotas.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.btnMascotas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMascotas.IconSize = 32;
            this.btnMascotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMascotas.Location = new System.Drawing.Point(0, 200);
            this.btnMascotas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMascotas.Size = new System.Drawing.Size(220, 60);
            this.btnMascotas.TabIndex = 3;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMascotas.UseVisualStyleBackColor = false;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnDueños
            // 
            this.btnDueños.BackColor = System.Drawing.Color.Transparent;
            this.btnDueños.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDueños.FlatAppearance.BorderSize = 0;
            this.btnDueños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDueños.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnDueños.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnDueños.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnDueños.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDueños.IconSize = 32;
            this.btnDueños.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDueños.Location = new System.Drawing.Point(0, 260);
            this.btnDueños.Margin = new System.Windows.Forms.Padding(0);
            this.btnDueños.Name = "btnDueños";
            this.btnDueños.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDueños.Size = new System.Drawing.Size(220, 60);
            this.btnDueños.TabIndex = 4;
            this.btnDueños.Text = "Dueños";
            this.btnDueños.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDueños.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDueños.UseVisualStyleBackColor = false;
            this.btnDueños.Click += new System.EventHandler(this.btnDueños_Click);
            // 
            // btnHistoriaClinica
            // 
            this.btnHistoriaClinica.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoriaClinica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoriaClinica.FlatAppearance.BorderSize = 0;
            this.btnHistoriaClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriaClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnHistoriaClinica.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnHistoriaClinica.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnHistoriaClinica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistoriaClinica.IconSize = 32;
            this.btnHistoriaClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriaClinica.Location = new System.Drawing.Point(0, 320);
            this.btnHistoriaClinica.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistoriaClinica.Name = "btnHistoriaClinica";
            this.btnHistoriaClinica.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistoriaClinica.Size = new System.Drawing.Size(220, 60);
            this.btnHistoriaClinica.TabIndex = 5;
            this.btnHistoriaClinica.Text = "Historia clinica";
            this.btnHistoriaClinica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriaClinica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistoriaClinica.UseVisualStyleBackColor = false;
            this.btnHistoriaClinica.Click += new System.EventHandler(this.btnHistoriaClinica_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.Transparent;
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.btnServicios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.IconSize = 32;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 380);
            this.btnServicios.Margin = new System.Windows.Forms.Padding(0);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnServicios.Size = new System.Drawing.Size(220, 60);
            this.btnServicios.TabIndex = 6;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(12, 27);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(74, 74);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(92, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 31);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "PawPalace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursal Default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 670);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Responsive SideBar";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnMascotas;
        private FontAwesome.Sharp.IconButton btnDueños;
        private FontAwesome.Sharp.IconButton btnHistoriaClinica;
        private FontAwesome.Sharp.IconButton btnServicios;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
    }
}

