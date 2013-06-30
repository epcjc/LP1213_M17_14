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
    public partial class Inserir_Jogador : Form
    {
        public Inserir_Jogador()
        {
            InitializeComponent();
        }

        

        private void Inserir_Jogador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.Equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.bDDataSet.Equipa);
            // TODO: This line of code loads data into the 'bDDataSet.Pais' table. You can move, or remove it, as needed.
            this.paisTableAdapter.Fill(this.bDDataSet.Pais);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            
            try
            {
                string message = "Pretende mesmo inserir?";

                var result = MessageBox.Show(message, "Confirmação",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);
               
                int a = Convert.ToInt16(textBox1.Text);
                    
                        if (result == DialogResult.Yes)
                        {
                            if (textBox3.Text.Trim().Length == 0)
                            {
                                MessageBox.Show("Nome do jogador em falta");
                            }
                            else
                            {
                                if (a >= 1 && a <= 99)
                                {
                                    this.jogadoresTableAdapter.Insert(Convert.ToInt16(textBox1.Text), textBox3.Text, dateTimePicker1.Value, Convert.ToInt16(comboBox2.SelectedValue), 15, null, 4, 1, Convert.ToInt16(comboBox1.SelectedValue));
                                    textBox1.Text = "";
                                    textBox3.Text = "";
                                }

                                else
                                {
                                    MessageBox.Show("Tem de inserir um numero entre 1 e 99");
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Insira o número do jogador, entre 1 e 99 (ambos incluídos)");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Insira o nome do jogador");
            }
        }

        private void Inserir_Jogador_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
