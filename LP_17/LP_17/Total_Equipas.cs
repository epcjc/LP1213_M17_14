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
    public partial class Total_Equipas : Form
    {
        public Total_Equipas()
        {
            InitializeComponent();
        }

        private void Total_Equipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Total_Equipas' table. You can move, or remove it, as needed.
            this.Total_EquipasTableAdapter.Fill(this.BDDataSet.Total_Equipas);

            this.reportViewer1.RefreshReport();
        }

        private void Total_Equipas_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
