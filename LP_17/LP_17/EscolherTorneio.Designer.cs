namespace LP_17
{
    partial class EscolherTorneio
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bDDataSet = new LP_17.BDDataSet();
            this.torneiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneiosTableAdapter = new LP_17.BDDataSetTableAdapters.TorneiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.torneiosBindingSource;
            this.listBox1.DisplayMember = "Nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(73, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ID";
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torneiosBindingSource
            // 
            this.torneiosBindingSource.DataMember = "Torneios";
            this.torneiosBindingSource.DataSource = this.bDDataSet;
            // 
            // torneiosTableAdapter
            // 
            this.torneiosTableAdapter.ClearBeforeFill = true;
            // 
            // EscolherTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Name = "EscolherTorneio";
            this.Text = "EscolherTorneio";
            this.Load += new System.EventHandler(this.EscolherTorneio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneiosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource torneiosBindingSource;
        private BDDataSetTableAdapters.TorneiosTableAdapter torneiosTableAdapter;
    }
}