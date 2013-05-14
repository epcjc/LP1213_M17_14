namespace LP_17
{
    partial class Inserir_Nacionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir_Nacionalidades));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nacionalidadeLabel;
            this.bDDataSet = new LP_17.BDDataSet();
            this.nacionalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nacionalidadesTableAdapter = new LP_17.BDDataSetTableAdapters.NacionalidadesTableAdapter();
            this.tableAdapterManager = new LP_17.BDDataSetTableAdapters.TableAdapterManager();
            this.nacionalidadesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nacionalidadesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nacionalidadeTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nacionalidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesBindingNavigator)).BeginInit();
            this.nacionalidadesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nacionalidadesBindingSource
            // 
            this.nacionalidadesBindingSource.DataMember = "Nacionalidades";
            this.nacionalidadesBindingSource.DataSource = this.bDDataSet;
            // 
            // nacionalidadesTableAdapter
            // 
            this.nacionalidadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Classificacao_TorneioTableAdapter = null;
            this.tableAdapterManager.EquipaTableAdapter = null;
            this.tableAdapterManager.Estatisticas_TorneioTableAdapter = null;
            this.tableAdapterManager.GolosTableAdapter = null;
            this.tableAdapterManager.JogadoresTableAdapter = null;
            this.tableAdapterManager.JogosTableAdapter = null;
            this.tableAdapterManager.NacionalidadesTableAdapter = this.nacionalidadesTableAdapter;
            this.tableAdapterManager.Torneio_EquipasTableAdapter = null;
            this.tableAdapterManager.TorneiosTableAdapter = null;
            this.tableAdapterManager.TreinadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LP_17.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nacionalidadesBindingNavigator
            // 
            this.nacionalidadesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nacionalidadesBindingNavigator.BindingSource = this.nacionalidadesBindingSource;
            this.nacionalidadesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nacionalidadesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nacionalidadesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nacionalidadesBindingNavigatorSaveItem});
            this.nacionalidadesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nacionalidadesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nacionalidadesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nacionalidadesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nacionalidadesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nacionalidadesBindingNavigator.Name = "nacionalidadesBindingNavigator";
            this.nacionalidadesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nacionalidadesBindingNavigator.Size = new System.Drawing.Size(318, 25);
            this.nacionalidadesBindingNavigator.TabIndex = 0;
            this.nacionalidadesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // nacionalidadesBindingNavigatorSaveItem
            // 
            this.nacionalidadesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nacionalidadesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nacionalidadesBindingNavigatorSaveItem.Image")));
            this.nacionalidadesBindingNavigatorSaveItem.Name = "nacionalidadesBindingNavigatorSaveItem";
            this.nacionalidadesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nacionalidadesBindingNavigatorSaveItem.Text = "Save Data";
            this.nacionalidadesBindingNavigatorSaveItem.Click += new System.EventHandler(this.nacionalidadesBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(60, 99);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nacionalidadesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(144, 96);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nacionalidadeLabel
            // 
            nacionalidadeLabel.AutoSize = true;
            nacionalidadeLabel.Location = new System.Drawing.Point(60, 125);
            nacionalidadeLabel.Name = "nacionalidadeLabel";
            nacionalidadeLabel.Size = new System.Drawing.Size(78, 13);
            nacionalidadeLabel.TabIndex = 3;
            nacionalidadeLabel.Text = "Nacionalidade:";
            // 
            // nacionalidadeTextBox
            // 
            this.nacionalidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nacionalidadesBindingSource, "Nacionalidade", true));
            this.nacionalidadeTextBox.Location = new System.Drawing.Point(144, 122);
            this.nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            this.nacionalidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nacionalidadeTextBox.TabIndex = 4;
            // 
            // Inserir_Nacionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nacionalidadeLabel);
            this.Controls.Add(this.nacionalidadeTextBox);
            this.Controls.Add(this.nacionalidadesBindingNavigator);
            this.Name = "Inserir_Nacionalidades";
            this.Text = "Inserir_Nacionalidades";
            this.Load += new System.EventHandler(this.Inserir_Nacionalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nacionalidadesBindingNavigator)).EndInit();
            this.nacionalidadesBindingNavigator.ResumeLayout(false);
            this.nacionalidadesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource nacionalidadesBindingSource;
        private BDDataSetTableAdapters.NacionalidadesTableAdapter nacionalidadesTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nacionalidadesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nacionalidadesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nacionalidadeTextBox;
    }
}