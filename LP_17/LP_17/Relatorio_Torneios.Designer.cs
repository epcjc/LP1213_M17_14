namespace LP_17
{
    partial class Relatorio_Torneios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDDataSet = new LP_17.BDDataSet();
            this.Relatorio_TorneiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Relatorio_TorneiosTableAdapter = new LP_17.BDDataSetTableAdapters.Relatorio_TorneiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_TorneiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Relatorio_TorneiosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_17.Relatorio_Torneios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(421, 300);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDDataSet
            // 
            this.BDDataSet.DataSetName = "BDDataSet";
            this.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Relatorio_TorneiosBindingSource
            // 
            this.Relatorio_TorneiosBindingSource.DataMember = "Relatorio_Torneios";
            this.Relatorio_TorneiosBindingSource.DataSource = this.BDDataSet;
            // 
            // Relatorio_TorneiosTableAdapter
            // 
            this.Relatorio_TorneiosTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio_Torneios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 300);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio_Torneios";
            this.Text = "Relatorio_Torneios";
            this.Load += new System.EventHandler(this.Relatorio_Torneios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_TorneiosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Relatorio_TorneiosBindingSource;
        private BDDataSet BDDataSet;
        private BDDataSetTableAdapters.Relatorio_TorneiosTableAdapter Relatorio_TorneiosTableAdapter;
    }
}