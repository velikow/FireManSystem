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
            firetruck.Monday = checkbox1.Checked;
            firetruck.Tuesday = checkBox2.Checked;
            firetruck.Wednesday = checkBox3.Checked;
            firetruck.Thursday = checkBox4.Checked;
            firetruck.Friday = checkBox5.Checked;
            firetruck.Saturday = checkBox6.Checked;
            firetruck.Sunday = checkBox7.Checked;
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
            dgvFireTruck.DataSource = controller.ReadAllTrucks(checkbox1.Checked,checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked, checkBox7.Checked);
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

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void FireTruckView_Load(object sender, EventArgs e)
        {

        }
    }
}
