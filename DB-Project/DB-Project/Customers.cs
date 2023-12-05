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
    public partial class Customers : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=SKYFALL;Initial Catalog=Project__DB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmd;
        public Customers()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Customers ", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project__DBDataSet7.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.project__DBDataSet7.Customers);
            // TODO: This line of code loads data into the 'project_DBDataSet6.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.project_DBDataSet6.Customers);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommandBuilder(adapter);
            adapter.Update(dt);
            MessageBox.Show("Updated Successfully", "CONFIRM", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
