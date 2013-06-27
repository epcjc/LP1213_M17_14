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
    public partial class Relatorio_Torneios : Form
    {
        public Relatorio_Torneios()
        {
            InitializeComponent();
        }

        private void Relatorio_Torneios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Relatorio_Torneios' table. You can move, or remove it, as needed.
            this.Relatorio_TorneiosTableAdapter.Fill(this.BDDataSet.Relatorio_Torneios);

            this.reportViewer1.RefreshReport();
        }
    }
}
