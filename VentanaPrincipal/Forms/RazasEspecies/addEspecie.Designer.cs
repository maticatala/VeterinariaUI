namespace VentanaPrincipal.Forms.RazasEspecies
{
    partial class formAdd
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
            this.lblNombreEspecie = new System.Windows.Forms.Label();
            this.txtNombreEspecie = new VentanaPrincipal.UserControls.customTextBox();
            this.btnCancelar = new VentanaPrincipal.RJButton();
            this.btnAceptar = new VentanaPrincipal.RJButton();
            this.SuspendLayout();
            // 
            // lblNombreEspecie
            // 
            this.lblNombreEspecie.AutoSize = true;
            this.lblNombreEspecie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreEspecie.Location = new System.Drawing.Point(112, 32);
            this.lblNombreEspecie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEspecie.Name = "lblNombreEspecie";
            this.lblNombreEspecie.Size = new System.Drawing.Size(122, 17);
            this.lblNombreEspecie.TabIndex = 0;
            this.lblNombreEspecie.Text = "Ingrese el nombre:";
            this.lblNombreEspecie.Click += new System.EventHandler(this.lblNombreEspecie_Click);
            // 
            // txtNombreEspecie
            // 
            this.txtNombreEspecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtNombreEspecie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtNombreEspecie.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtNombreEspecie.BorderSize = 2;
            this.txtNombreEspecie.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombreEspecie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtNombreEspecie.Location = new System.Drawing.Point(65, 71);
            this.txtNombreEspecie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreEspecie.Multiline = false;
            this.txtNombreEspecie.Name = "txtNombreEspecie";
            this.txtNombreEspecie.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombreEspecie.PasswordChar = false;
            this.txtNombreEspecie.Size = new System.Drawing.Size(232, 33);
            this.txtNombreEspecie.TabIndex = 1;
            this.txtNombreEspecie.UnderlinedStyle = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnCancelar.Location = new System.Drawing.Point(28, 136);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(241)))), ((int)(((byte)(182)))));
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.BorderSize = 1;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnAceptar.Location = new System.Drawing.Point(205, 136);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 39);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // formAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(381, 204);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNombreEspecie);
            this.Controls.Add(this.lblNombreEspecie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEspecie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEspecie;
        private UserControls.customTextBox txtNombreEspecie;
        private RJButton btnCancelar;
        private RJButton btnAceptar;
    }
}