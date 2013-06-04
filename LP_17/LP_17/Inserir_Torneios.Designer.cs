namespace LP_17
{
    partial class Inserir_Torneios
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new LP_17.BDDataSet();
            this.torneiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneiosTableAdapter = new LP_17.BDDataSetTableAdapters.TorneiosTableAdapter();
            this.tableAdapterManager = new LP_17.BDDataSetTableAdapters.TableAdapterManager();
            this.estadoTableAdapter = new LP_17.BDDataSetTableAdapters.EstadoTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.equipaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipaTableAdapter = new LP_17.BDDataSetTableAdapters.EquipaTableAdapter();
            this.torneio_EquipasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneio_EquipasTableAdapter = new LP_17.BDDataSetTableAdapters.Torneio_EquipasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneio_EquipasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Início:";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.bDDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Classificacao_TorneioTableAdapter = null;
            this.tableAdapterManager.EquipaTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Estatisticas_TorneioTableAdapter = null;
            this.tableAdapterManager.GolosTableAdapter = null;
            this.tableAdapterManager.JogadoresTableAdapter = null;
            this.tableAdapterManager.JogosTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.Torneio_EquipasTableAdapter = null;
            this.tableAdapterManager.TorneiosTableAdapter = this.torneiosTableAdapter;
            this.tableAdapterManager.TreinadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_17.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.equipaBindingSource;
            this.listBox1.DisplayMember = "Nome";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(408, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(163, 199);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "ID";
            // 
            // equipaBindingSource
            // 
            this.equipaBindingSource.DataMember = "Equipa";
            this.equipaBindingSource.DataSource = this.bDDataSet;
            // 
            // equipaTableAdapter
            // 
            this.equipaTableAdapter.ClearBeforeFill = true;
            // 
            // torneio_EquipasBindingSource
            // 
            this.torneio_EquipasBindingSource.DataMember = "Torneio_Equipas";
            this.torneio_EquipasBindingSource.DataSource = this.bDDataSet;
            // 
            // torneio_EquipasTableAdapter
            // 
            this.torneio_EquipasTableAdapter.ClearBeforeFill = true;
            // 
            // Inserir_Torneios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 298);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Inserir_Torneios";
            this.Text = "Inserir_Torneios";
            this.Load += new System.EventHandler(this.Inserir_Torneios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneio_EquipasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource torneiosBindingSource;
        private BDDataSetTableAdapters.TorneiosTableAdapter torneiosTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private BDDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource equipaBindingSource;
        private BDDataSetTableAdapters.EquipaTableAdapter equipaTableAdapter;
        private System.Windows.Forms.BindingSource torneio_EquipasBindingSource;
        private BDDataSetTableAdapters.Torneio_EquipasTableAdapter torneio_EquipasTableAdapter;
    }
}