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
    public partial class Inserir_Treinador : Form
    {
        public Inserir_Treinador()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void treinadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treinadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Inserir_Treinador_Load(object sender, EventArgs e)
        {
            

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
                    this.treinadorTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue));
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
