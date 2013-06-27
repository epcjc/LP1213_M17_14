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
    public partial class Listar_Equipas : Form
    {
        public Listar_Equipas()
        {
            InitializeComponent();
        }

        private void Listar_Equipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Relatorio_Equipas' table. You can move, or remove it, as needed.
            this.relatorio_EquipasTableAdapter.Fill(this.bDDataSet.Relatorio_Equipas);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Equipas_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
