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
    public partial class Listar_Utilizadores : Form
    {
        public Listar_Utilizadores()
        {
            InitializeComponent();
        }

        private void Listar_Utilizadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Utilizadores' table. You can move, or remove it, as needed.
            this.utilizadoresTableAdapter.Fill(this.bDDataSet.Utilizadores);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listar_Utilizadores_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }

        
    }
}
