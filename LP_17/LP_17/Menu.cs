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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir_Torneios frm = new Inserir_Torneios();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir_Equipa frm = new Inserir_Equipa();
            frm.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir_Treinador frm = new Inserir_Treinador();
            frm.Show();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inserir_Jogador frm = new Inserir_Jogador();
            frm.Show();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inserir_Utilizador frm = new Inserir_Utilizador();
            frm.Show();
        }

        private void pesquisarEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Equipa frm = new Relatorio_Equipa();
            frm.Show();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Listar_Equipas frm = new Listar_Equipas();
            frm.Show();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Listar_Treinadores frm = new Listar_Treinadores();
            frm.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listar_Jogadores frm = new Listar_Jogadores();
            frm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Utilizadores frm = new Listar_Utilizadores();
            frm.Show();
        }

        private void Menu_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void nºDeEquipasDeCadaTorneioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total_Equipas frm = new Total_Equipas();
            frm.Show();
        }

    }
}
