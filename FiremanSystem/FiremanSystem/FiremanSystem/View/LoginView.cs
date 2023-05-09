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
    public partial class LoginView : Form
    {
        FiremanController controller = new FiremanController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var fireman = controller.ReadAllFireman();
            bool isValidUser = false;
            bool isValidPass = false;
            foreach (var u in fireman)
            {
                if (username == u.Username)
                {
                    isValidUser = true;
                    if (password == u.Password)
                    {
                        isValidPass = true;
                    }

                }
            }
            if (isValidUser)
            {
                if (isValidPass)
                {
                    MainView m = new MainView();
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("WRONG PASSWORD");
                }
            }
            else
            {
                MessageBox.Show("WRONG USERNAME");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterView m = new RegisterView();
            this.Hide();
            m.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
