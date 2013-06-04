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
    public partial class Inserir_Utilizador : Form
    {
        public Inserir_Utilizador()
        {
            InitializeComponent();
        }

        private void utilizadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Inserir_Utilizador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Utilizadores' table. You can move, or remove it, as needed.
            this.utilizadoresTableAdapter.Fill(this.bDDataSet.Utilizadores);

        }
    }
}
