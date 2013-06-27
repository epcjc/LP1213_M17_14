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
    public partial class Listar_Jogadores : Form
    {
        public Listar_Jogadores()
        {
            InitializeComponent();
        }

        private void Listar_Jogadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Relatorio_Jogadores' table. You can move, or remove it, as needed.
            this.relatorio_JogadoresTableAdapter.Fill(this.bDDataSet.Relatorio_Jogadores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Jogadores_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
