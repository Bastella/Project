using System.Data;

namespace DB_Project
{
    partial class Maintenance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.project_DBDataSet7 = new DB_Project.Project_DBDataSet7();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter = new DB_Project.Project_DBDataSet7TableAdapters.MaintenanceTableAdapter();
            this.maintenanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet6 = new DB_Project.Project__DBDataSet6();
            this.maintenanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter1 = new DB_Project.Project__DBDataSet6TableAdapters.MaintenanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maintenanceIdDataGridViewTextBoxColumn,
            this.maintenanceTypeDataGridViewTextBoxColumn,
            this.maintenanceDateDataGridViewTextBoxColumn,
            this.trainIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maintenanceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // project_DBDataSet7
            // 
            this.project_DBDataSet7.DataSetName = "Project_DBDataSet7";
            this.project_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataMember = "Maintenance";
            this.maintenanceBindingSource.DataSource = this.project_DBDataSet7;
            // 
            // maintenanceTableAdapter
            // 
            this.maintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // maintenanceIdDataGridViewTextBoxColumn
            // 
            this.maintenanceIdDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceId";
            this.maintenanceIdDataGridViewTextBoxColumn.HeaderText = "MaintenanceId";
            this.maintenanceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceIdDataGridViewTextBoxColumn.Name = "maintenanceIdDataGridViewTextBoxColumn";
            this.maintenanceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.maintenanceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceTypeDataGridViewTextBoxColumn
            // 
            this.maintenanceTypeDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.HeaderText = "MaintenanceType";
            this.maintenanceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceTypeDataGridViewTextBoxColumn.Name = "maintenanceTypeDataGridViewTextBoxColumn";
            this.maintenanceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // maintenanceDateDataGridViewTextBoxColumn
            // 
            this.maintenanceDateDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.HeaderText = "MaintenanceDate";
            this.maintenanceDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maintenanceDateDataGridViewTextBoxColumn.Name = "maintenanceDateDataGridViewTextBoxColumn";
            this.maintenanceDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainIdDataGridViewTextBoxColumn
            // 
            this.trainIdDataGridViewTextBoxColumn.DataPropertyName = "TrainId";
            this.trainIdDataGridViewTextBoxColumn.HeaderText = "TrainId";
            this.trainIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainIdDataGridViewTextBoxColumn.Name = "trainIdDataGridViewTextBoxColumn";
            this.trainIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // project__DBDataSet6
            // 
            this.project__DBDataSet6.DataSetName = "Project__DBDataSet6";
            this.project__DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceBindingSource1
            // 
            this.maintenanceBindingSource1.DataMember = "Maintenance";
            this.maintenanceBindingSource1.DataSource = this.project__DBDataSet6;
            // 
            // maintenanceTableAdapter1
            // 
            this.maintenanceTableAdapter1.ClearBeforeFill = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet7 project_DBDataSet7;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private Project_DBDataSet7TableAdapters.MaintenanceTableAdapter maintenanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet6 project__DBDataSet6;
        private System.Windows.Forms.BindingSource maintenanceBindingSource1;
        private Project__DBDataSet6TableAdapters.MaintenanceTableAdapter maintenanceTableAdapter1;
    }

    internal class Project__DBDataSet6TableAdapters
    {
        internal class MaintenanceTableAdapter
        {
            public MaintenanceTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }

    internal class Project__DBDataSet6
    {
        public string DataSetName { get; internal set; }
        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
    }
}