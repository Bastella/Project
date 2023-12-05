using System.Data;

namespace DB_Project
{
    partial class Attendance
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
            this.project_DBDataSet8 = new DB_Project.Project_DBDataSet8();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new DB_Project.Project_DBDataSet8TableAdapters.AttendanceTableAdapter();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet3 = new DB_Project.Project__DBDataSet3();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter1 = new DB_Project.Project__DBDataSet3TableAdapters.AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.assignDateDataGridViewTextBoxColumn,
            this.crewIdDataGridViewTextBoxColumn,
            this.trainIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // project_DBDataSet8
            // 
            this.project_DBDataSet8.DataSetName = "Project_DBDataSet8";
            this.project_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.project_DBDataSet8;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignDateDataGridViewTextBoxColumn
            // 
            this.assignDateDataGridViewTextBoxColumn.DataPropertyName = "AssignDate";
            this.assignDateDataGridViewTextBoxColumn.HeaderText = "AssignDate";
            this.assignDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignDateDataGridViewTextBoxColumn.Name = "assignDateDataGridViewTextBoxColumn";
            this.assignDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // crewIdDataGridViewTextBoxColumn
            // 
            this.crewIdDataGridViewTextBoxColumn.DataPropertyName = "CrewId";
            this.crewIdDataGridViewTextBoxColumn.HeaderText = "CrewId";
            this.crewIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crewIdDataGridViewTextBoxColumn.Name = "crewIdDataGridViewTextBoxColumn";
            this.crewIdDataGridViewTextBoxColumn.Width = 125;
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
            this.button1.Location = new System.Drawing.Point(416, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // project__DBDataSet3
            // 
            this.project__DBDataSet3.DataSetName = "Project__DBDataSet3";
            this.project__DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.project__DBDataSet3;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet8 project_DBDataSet8;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Project_DBDataSet8TableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet3 project__DBDataSet3;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private Project__DBDataSet3TableAdapters.AttendanceTableAdapter attendanceTableAdapter1;
    }

    internal class Project__DBDataSet3TableAdapters
    {
        internal class AttendanceTableAdapter
        {
            public AttendanceTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }

    internal class Project__DBDataSet3
    {
        public Project__DBDataSet3()
        {
        }

        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        public string DataSetName { get; internal set; }
    }
}