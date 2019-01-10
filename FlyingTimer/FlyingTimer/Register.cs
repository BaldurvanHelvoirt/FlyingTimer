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
    public partial class Register : Form
    {
        Database DB = new Database();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }
        private void RegisterUser()
        {
            DB.RegisterUser(tbUsername.Text, tbPassword.Text, tbFirstname.Text, tbLastname.Text);
            this.Hide();
            Login LG = new Login();
            LG.ShowDialog();
            this.Close();
        }
    }
}
