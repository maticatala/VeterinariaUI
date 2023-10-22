namespace VentanaPrincipal.Forms.HistoriaClinica
{
    partial class report
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
            this.veterinariaDataSet8 = new VentanaPrincipal.veterinariaDataSet8();
            this.atencionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencionesTableAdapter = new VentanaPrincipal.veterinariaDataSet8TableAdapters.atencionesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // veterinariaDataSet8
            // 
            this.veterinariaDataSet8.DataSetName = "veterinariaDataSet8";
            this.veterinariaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atencionesBindingSource
            // 
            this.atencionesBindingSource.DataMember = "atenciones";
            this.atencionesBindingSource.DataSource = this.veterinariaDataSet8;
            // 
            // atencionesTableAdapter
            // 
            this.atencionesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VentanaPrincipal.Forms.HistoriaClinica.report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private veterinariaDataSet8 veterinariaDataSet8;
        private System.Windows.Forms.BindingSource atencionesBindingSource;
        private veterinariaDataSet8TableAdapters.atencionesTableAdapter atencionesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}