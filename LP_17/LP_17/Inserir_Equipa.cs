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
    public partial class Inserir_Equipa : Form
    {
        public Inserir_Equipa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Confirmar !!";

                var result = MessageBox.Show(message, "Inserção",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.equipaTableAdapter.Insert(textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(textBox2.Text));
                    MessageBox.Show("Dados inseridos com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada !!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro !!");

            }
        }

        private void Inserir_Equipa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bDDataSet.Pais);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
