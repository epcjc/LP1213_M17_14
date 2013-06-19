namespace LP_17
{
    partial class Listar_Treinadores
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
            this.Listar_TreinadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDDataSet = new LP_17.BDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Listar_TreinadoresTableAdapter = new LP_17.BDDataSetTableAdapters.Listar_TreinadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_TreinadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Listar_TreinadoresBindingSource
            // 
            this.Listar_TreinadoresBindingSource.DataMember = "Listar_Treinadores";
            this.Listar_TreinadoresBindingSource.DataSource = this.BDDataSet;
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
            reportDataSource1.Value = this.Listar_TreinadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_17.Listar_Treinadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(440, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // Listar_TreinadoresTableAdapter
            // 
            this.Listar_TreinadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Listar_Treinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Listar_Treinadores";
            this.Text = "Listar_Treinadores";
            this.Load += new System.EventHandler(this.Listar_Treinadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listar_TreinadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Listar_TreinadoresBindingSource;
        private BDDataSet BDDataSet;
        private BDDataSetTableAdapters.Listar_TreinadoresTableAdapter Listar_TreinadoresTableAdapter;
    }
}