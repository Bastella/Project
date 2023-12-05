using System.Data;

namespace DB_Project
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DB_Project.Project__DBDataSet5 project__DBDataSet52 = new DB_Project.Project__DBDataSet5();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet6 = new DB_Project.Project_DBDataSet6();
            this.customersTableAdapter = new DB_Project.Project_DBDataSet6TableAdapters.CustomersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project__DBDataSet7 = new DB_Project.Project__DBDataSet7();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter2 = new DB_Project.Project__DBDataSet7TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.customersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = project__DBDataSet52;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.project_DBDataSet6;
            // 
            // project_DBDataSet6
            // 
            this.project_DBDataSet6.DataSetName = "Project_DBDataSet6";
            this.project_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "ContactNum";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // project__DBDataSet7
            // 
            this.project__DBDataSet7.DataSetName = "Project__DBDataSet7";
            this.project__DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.project__DBDataSet7;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet6 project_DBDataSet6;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Project_DBDataSet6TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet5 project__DBDataSet5;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private Project__DBDataSet5TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Project__DBDataSet7 project__DBDataSet7;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private Project__DBDataSet7TableAdapters.CustomersTableAdapter customersTableAdapter2;
    }

    internal class Project__DBDataSet5
    {
        public Project__DBDataSet5()
        {
        }

        public string DataSetName { get; internal set; }
        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
    }

    internal class Project__DBDataSet5TableAdapters
    {
        internal class CustomersTableAdapter
        {
            public CustomersTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }
}