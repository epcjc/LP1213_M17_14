using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_17
{
    public partial class Inserir_Nacionalidades : Form
    {
        public Inserir_Nacionalidades()
        {
            InitializeComponent();
        }

        private void nacionalidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nacionalidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Inserir_Nacionalidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Nacionalidades' table. You can move, or remove it, as needed.
            this.nacionalidadesTableAdapter.Fill(this.bDDataSet.Nacionalidades);

        }
    }
}
