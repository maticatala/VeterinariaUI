namespace VentanaPrincipal.Forms.Veterinarios
{
    partial class addVeterinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new VentanaPrincipal.RJButton();
            this.txtNombre = new VentanaPrincipal.UserControls.customTextBox();
            this.txtApellido = new VentanaPrincipal.UserControls.customTextBox();
            this.txtMatricula = new VentanaPrincipal.UserControls.customTextBox();
            this.txtCalle = new VentanaPrincipal.UserControls.customTextBox();
            this.txtAltura = new VentanaPrincipal.UserControls.customTextBox();
            this.txtTelefono = new VentanaPrincipal.UserControls.customTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(27, 379);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(368, 57);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtNombre.Location = new System.Drawing.Point(27, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(180, 44);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtApellido.Location = new System.Drawing.Point(215, 50);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(9);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(180, 44);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.UnderlinedStyle = true;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatricula.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtMatricula.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtMatricula.BorderSize = 2;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtMatricula.Location = new System.Drawing.Point(27, 135);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMatricula.Multiline = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Padding = new System.Windows.Forms.Padding(9);
            this.txtMatricula.PasswordChar = false;
            this.txtMatricula.Size = new System.Drawing.Size(368, 44);
            this.txtMatricula.TabIndex = 2;
            this.txtMatricula.UnderlinedStyle = true;
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtCalle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtCalle.BorderSize = 2;
            this.txtCalle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtCalle.Location = new System.Drawing.Point(27, 221);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Padding = new System.Windows.Forms.Padding(9);
            this.txtCalle.PasswordChar = false;
            this.txtCalle.Size = new System.Drawing.Size(180, 44);
            this.txtCalle.TabIndex = 3;
            this.txtCalle.UnderlinedStyle = true;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtAltura.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtAltura.BorderSize = 2;
            this.txtAltura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtAltura.Location = new System.Drawing.Point(215, 221);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(9);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.Size = new System.Drawing.Size(180, 44);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.UnderlinedStyle = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtTelefono.Location = new System.Drawing.Point(27, 311);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(9);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.Size = new System.Drawing.Size(368, 44);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.UnderlinedStyle = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(22, 17);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 28);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(210, 17);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 28);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMatricula.Location = new System.Drawing.Point(22, 102);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(137, 28);
            this.lblMatricula.TabIndex = 9;
            this.lblMatricula.Text = "Nro. Matricula";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCalle.Location = new System.Drawing.Point(22, 188);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(54, 28);
            this.lblCalle.TabIndex = 10;
            this.lblCalle.Text = "Calle";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAltura.Location = new System.Drawing.Point(210, 188);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(65, 28);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "Altura";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefono.Location = new System.Drawing.Point(22, 278);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 28);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono";
            // 
            // addVeterinario
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 465);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnAdd;
        private UserControls.customTextBox txtNombre;
        private UserControls.customTextBox txtApellido;
        private UserControls.customTextBox txtMatricula;
        private UserControls.customTextBox txtCalle;
        private UserControls.customTextBox txtAltura;
        private UserControls.customTextBox txtTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblTelefono;
    }
}