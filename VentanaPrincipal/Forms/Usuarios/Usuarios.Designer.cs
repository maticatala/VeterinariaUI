namespace VentanaPrincipal.Forms.Usuarios
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblDueño = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAddOwner = new VentanaPrincipal.RJButton();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);;
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cgvUsuarios)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cgvUsuarios
            // 
            this.cgvUsuarios.AllowUserToAddRows = false;
            this.cgvUsuarios.AllowUserToDeleteRows = false;
            this.cgvUsuarios.AllowUserToResizeColumns = false;
            this.cgvUsuarios.AllowUserToResizeRows = false;
            this.cgvUsuarios.AutoGenerateColumns = false;
            this.cgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.cgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.cgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cgvUsuarios.ColumnHeadersHeight = 45;
            this.cgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nusuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.tipousuarioDataGridViewTextBoxColumn});
            this.cgvUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.cgvUsuarios.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.cgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgvUsuarios.EnableHeadersVisualStyles = false;
            this.cgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.cgvUsuarios.Location = new System.Drawing.Point(0, 128);
            this.cgvUsuarios.Name = "cgvUsuarios";
            this.cgvUsuarios.ReadOnly = true;
            this.cgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cgvUsuarios.RowHeadersVisible = false;
            this.cgvUsuarios.RowHeadersWidth = 51;
            this.cgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.cgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cgvUsuarios.RowTemplate.Height = 55;
            this.cgvUsuarios.RowTemplate.ReadOnly = true;
            this.cgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cgvUsuarios.Size = new System.Drawing.Size(800, 322);
            this.cgvUsuarios.TabIndex = 2;
            this.cgvUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cgvUsuarios_CellDoubleClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.txtMascota);
            this.panelSearch.Controls.Add(this.lblMascota);
            this.panelSearch.Controls.Add(this.lblDueño);
            this.panelSearch.Controls.Add(this.lblBusqueda);
            this.panelSearch.Controls.Add(this.txtBuscar);
            this.panelSearch.Controls.Add(this.btnAddOwner);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelSearch.Size = new System.Drawing.Size(800, 128);
            this.panelSearch.TabIndex = 3;
            // 
            // txtMascota
            // 
            this.txtMascota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMascota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascota.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMascota.Location = new System.Drawing.Point(365, 68);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(244, 18);
            this.txtMascota.TabIndex = 7;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.lblMascota.Location = new System.Drawing.Point(362, 48);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(59, 17);
            this.lblMascota.TabIndex = 6;
            this.lblMascota.Text = "Mascota";
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.lblDueño.Location = new System.Drawing.Point(16, 48);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(48, 17);
            this.lblDueño.TabIndex = 5;
            this.lblDueño.Text = "Dueño";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(15, 9);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(82, 21);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Busqueda";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBuscar.Location = new System.Drawing.Point(19, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 18);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BorderRadius = 5;
            this.btnAddOwner.BorderSize = 0;
            this.btnAddOwner.FlatAppearance.BorderSize = 0;
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.ForeColor = System.Drawing.Color.White;
            this.btnAddOwner.Image = global::VentanaPrincipal.Properties.Resources.icons8_plus_math_25;
            this.btnAddOwner.Location = new System.Drawing.Point(624, 52);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(150, 45);
            this.btnAddOwner.TabIndex = 1;
            this.btnAddOwner.Text = "Nuevo";
            this.btnAddOwner.TextColor = System.Drawing.Color.White;
            this.btnAddOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddOwner.UseVisualStyleBackColor = false;
            // 
            // veterinariaDataSet1
            // 
            //this.veterinariaDataSet1.DataSetName = "veterinariaDataSet1";
            //this.veterinariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            //this.usuariosBindingSource.DataMember = "usuarios";
            //this.usuariosBindingSource.DataSource = this.veterinariaDataSet1;
            // 
            // usuariosTableAdapter
            // 
            //this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nusuarioDataGridViewTextBoxColumn
            // 
            this.nusuarioDataGridViewTextBoxColumn.DataPropertyName = "n_usuario";
            this.nusuarioDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nusuarioDataGridViewTextBoxColumn.Name = "nusuarioDataGridViewTextBoxColumn";
            this.nusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipousuarioDataGridViewTextBoxColumn
            // 
            this.tipousuarioDataGridViewTextBoxColumn.DataPropertyName = "tipo_usuario";
            this.tipousuarioDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipousuarioDataGridViewTextBoxColumn.Name = "tipousuarioDataGridViewTextBoxColumn";
            this.tipousuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cgvUsuarios);
            this.Controls.Add(this.panelSearch);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.usuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cgvUsuarios)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cgvUsuarios;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private RJButton btnAddOwner;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioDataGridViewTextBoxColumn;
    }
}