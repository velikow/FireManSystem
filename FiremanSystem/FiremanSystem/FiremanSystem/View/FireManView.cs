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
        AccidentsParticipantsController accidentsParticipantscontroller = new AccidentsParticipantsController();
        public FireManView()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFireMan.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Fireman fireman = new Fireman();
            fireman.Username = txtUsername.Text;
            fireman.Password = txtPassword.Text;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Fireman fireman = new Fireman();
            fireman.Username = txtUsername.Text;
            fireman.Password = txtPassword.Text;
            controller.CreateFireman(fireman);
            RefreshTable();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccidentsParticipants accidentsParticipants = new AccidentsParticipants();
            accidentsParticipants.AccidentsId = int.Parse(accidentidtxt.Text);
            List<Fireman> list = controller.ReadAllFireman();
            Fireman temp = new Fireman();
            foreach (var i in list)
            {
                if (i.Username == txtUsername.Text && i.Password == txtPassword.Text)
                {
                    temp = i;
                }
            }
            if (temp != null)
            {
                accidentsParticipants.ParticipantsId = temp.Id;
            }
            else
            {
                //nqkuv error
            }
            accidentsParticipantscontroller.CreateAccident(accidentsParticipants);
        }

        private void ReadAccidentsbtn_Click(object sender, EventArgs e)
        {
            List<AccidentsParticipants> accidentsList = accidentsParticipantscontroller.ReadAllAccidents();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var i in accidentsList)
            {
                if (dictionary.ContainsKey(i.ParticipantsId))
                {
                    dictionary[i.ParticipantsId]++;
                }
                else
                {
                    dictionary.Add(i.ParticipantsId, 1);
                }
            }
            var sortedDict = from entry in dictionary orderby entry.Value ascending select entry;
            
        }
    }
}
