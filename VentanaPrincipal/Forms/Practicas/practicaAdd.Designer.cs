namespace VentanaPrincipal.Forms.Practicas
{
    partial class practicaAdd
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
            this.txt = new System.Windows.Forms.Label();
            this.txtPractica = new VentanaPrincipal.UserControls.customTextBox();
            this.btnDelete = new VentanaPrincipal.RJButton();
            this.btnAdd = new VentanaPrincipal.RJButton();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txt.Location = new System.Drawing.Point(106, 36);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(224, 32);
            this.txt.TabIndex = 1;
            this.txt.Text = "Ingrese la Practica";
            this.txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPractica
            // 
            this.txtPractica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtPractica.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(141)))), ((int)(((byte)(161)))));
            this.txtPractica.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.txtPractica.BorderSize = 2;
            this.txtPractica.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPractica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.txtPractica.Location = new System.Drawing.Point(91, 87);
            this.txtPractica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPractica.Multiline = false;
            this.txtPractica.Name = "txtPractica";
            this.txtPractica.Padding = new System.Windows.Forms.Padding(7);
            this.txtPractica.PasswordChar = false;
            this.txtPractica.Size = new System.Drawing.Size(266, 35);
            this.txtPractica.TabIndex = 27;
            this.txtPractica.UnderlinedStyle = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnDelete.Location = new System.Drawing.Point(69, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 36);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(130)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(241)))), ((int)(((byte)(182)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnAdd.Location = new System.Drawing.Point(271, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // practicaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(436, 209);
            this.Controls.Add(this.txtPractica);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "practicaAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Practica";
            this.Load += new System.EventHandler(this.practicaAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt;
        private RJButton btnAdd;
        private RJButton btnDelete;
        private UserControls.customTextBox txtPractica;
    }
}