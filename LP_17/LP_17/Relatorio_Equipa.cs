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
    public partial class Relatorio_Equipa : Form
    {
        public Relatorio_Equipa()
        {
            InitializeComponent();
        }

        private void Relatorio_Equipa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.BDDataSet.Equipa);
            // TODO: This line of code loads data into the 'BDDataSet.Relatorio_Equipa' table. You can move, or remove it, as needed.
            //this.Relatorio_EquipaTableAdapter.Fill(this.BDDataSet.Relatorio_Equipa);

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv;

            drv = (DataRowView)this.comboBox1.SelectedItem;

            String Equipa = drv["Nome"].ToString();



            this.Relatorio_EquipaTableAdapter.FillByEquipa(this.BDDataSet.Relatorio_Equipa, Equipa);

            this.reportViewer1.RefreshReport();
        }
    }
}
