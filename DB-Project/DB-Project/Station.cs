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
    public partial class Station : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SKYFALL;Initial Catalog=Project__DB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Station()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Station ", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Station_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet4.Station' table. You can move, or remove it, as needed.
            this.stationTableAdapter.Fill(this.project_DBDataSet4.Station);

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Updated Successfully", "CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
