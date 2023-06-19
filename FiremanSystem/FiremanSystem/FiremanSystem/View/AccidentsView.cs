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
using System.Xml.Linq;

namespace FiremanSystem.View
{
    
    public partial class AccidentsView : Form
    {
        AccidentsController controller = new AccidentsController();
        
        public AccidentsView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAccidents.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            controller.DeleteAccident(id);
            RefreshTable();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Accidents accident = new Accidents();
            accident.Name = txtName.Text;
            accident.Day = PDay.Value;
            controller.CreateAccident(accident);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAccidents.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Accidents accident = new Accidents();
            accident.Name = txtName.Text;
            accident.Day = PDay.Value;
            controller.UpdateAccident(id, accident);
            RefreshTable();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
        private void RefreshTable()
        {
            dgvAccidents.DataSource = controller.ReadAllAccidents();
        }

        private void dgvAccidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
