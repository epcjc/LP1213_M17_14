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
            // TODO: This line of code loads data into the 'bDDataSet.Torneio_Equipas' table. You can move, or remove it, as needed.
            this.torneio_EquipasTableAdapter.Fill(this.bDDataSet.Torneio_Equipas);
            // TODO: This line of code loads data into the 'bDDataSet.Equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.bDDataSet.Equipa);
            // TODO: This line of code loads data into the 'bDDataSet.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.bDDataSet.Estado);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string message = "Pretende mesmo inserir?";
                this.torneiosTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value, null, null, 1);
                int ultimoId = (int)this.torneiosTableAdapter.UltimoID();
                int ID_Equipa;

                var result = MessageBox.Show(message, "Confirmação",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    if (listBox1.SelectedValue == null | Convert.ToInt16(listBox1.SelectedValue) == 1)
                    {
                        MessageBox.Show("Tem de inserir no mínimo 2 equipas");
                    }
                    else
                    {
                        if (textBox1.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Nome do torneio em falta");
                        }
                        else
                        {
                            foreach (DataRowView drv in listBox1.SelectedItems)
                            {
                                ID_Equipa = (int)drv["ID"];

                                this.torneio_EquipasTableAdapter.Insert(ultimoId, ID_Equipa);

                            }

                            textBox1.Text = "";


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
                errorProvider1.SetError(textBox1, "Insira o nome do torneio");
            }
        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {
            if (listBox1.Text == "")
            {
                errorProvider1.SetError(listBox1, "Selecione 2 ou mais equipas");
            }
        }

        private void Inserir_Torneios_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }
    }
}