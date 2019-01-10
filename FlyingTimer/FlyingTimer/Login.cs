using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingTimer
{
    public partial class Login : Form
    {
        Database DB = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DB.CheckLogin(tbUsername.Text, tbPassword.Text))
            {
                this.Hide();
                FlyingTimer FT = new FlyingTimer();
                FT.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Het ingevulde gebruikersnaam of wachtwoord is niet correct");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register RE = new Register();
            RE.ShowDialog();
            this.Close();
        }
    }
}
