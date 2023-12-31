﻿namespace VentanaPrincipal.Forms.HistoriaClinica
{
    partial class historiaClinica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdf = new System.Windows.Forms.PictureBox();
            this.lblDueño = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cgvAtencion = new System.Windows.Forms.DataGridView();
            this.atencionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaDataSet6 = new VentanaPrincipal.veterinariaDataSet6();
            this.atencionesTableAdapter1 = new VentanaPrincipal.veterinariaDataSet6TableAdapters.atencionesTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.atencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new VentanaPrincipal.RJButton();
            this.nroHCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaYHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgvAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.pdf);
            this.panel1.Controls.Add(this.lblDueño);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(800, 128);
            this.panel1.TabIndex = 8;
            // 
            // pdf
            // 
            this.pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf.Image = global::VentanaPrincipal.Properties.Resources.Arturo_Wibawa_Akar_File_24;
            this.pdf.Location = new System.Drawing.Point(528, 62);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(39, 35);
            this.pdf.TabIndex = 6;
            this.pdf.TabStop = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.lblDueño.Location = new System.Drawing.Point(16, 43);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(48, 17);
            this.lblDueño.TabIndex = 5;
            this.lblDueño.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBuscar.Location = new System.Drawing.Point(19, 70);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(244, 18);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cgvAtencion
            // 
            this.cgvAtencion.AllowUserToAddRows = false;
            this.cgvAtencion.AllowUserToDeleteRows = false;
            this.cgvAtencion.AllowUserToResizeColumns = false;
            this.cgvAtencion.AllowUserToResizeRows = false;
            this.cgvAtencion.AutoGenerateColumns = false;
            this.cgvAtencion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cgvAtencion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.cgvAtencion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cgvAtencion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.cgvAtencion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cgvAtencion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cgvAtencion.ColumnHeadersHeight = 55;
            this.cgvAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cgvAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroHCDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.fechaYHoraDataGridViewTextBoxColumn,
            this.resultadoDataGridViewTextBoxColumn,
            this.delete});
            this.cgvAtencion.DataSource = this.atencionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cgvAtencion.DefaultCellStyle = dataGridViewCellStyle2;
            this.cgvAtencion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgvAtencion.EnableHeadersVisualStyles = false;
            this.cgvAtencion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.cgvAtencion.Location = new System.Drawing.Point(0, 128);
            this.cgvAtencion.Name = "cgvAtencion";
            this.cgvAtencion.ReadOnly = true;
            this.cgvAtencion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cgvAtencion.RowHeadersVisible = false;
            this.cgvAtencion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.cgvAtencion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.cgvAtencion.RowTemplate.Height = 55;
            this.cgvAtencion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cgvAtencion.Size = new System.Drawing.Size(800, 322);
            this.cgvAtencion.TabIndex = 9;
            this.cgvAtencion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cgvAtencion_CellContentClick);
            this.cgvAtencion.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cgvAtencion_CellMouseEnter);
            // 
            // atencionesBindingSource
            // 
            this.atencionesBindingSource.DataMember = "atenciones";
            this.atencionesBindingSource.DataSource = this.veterinariaDataSet6;
            // 
            // veterinariaDataSet6
            // 
            this.veterinariaDataSet6.DataSetName = "veterinariaDataSet6";
            this.veterinariaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atencionesTableAdapter1
            // 
            this.atencionesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Accion";
            this.dataGridViewImageColumn1.Image = global::VentanaPrincipal.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 160;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::VentanaPrincipal.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::VentanaPrincipal.Properties.Resources.Arturo_Wibawa_Akar_File_512;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // atencionBindingSource
            // 
            this.atencionBindingSource.DataSource = typeof(CapaEntidadaes.Entities.Atencion);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnNuevo.BorderRadius = 5;
            this.btnNuevo.BorderSize = 0;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::VentanaPrincipal.Properties.Resources.icons8_plus_math_25;
            this.btnNuevo.Location = new System.Drawing.Point(624, 52);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 45);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // nroHCDataGridViewTextBoxColumn
            // 
            this.nroHCDataGridViewTextBoxColumn.DataPropertyName = "NroHC";
            this.nroHCDataGridViewTextBoxColumn.HeaderText = "NroHC";
            this.nroHCDataGridViewTextBoxColumn.Name = "nroHCDataGridViewTextBoxColumn";
            this.nroHCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaYHoraDataGridViewTextBoxColumn
            // 
            this.fechaYHoraDataGridViewTextBoxColumn.DataPropertyName = "FechaYHora";
            this.fechaYHoraDataGridViewTextBoxColumn.HeaderText = "FechaYHora";
            this.fechaYHoraDataGridViewTextBoxColumn.Name = "fechaYHoraDataGridViewTextBoxColumn";
            this.fechaYHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "Resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            this.resultadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Accion";
            this.delete.Image = global::VentanaPrincipal.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // historiaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cgvAtencion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historiaClinica";
            this.Text = "Historia Clinica";
            this.Load += new System.EventHandler(this.historiaClinica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cgvAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.TextBox txtBuscar;
        private RJButton btnNuevo;
        private System.Windows.Forms.DataGridView cgvAtencion;
        private veterinariaDataSet6 veterinariaDataSet6;
        private System.Windows.Forms.BindingSource atencionesBindingSource;
        private veterinariaDataSet6TableAdapters.atencionesTableAdapter atencionesTableAdapter1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.PictureBox pdf;
        private System.Windows.Forms.BindingSource atencionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroHCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaYHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}