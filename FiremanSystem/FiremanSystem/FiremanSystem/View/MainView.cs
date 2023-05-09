﻿using FiremanSystem.Controller;
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
    public partial class MainView : Form
    {
        FiremanController controller = new FiremanController();
        public MainView()
        {
            InitializeComponent();
        }

        private void btnFireMan_Click(object sender, EventArgs e)
        {
            FireManView m = new FireManView();
            this.Hide();
            m.Show();
        }

        private void btnFireTruck_Click(object sender, EventArgs e)
        {
            FireTruckView  m = new FireTruckView();
            this.Hide();
            m.Show();
        }

        private void btnAccidents_Click(object sender, EventArgs e)
        {
            AccidentsView m = new AccidentsView();
            this.Hide();
            m.Show();
        }
    }
}
