namespace VentanaPrincipal.Forms.RazasEspecies
{
    partial class razasEspeciesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRazas = new System.Windows.Forms.DataGridView();
            this.codRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEspecies = new System.Windows.Forms.DataGridView();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnAddRaza = new VentanaPrincipal.RJButton();
            this.txtBuscarRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBuscarEspecie = new System.Windows.Forms.TextBox();
            this.btnAddEspecie = new VentanaPrincipal.RJButton();
            this.razaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codEspecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEspecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Size = new System.Drawing.Size(1404, 772);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.dgvRazas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEspecies, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 183);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1350, 564);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvRazas
            // 
            this.dgvRazas.AllowUserToAddRows = false;
            this.dgvRazas.AllowUserToDeleteRows = false;
            this.dgvRazas.AllowUserToResizeColumns = false;
            this.dgvRazas.AllowUserToResizeRows = false;
            this.dgvRazas.AutoGenerateColumns = false;
            this.dgvRazas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRazas.BackgroundColor = System.Drawing.Color.White;
            this.dgvRazas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRazas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRazas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRazas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRazas.ColumnHeadersHeight = 45;
            this.dgvRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRazas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codRazaDataGridViewTextBoxColumn,
            this.nombreRazaDataGridViewTextBoxColumn,
            this.CodEspecie});
            this.dgvRazas.DataSource = this.razaBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRazas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRazas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRazas.EnableHeadersVisualStyles = false;
            this.dgvRazas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.dgvRazas.Location = new System.Drawing.Point(544, 4);
            this.dgvRazas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRazas.Name = "dgvRazas";
            this.dgvRazas.ReadOnly = true;
            this.dgvRazas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRazas.RowHeadersVisible = false;
            this.dgvRazas.RowHeadersWidth = 51;
            this.dgvRazas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRazas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRazas.RowTemplate.Height = 55;
            this.dgvRazas.RowTemplate.ReadOnly = true;
            this.dgvRazas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRazas.Size = new System.Drawing.Size(802, 556);
            this.dgvRazas.TabIndex = 1;
            // 
            // codRazaDataGridViewTextBoxColumn
            // 
            this.codRazaDataGridViewTextBoxColumn.DataPropertyName = "CodRaza";
            this.codRazaDataGridViewTextBoxColumn.HeaderText = "CodRaza";
            this.codRazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codRazaDataGridViewTextBoxColumn.Name = "codRazaDataGridViewTextBoxColumn";
            this.codRazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreRazaDataGridViewTextBoxColumn
            // 
            this.nombreRazaDataGridViewTextBoxColumn.DataPropertyName = "NombreRaza";
            this.nombreRazaDataGridViewTextBoxColumn.HeaderText = "NombreRaza";
            this.nombreRazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreRazaDataGridViewTextBoxColumn.Name = "nombreRazaDataGridViewTextBoxColumn";
            this.nombreRazaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CodEspecie
            // 
            this.CodEspecie.DataPropertyName = "CodEspecie";
            this.CodEspecie.HeaderText = "CodEspecie";
            this.CodEspecie.MinimumWidth = 6;
            this.CodEspecie.Name = "CodEspecie";
            this.CodEspecie.ReadOnly = true;
            this.CodEspecie.Visible = false;
            // 
            // razaBindingSource1
            // 
            this.razaBindingSource1.DataSource = typeof(CapaEntidadaes.Entities.Raza);
            // 
            // dgvEspecies
            // 
            this.dgvEspecies.AllowUserToAddRows = false;
            this.dgvEspecies.AllowUserToDeleteRows = false;
            this.dgvEspecies.AllowUserToResizeColumns = false;
            this.dgvEspecies.AllowUserToResizeRows = false;
            this.dgvEspecies.AutoGenerateColumns = false;
            this.dgvEspecies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecies.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvEspecies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEspecies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEspecies.ColumnHeadersHeight = 45;
            this.dgvEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEspecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEspecieDataGridViewTextBoxColumn,
            this.nombreEspecieDataGridViewTextBoxColumn,
            this.borrar});
            this.dgvEspecies.DataSource = this.especieBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspecies.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEspecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecies.EnableHeadersVisualStyles = false;
            this.dgvEspecies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.dgvEspecies.Location = new System.Drawing.Point(4, 4);
            this.dgvEspecies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEspecies.Name = "dgvEspecies";
            this.dgvEspecies.ReadOnly = true;
            this.dgvEspecies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEspecies.RowHeadersVisible = false;
            this.dgvEspecies.RowHeadersWidth = 51;
            this.dgvEspecies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEspecies.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEspecies.RowTemplate.Height = 55;
            this.dgvEspecies.RowTemplate.ReadOnly = true;
            this.dgvEspecies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecies.Size = new System.Drawing.Size(532, 556);
            this.dgvEspecies.TabIndex = 0;
            this.dgvEspecies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecies_CellClick);
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataSource = typeof(CapaEntidadaes.Entities.Especie);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.btnAddRaza);
            this.panelSearch.Controls.Add(this.txtBuscarRaza);
            this.panelSearch.Controls.Add(this.lblRaza);
            this.panelSearch.Controls.Add(this.lblEspecie);
            this.panelSearch.Controls.Add(this.lblBusqueda);
            this.panelSearch.Controls.Add(this.txtBuscarEspecie);
            this.panelSearch.Controls.Add(this.btnAddEspecie);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(27, 25);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.panelSearch.Size = new System.Drawing.Size(1350, 158);
            this.panelSearch.TabIndex = 1;
            // 
            // btnAddRaza
            // 
            this.btnAddRaza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddRaza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddRaza.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddRaza.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddRaza.BorderRadius = 5;
            this.btnAddRaza.BorderSize = 0;
            this.btnAddRaza.FlatAppearance.BorderSize = 0;
            this.btnAddRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRaza.ForeColor = System.Drawing.Color.White;
            this.btnAddRaza.Image = global::VentanaPrincipal.Properties.Resources.icons8_plus_math_25;
            this.btnAddRaza.Location = new System.Drawing.Point(986, 59);
            this.btnAddRaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRaza.Name = "btnAddRaza";
            this.btnAddRaza.Size = new System.Drawing.Size(200, 55);
            this.btnAddRaza.TabIndex = 8;
            this.btnAddRaza.Text = "Nueva Raza";
            this.btnAddRaza.TextColor = System.Drawing.Color.White;
            this.btnAddRaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRaza.UseVisualStyleBackColor = false;
            this.btnAddRaza.Click += new System.EventHandler(this.btnAddRaza_Click);
            // 
            // txtBuscarRaza
            // 
            this.txtBuscarRaza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarRaza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRaza.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBuscarRaza.Location = new System.Drawing.Point(653, 84);
            this.txtBuscarRaza.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRaza.Name = "txtBuscarRaza";
            this.txtBuscarRaza.Size = new System.Drawing.Size(325, 22);
            this.txtBuscarRaza.TabIndex = 7;
            this.txtBuscarRaza.TextChanged += new System.EventHandler(this.txtBuscarRaza_TextChanged);
            // 
            // lblRaza
            // 
            this.lblRaza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.lblRaza.Location = new System.Drawing.Point(649, 59);
            this.lblRaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(47, 23);
            this.lblRaza.TabIndex = 6;
            this.lblRaza.Text = "Raza";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.lblEspecie.Location = new System.Drawing.Point(21, 59);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(66, 23);
            this.lblEspecie.TabIndex = 5;
            this.lblEspecie.Text = "Especie";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(20, 11);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(102, 28);
            this.lblBusqueda.TabIndex = 4;
            this.lblBusqueda.Text = "Busqueda";
            // 
            // txtBuscarEspecie
            // 
            this.txtBuscarEspecie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarEspecie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEspecie.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBuscarEspecie.Location = new System.Drawing.Point(25, 84);
            this.txtBuscarEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarEspecie.Name = "txtBuscarEspecie";
            this.txtBuscarEspecie.Size = new System.Drawing.Size(325, 22);
            this.txtBuscarEspecie.TabIndex = 3;
            this.txtBuscarEspecie.TextChanged += new System.EventHandler(this.txtBuscarEspecie_TextChanged);
            // 
            // btnAddEspecie
            // 
            this.btnAddEspecie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEspecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddEspecie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddEspecie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(128)))), ((int)(((byte)(236)))));
            this.btnAddEspecie.BorderRadius = 5;
            this.btnAddEspecie.BorderSize = 0;
            this.btnAddEspecie.FlatAppearance.BorderSize = 0;
            this.btnAddEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEspecie.ForeColor = System.Drawing.Color.White;
            this.btnAddEspecie.Image = global::VentanaPrincipal.Properties.Resources.icons8_plus_math_25;
            this.btnAddEspecie.Location = new System.Drawing.Point(371, 59);
            this.btnAddEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEspecie.Name = "btnAddEspecie";
            this.btnAddEspecie.Size = new System.Drawing.Size(200, 55);
            this.btnAddEspecie.TabIndex = 1;
            this.btnAddEspecie.Text = "Nueva Especie";
            this.btnAddEspecie.TextColor = System.Drawing.Color.White;
            this.btnAddEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEspecie.UseVisualStyleBackColor = false;
            this.btnAddEspecie.Click += new System.EventHandler(this.btnAddEspecie_Click);
            // 
            // codEspecieDataGridViewTextBoxColumn
            // 
            this.codEspecieDataGridViewTextBoxColumn.DataPropertyName = "CodEspecie";
            this.codEspecieDataGridViewTextBoxColumn.FillWeight = 117.9144F;
            this.codEspecieDataGridViewTextBoxColumn.HeaderText = "CodEspecie";
            this.codEspecieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codEspecieDataGridViewTextBoxColumn.Name = "codEspecieDataGridViewTextBoxColumn";
            this.codEspecieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEspecieDataGridViewTextBoxColumn
            // 
            this.nombreEspecieDataGridViewTextBoxColumn.DataPropertyName = "NombreEspecie";
            this.nombreEspecieDataGridViewTextBoxColumn.FillWeight = 117.9144F;
            this.nombreEspecieDataGridViewTextBoxColumn.HeaderText = "NombreEspecie";
            this.nombreEspecieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreEspecieDataGridViewTextBoxColumn.Name = "nombreEspecieDataGridViewTextBoxColumn";
            this.nombreEspecieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.FillWeight = 64.17112F;
            this.borrar.HeaderText = "";
            this.borrar.Image = global::VentanaPrincipal.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            this.borrar.MinimumWidth = 6;
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // razasEspeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1404, 772);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "razasEspeciesForm";
            this.Text = "RazasEspecies";
            this.Load += new System.EventHandler(this.razasEspeciesForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.razaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtBuscarRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBuscarEspecie;
        private RJButton btnAddEspecie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEspecies;
        private System.Windows.Forms.BindingSource razaBindingSource;
        private System.Windows.Forms.BindingSource especieBindingSource;
        private System.Windows.Forms.DataGridView dgvRazas;
        private System.Windows.Forms.BindingSource razaBindingSource1;
        private RJButton btnAddRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEspecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEspecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn borrar;
    }
}