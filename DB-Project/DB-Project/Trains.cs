using System;
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
    public partial class Trains : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SKYFALL;Initial Catalog=Project__DB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Trains()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Trains ", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Trains_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project__DBDataSet2.Trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter2.Fill(this.project__DBDataSet2.Trains);
            // TODO: This line of code loads data into the 'project__DBDataSet1.Trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter1.Fill(this.project__DBDataSet1.Trains);
            // TODO: This line of code loads data into the 'project_DBDataSet5.Trains' table. You can move, or remove it, as needed.
            this.trainsTableAdapter.Fill(this.project_DBDataSet5.Trains);

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Updated Successfully", "CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
