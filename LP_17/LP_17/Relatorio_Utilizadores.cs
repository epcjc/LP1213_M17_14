﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_17
{
    public partial class Relatorio_Utilizadores : Form
    {
        public Relatorio_Utilizadores()
        {
            InitializeComponent();
        }

        private void Relatorio_Utilizadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Utilizadores' table. You can move, or remove it, as needed.
            this.UtilizadoresTableAdapter.Fill(this.BDDataSet.Utilizadores);

            this.reportViewer1.RefreshReport();
        }

        private void Relatorio_Utilizadores_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
