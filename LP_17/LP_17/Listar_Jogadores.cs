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
    public partial class Listar_Jogadores : Form
    {
        public Listar_Jogadores()
        {
            InitializeComponent();
        }

        private void Listar_Jogadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Listar_Jogadores' table. You can move, or remove it, as needed.
            this.Listar_JogadoresTableAdapter.Fill(this.BDDataSet.Listar_Jogadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
