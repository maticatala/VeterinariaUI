namespace VentanaPrincipal.Forms.Practicas
{
    partial class practicasForm
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnAddOwner = new VentanaPrincipal.RJButton();
            this.cgvPracticas = new System.Windows.Forms.DataGridView();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaDataSet = new VentanaPrincipal.veterinariaDataSet();
            this.practicasTableAdapter = new VentanaPrincipal.veterinariaDataSetTableAdapters.practicasTableAdapter();
            this.codPracticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cgvPracticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.btnAddOwner);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelSearch.Size = new System.Drawing.Size(800, 128);
            this.panelSearch.TabIndex = 2;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddOwner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddOwner.BorderRadius = 5;
            this.btnAddOwner.BorderSize = 0;
            this.btnAddOwner.FlatAppearance.BorderSize = 0;
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.ForeColor = System.Drawing.Color.White;
            this.btnAddOwner.Image = global::VentanaPrincipal.Properties.Resources.icons8_plus_math_25;
            this.btnAddOwner.Location = new System.Drawing.Point(627, 43);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(150, 45);
            this.btnAddOwner.TabIndex = 1;
            this.btnAddOwner.Text = "Nuevo";
            this.btnAddOwner.TextColor = System.Drawing.Color.White;
            this.btnAddOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddOwner.UseVisualStyleBackColor = false;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // cgvPracticas
            // 
            this.cgvPracticas.AllowUserToAddRows = false;
            this.cgvPracticas.AllowUserToDeleteRows = false;
            this.cgvPracticas.AllowUserToResizeColumns = false;
            this.cgvPracticas.AllowUserToResizeRows = false;
            this.cgvPracticas.AutoGenerateColumns = false;
            this.cgvPracticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cgvPracticas.BackgroundColor = System.Drawing.Color.White;
            this.cgvPracticas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cgvPracticas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.cgvPracticas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cgvPracticas.ColumnHeadersHeight = 45;
            this.cgvPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cgvPracticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPracticaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.cgvPracticas.DataSource = this.practicasBindingSource;
            this.cgvPracticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cgvPracticas.EnableHeadersVisualStyles = false;
            this.cgvPracticas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.cgvPracticas.Location = new System.Drawing.Point(0, 128);
            this.cgvPracticas.Name = "cgvPracticas";
            this.cgvPracticas.ReadOnly = true;
            this.cgvPracticas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cgvPracticas.RowHeadersVisible = false;
            this.cgvPracticas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.cgvPracticas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cgvPracticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cgvPracticas.Size = new System.Drawing.Size(800, 322);
            this.cgvPracticas.TabIndex = 0;
            this.cgvPracticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // practicasBindingSource
            // 
            this.practicasBindingSource.DataMember = "practicas";
            this.practicasBindingSource.DataSource = this.veterinariaDataSet;
            // 
            // veterinariaDataSet
            // 
            this.veterinariaDataSet.DataSetName = "veterinariaDataSet";
            this.veterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // practicasTableAdapter
            // 
            this.practicasTableAdapter.ClearBeforeFill = true;
            // 
            // codPracticaDataGridViewTextBoxColumn
            // 
            this.codPracticaDataGridViewTextBoxColumn.DataPropertyName = "codPractica";
            this.codPracticaDataGridViewTextBoxColumn.FillWeight = 99.89848F;
            this.codPracticaDataGridViewTextBoxColumn.HeaderText = "Cod Practica";
            this.codPracticaDataGridViewTextBoxColumn.Name = "codPracticaDataGridViewTextBoxColumn";
            this.codPracticaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.FillWeight = 60.10152F;
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // practicasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cgvPracticas);
            this.Controls.Add(this.panelSearch);
            this.Name = "practicasForm";
            this.Text = "Practicas";
            this.Load += new System.EventHandler(this.practicasForm_Load);
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cgvPracticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private RJButton btnAddOwner;
        private System.Windows.Forms.DataGridView cgvPracticas;
        private veterinariaDataSet veterinariaDataSet;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private veterinariaDataSetTableAdapters.practicasTableAdapter practicasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPracticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}