namespace LP_17
{
    partial class Pesquisar_Equipa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDDataSet = new LP_17.BDDataSet();
            this.Pesquisar_EquipaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pesquisar_EquipaTableAdapter = new LP_17.BDDataSetTableAdapters.Pesquisar_EquipaTableAdapter();
            this.equipaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipaTableAdapter = new LP_17.BDDataSetTableAdapters.EquipaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pesquisar_EquipaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(388, 312);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.equipaBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Pesquisar_EquipaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LP_17.Pesquisar_Equipa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(388, 196);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDDataSet
            // 
            this.BDDataSet.DataSetName = "BDDataSet";
            this.BDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pesquisar_EquipaBindingSource
            // 
            this.Pesquisar_EquipaBindingSource.DataMember = "Pesquisar_Equipa";
            this.Pesquisar_EquipaBindingSource.DataSource = this.BDDataSet;
            // 
            // Pesquisar_EquipaTableAdapter
            // 
            this.Pesquisar_EquipaTableAdapter.ClearBeforeFill = true;
            // 
            // equipaBindingSource
            // 
            this.equipaBindingSource.DataMember = "Equipa";
            this.equipaBindingSource.DataSource = this.BDDataSet;
            // 
            // equipaTableAdapter
            // 
            this.equipaTableAdapter.ClearBeforeFill = true;
            // 
            // Pesquisar_Equipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 312);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Pesquisar_Equipa";
            this.Text = "Pesquisar_Equipa";
            this.Load += new System.EventHandler(this.Pesquisar_Equipa_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pesquisar_EquipaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Pesquisar_EquipaBindingSource;
        private BDDataSet BDDataSet;
        private BDDataSetTableAdapters.Pesquisar_EquipaTableAdapter Pesquisar_EquipaTableAdapter;
        private System.Windows.Forms.BindingSource equipaBindingSource;
        private BDDataSetTableAdapters.EquipaTableAdapter equipaTableAdapter;
    }
}