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
    public partial class Relatorio_Equipas : Form
    {
        public Relatorio_Equipas()
        {
            InitializeComponent();
        }

        private void Relatorio_Equipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Relatorio_Equipas' table. You can move, or remove it, as needed.
            this.Relatorio_EquipasTableAdapter.Fill(this.BDDataSet.Relatorio_Equipas);

            this.reportViewer1.RefreshReport();
        }

        private void Relatorio_Equipas_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
