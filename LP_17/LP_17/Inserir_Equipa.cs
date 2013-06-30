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
                string message = "Pretende mesmo inserir?";

                var result = MessageBox.Show(message, "Confirmação",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                DateTime Data = DateTime.Now;
                string DataFormato = Data.ToString("yyyy");
                int a = Convert.ToInt16(textBox2.Text);
                int b = Convert.ToInt16(DataFormato);

                if (result == DialogResult.Yes)
                {
                    if (textBox1.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Nome da equipa em falta");
                    }
                    else
                    {
                        if (a <= b && a >= 1857)
                        {
                            this.equipaTableAdapter.Insert(textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(textBox2.Text));
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {

                            MessageBox.Show("Insira um ano de fundação entre 1857 e o atual (ambos incluídos)");
                        }
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

        private void Inserir_Equipa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bDDataSet.Pais);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if(textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Insira o nome da equipa");
            }
            
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Insira o ano de fundação, entre 1857 e o atual (ambos incluídos)");
            }
        }

        private void Inserir_Equipa_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
