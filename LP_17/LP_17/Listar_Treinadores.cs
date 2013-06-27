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
    public partial class Listar_Treinadores : Form
    {
        public Listar_Treinadores()
        {
            InitializeComponent();
        }

        private void Listar_Treinadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Relatorio_Treinadores' table. You can move, or remove it, as needed.
            this.relatorio_TreinadoresTableAdapter.Fill(this.bDDataSet.Relatorio_Treinadores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Treinadores_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
