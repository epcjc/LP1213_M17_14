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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int res;
            res = (int)this.utilizadoresTableAdapter.CheckLogin(this.textBox1.Text, this.textBox3.Text);

            if (res != 1)
            {
                textBox3.Text = "";
                MessageBox.Show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);
            }
            else
            {

                this.Hide();
                Menu frm = new Menu();
                frm.Show();
                
            }

        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Não pode ser vazio !!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Não pode ser vazio !!");
            }
        }

        private void Login_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }

        
    }
}
