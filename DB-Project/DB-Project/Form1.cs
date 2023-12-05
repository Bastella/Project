using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void routesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Routes route = new Routes();
            route.Show();
        }
        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Station station = new Station();
            station.Show();
        }
        private void trainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains trains = new Trains();
            trains.Show();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
        }

        private void crewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crew crew = new Crew();
            crew.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance maintenance = new Maintenance();
            maintenance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
