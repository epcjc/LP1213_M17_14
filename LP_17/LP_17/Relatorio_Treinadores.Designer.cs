namespace LP_17
{
    partial class Relatorio_Treinadores
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
            this.Relatorio_TreinadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDDataSet = new LP_17.BDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Relatorio_TreinadoresTableAdapter = new LP_17.BDDataSetTableAdapters.Relatorio_TreinadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_TreinadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Relatorio_TreinadoresBindingSource
            // 
            this.Relatorio_TreinadoresBindingSource.DataMember = "Relatorio_Treinadores";
            this.Relatorio_TreinadoresBindingSource.DataSource = this.BDDataSet;
            // 
            // BDDataSet
            // 
            this.BDDataSet.DataSetName = "BDDataSet";
            this.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Relatorio_TreinadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_17.Relatorio_Treinadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(440, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // Relatorio_TreinadoresTableAdapter
            // 
            this.Relatorio_TreinadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio_Treinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.Controls.Add(this.reportViewer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Relatorio_Treinadores";
            this.Text = "Relatorio_Treinadores";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Relatorio_Treinadores_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Relatorio_Treinadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_TreinadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Relatorio_TreinadoresBindingSource;
        private BDDataSet BDDataSet;
        private BDDataSetTableAdapters.Relatorio_TreinadoresTableAdapter Relatorio_TreinadoresTableAdapter;
    }
}