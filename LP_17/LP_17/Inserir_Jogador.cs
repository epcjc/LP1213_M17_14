﻿using System;
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
                string message = "Confirmar !!";

                var result = MessageBox.Show(message, "Inserção",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.jogadoresTableAdapter.Insert(Convert.ToInt16(textBox1.Text), textBox3.Text, dateTimePicker1.Value, Convert.ToInt16(comboBox2.SelectedValue), null, null, null, null, Convert.ToInt16(comboBox1.Text));
                    MessageBox.Show("Dados inseridos com sucesso !!");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Operação Cancelada !!");
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro !!") ;

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
                errorProvider1.SetError(textBox1, "Não pode ser vazio !!");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Não pode ser vazio !!");
            }
        }

        private void Inserir_Jogador_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}
