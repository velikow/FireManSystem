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
  
    public partial class FireTruckView : Form
    {
        FiretruckController controller = new FiretruckController();
        public FireTruckView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Firetruck firetruck = new Firetruck();
            controller.CreateFiretruck(firetruck);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFireTruck.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Firetruck firetruck = new Firetruck();
            controller.UpdateFiretruck(id, firetruck);
            RefreshTable();
        }
        private void RefreshTable()
        {
            dgvFireTruck.DataSource = controller.ReadAllTrucks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFireTruck.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            controller.DeleteFiretruck(id);
            RefreshTable();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar);
        }
    }
}
