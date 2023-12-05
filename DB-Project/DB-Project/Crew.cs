﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Project
{
    public partial class Crew : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SKYFALL;Initial Catalog=Project__DB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Crew()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Crew ", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Crew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet2.Crew' table. You can move, or remove it, as needed.
            this.crewTableAdapter.Fill(this.project_DBDataSet2.Crew);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Updated Successfully", "CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
