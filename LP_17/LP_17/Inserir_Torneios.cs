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
                string message = "Confirmar !!";
                this.torneiosTableAdapter.Insert(textBox1.Text, dateTimePicker1.Value, null, null, 1);
                int ultimoId = (int)this.torneiosTableAdapter.UltimoID();
                int ID_Equipa;

                var result = MessageBox.Show(message, "Inserção",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataRowView drv in listBox1.SelectedItems)
                    {
                        ID_Equipa = (int)drv["ID"];

                        this.torneio_EquipasTableAdapter.Insert(ultimoId, ID_Equipa);

                    }

                    MessageBox.Show("Dados inseridos com sucesso !!");
                }
                else
                {
                    MessageBox.Show("Operação cancelada !!");
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