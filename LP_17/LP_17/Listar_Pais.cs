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
    public partial class Listar_Pais : Form
    {
        public Listar_Pais()
        {
            InitializeComponent();
        }

        private void Listar_Pais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bDDataSet.Pais);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
