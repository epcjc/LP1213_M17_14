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
    public partial class Relatorio_Treinadores : Form
    {
        public Relatorio_Treinadores()
        {
            InitializeComponent();
        }

        private void Relatorio_Treinadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Relatorio_Treinadores' table. You can move, or remove it, as needed.
            this.Relatorio_TreinadoresTableAdapter.Fill(this.BDDataSet.Relatorio_Treinadores);

            this.reportViewer1.RefreshReport();
        }

        private void Relatorio_Treinadores_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
