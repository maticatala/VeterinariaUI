using CapaEntidades.Entities;

namespace VentanaPrincipal
{
    partial class addOwner
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
            this.components = new System.ComponentModel.Container();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAltura = new VentanaPrincipal.UserControls.customTextBox();
            this.txtCalle = new VentanaPrincipal.UserControls.customTextBox();
            this.txtNumeroDocumento = new VentanaPrincipal.UserControls.customTextBox();
            this.txtApellido = new VentanaPrincipal.UserControls.customTextBox();
            this.txtNombre = new VentanaPrincipal.UserControls.customTextBox();
            this.btnAdd = new VentanaPrincipal.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(24, 102);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(172, 21);
            this.lblNumeroDocumento.TabIndex = 0;
            this.lblNumeroDocumento.Text = "Numero de documento";
            this.lblNumeroDocumento.Click += new System.EventHandler(this.lblNumeroDocumento_Click);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoDocumento.Location = new System.Drawing.Point(24, 187);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(144, 21);
            this.lblTipoDocumento.TabIndex = 1;
            this.lblTipoDocumento.Text = "Tipo de documento";
            this.lblTipoDocumento.Click += new System.EventHandler(this.lblTipoDocumento_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(24, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(171, 20);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 21);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCalle.Location = new System.Drawing.Point(24, 232);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 21);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAltura.Location = new System.Drawing.Point(171, 232);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(52, 21);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(175, 183);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(125, 28);
            this.cbTipoDocumento.TabIndex = 4;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CapaEntidades.Entities.Cliente);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtAltura.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtAltura.BorderSize = 2;
            this.txtAltura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtAltura.Location = new System.Drawing.Point(167, 254);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Padding = new System.Windows.Forms.Padding(7);
            this.txtAltura.PasswordChar = false;
            this.txtAltura.Size = new System.Drawing.Size(134, 35);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.UnderlinedStyle = true;
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.SystemColors.Window;
            this.txtCalle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtCalle.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtCalle.BorderSize = 2;
            this.txtCalle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtCalle.Location = new System.Drawing.Point(21, 254);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Padding = new System.Windows.Forms.Padding(7);
            this.txtCalle.PasswordChar = false;
            this.txtCalle.Size = new System.Drawing.Size(137, 35);
            this.txtCalle.TabIndex = 5;
            this.txtCalle.UnderlinedStyle = true;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroDocumento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtNumeroDocumento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtNumeroDocumento.BorderSize = 2;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(21, 125);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroDocumento.Multiline = false;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumeroDocumento.PasswordChar = false;
            this.txtNumeroDocumento.Size = new System.Drawing.Size(286, 35);
            this.txtNumeroDocumento.TabIndex = 3;
            this.txtNumeroDocumento.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtApellido.Location = new System.Drawing.Point(167, 42);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(137, 35);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtNombre.Location = new System.Drawing.Point(21, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(137, 35);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UnderlinedStyle = true;
            this.txtNombre.Load += new System.EventHandler(this.txtNombre_Load);
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
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(290, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addOwner
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 378);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private RJButton btnAdd;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private UserControls.customTextBox txtNombre;
        private UserControls.customTextBox txtApellido;
        private UserControls.customTextBox txtNumeroDocumento;
        private UserControls.customTextBox txtCalle;
        private UserControls.customTextBox txtAltura;
    }
}