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
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir_Equipa frm = new Inserir_Equipa();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inserir_Treinador frm = new Inserir_Treinador();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inserir_Jogador frm = new Inserir_Jogador();
            frm.ShowDialog();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inserir_Utilizador frm = new Inserir_Utilizador();
            frm.ShowDialog();
        }

        private void pesquisarEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisar_Equipa frm = new Pesquisar_Equipa();
            frm.ShowDialog();
        }

        private void RelatorioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Relatorio_Equipas frm = new Relatorio_Equipas();
            frm.ShowDialog();
        }

        private void RelatorioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Relatorio_Treinadores frm = new Relatorio_Treinadores();
            frm.ShowDialog();
        }

        private void RelatorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorio_Jogadores frm = new Relatorio_Jogadores();
            frm.ShowDialog();
        }

        private void RelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio_Utilizadores frm = new Relatorio_Utilizadores();
            frm.ShowDialog();
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
            frm.ShowDialog();
        }

        private void verTorneiosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscolherTorneio frm = new EscolherTorneio();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Torneios frm = new Listar_Torneios();
            frm.ShowDialog();
        }

        private void RelatorioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Relatorio_Torneios frm = new Relatorio_Torneios();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listar_Utilizadores frm = new Listar_Utilizadores();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Listar_Treinadores frm = new Listar_Treinadores();
            frm.ShowDialog();

        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Listar_Jogadores frm = new Listar_Jogadores();
            frm.ShowDialog();

        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Listar_Equipas frm = new Listar_Equipas();
            frm.ShowDialog();
        }

        private void utilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Inserir_Pais frm = new Inserir_Pais();
            frm.ShowDialog();
        }

        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Listar_Pais frm = new Listar_Pais();
            frm.ShowDialog();
        }

    }
}
