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
    public partial class Inserir_Jogo : Form
    {
        public Inserir_Jogo()
        {
            InitializeComponent();
        }

        private void Inserir_Jogo_Load(object sender, EventArgs e)
        {

        }

        private void Inserir_Jogo_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
