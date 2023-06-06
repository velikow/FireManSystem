using FiremanSystem.Controller;
using FiremanSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiremanSystem.View
{
    public partial class RegisterView : Form
    {
        FiremanController controller = new FiremanController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }

            Fireman fireman = new Fireman();
            fireman.Username = username;
            fireman.Password = password;
            controller.CreateFireman(fireman);
            LoginView m = new LoginView();
            this.Hide();
            m.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginView m = new LoginView();
            this.Hide();
            m.Show();

        }
    }
}
