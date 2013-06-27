namespace LP_17
{
    partial class Listar_Jogadores
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golosMarcadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golosSofridosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amarelosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vermelhosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatorioJogadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new LP_17.BDDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.relatorio_JogadoresTableAdapter = new LP_17.BDDataSetTableAdapters.Relatorio_JogadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioJogadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(371, 261);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.golosMarcadosDataGridViewTextBoxColumn,
            this.golosSofridosDataGridViewTextBoxColumn,
            this.equipaDataGridViewTextBoxColumn,
            this.amarelosDataGridViewTextBoxColumn,
            this.vermelhosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relatorioJogadoresBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(371, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // golosMarcadosDataGridViewTextBoxColumn
            // 
            this.golosMarcadosDataGridViewTextBoxColumn.DataPropertyName = "Golos_Marcados";
            this.golosMarcadosDataGridViewTextBoxColumn.HeaderText = "Golos_Marcados";
            this.golosMarcadosDataGridViewTextBoxColumn.Name = "golosMarcadosDataGridViewTextBoxColumn";
            this.golosMarcadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // golosSofridosDataGridViewTextBoxColumn
            // 
            this.golosSofridosDataGridViewTextBoxColumn.DataPropertyName = "Golos_Sofridos";
            this.golosSofridosDataGridViewTextBoxColumn.HeaderText = "Golos_Sofridos";
            this.golosSofridosDataGridViewTextBoxColumn.Name = "golosSofridosDataGridViewTextBoxColumn";
            this.golosSofridosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipaDataGridViewTextBoxColumn
            // 
            this.equipaDataGridViewTextBoxColumn.DataPropertyName = "Equipa";
            this.equipaDataGridViewTextBoxColumn.HeaderText = "Equipa";
            this.equipaDataGridViewTextBoxColumn.Name = "equipaDataGridViewTextBoxColumn";
            this.equipaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amarelosDataGridViewTextBoxColumn
            // 
            this.amarelosDataGridViewTextBoxColumn.DataPropertyName = "Amarelos";
            this.amarelosDataGridViewTextBoxColumn.HeaderText = "Amarelos";
            this.amarelosDataGridViewTextBoxColumn.Name = "amarelosDataGridViewTextBoxColumn";
            this.amarelosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vermelhosDataGridViewTextBoxColumn
            // 
            this.vermelhosDataGridViewTextBoxColumn.DataPropertyName = "Vermelhos";
            this.vermelhosDataGridViewTextBoxColumn.HeaderText = "Vermelhos";
            this.vermelhosDataGridViewTextBoxColumn.Name = "vermelhosDataGridViewTextBoxColumn";
            this.vermelhosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relatorioJogadoresBindingSource
            // 
            this.relatorioJogadoresBindingSource.DataMember = "Relatorio_Jogadores";
            this.relatorioJogadoresBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // relatorio_JogadoresTableAdapter
            // 
            this.relatorio_JogadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Listar_Jogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.splitContainer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listar_Jogadores";
            this.Text = "Listar_Jogadores";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Listar_Jogadores_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Listar_Jogadores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioJogadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource relatorioJogadoresBindingSource;
        private BDDataSetTableAdapters.Relatorio_JogadoresTableAdapter relatorio_JogadoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golosMarcadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn golosSofridosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amarelosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vermelhosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}