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
                MessageBox.Show("Acesso negado", "Erro a fazer login", MessageBoxButtons.OK);
            }
            else
            {
                Menu frm = new Menu();
                frm.Show();
            }

        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            
            

        }

        
    }
}
