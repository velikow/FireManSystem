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
    public partial class FireManView : Form
    {
        FiremanController controller = new FiremanController();
        public FireManView()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFireMan.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Fireman fireman = new Fireman();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            controller.UpdateFireman(id, fireman);
            RefreshTable();
        }
        private void RefreshTable()
        {
            dgvFireMan.DataSource = controller.ReadAllFireman();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFireMan.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            controller.DeleteFireman(id);
            RefreshTable();
        }
    }
}
