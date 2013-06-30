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
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bDDataSet.Pais);
            // TODO: This line of code loads data into the 'bDDataSet.Equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.bDDataSet.Equipa);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Pretende mesmo inserir?";

                var result = MessageBox.Show(message, "Confirmação",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (textBox1.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Nome do treinador em falta");
                    }
                    else
                    {
                        this.treinadorTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue));
                        textBox1.Text = "";
                    }
                }
                else
                {

                    MessageBox.Show("Operação cancelada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, verifique se inseriu todos os campos corretamente, se o erro persistir contacte o fabricante");

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Insira o nome do treinador");
            }
        }

        private void Inserir_Treinador_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
