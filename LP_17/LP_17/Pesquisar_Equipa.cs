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
    public partial class Pesquisar_Equipa : Form
    {
        public Pesquisar_Equipa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv;

            drv = (DataRowView)this.comboBox1.SelectedItem;

            String Equipa = drv["Nome"].ToString();

            this.Pesquisar_EquipaTableAdapter.FillByPesquisar(this.BDDataSet.Pesquisar_Equipa, Equipa);

            this.reportViewer1.RefreshReport();
        }

        private void Pesquisar_Equipa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.Equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.BDDataSet.Equipa);
            // TODO: This line of code loads data into the 'BDDataSet.Pesquisar_Equipa' table. You can move, or remove it, as needed.

        }

    }
}
