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
    public partial class Inserir_Torneios : Form
    {
        public Inserir_Torneios()
        {
            InitializeComponent();
        }

       

        private void Inserir_Torneios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.bDDataSet.Estado);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.torneiosTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, null, Convert.ToInt16(comboBox1.SelectedValue)); 
        }
    }
}
