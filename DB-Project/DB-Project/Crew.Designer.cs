using System.Data;

namespace DB_Project
{
    partial class Crew
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
            this.project_DBDataSet2 = new DB_Project.Project_DBDataSet2();
            this.crewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewTableAdapter = new DB_Project.Project_DBDataSet2TableAdapters.CrewTableAdapter();
            this.crewIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet4 = new DB_Project.Project__DBDataSet4();
            this.crewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crewTableAdapter1 = new DB_Project.Project__DBDataSet4TableAdapters.CrewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crewIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.professionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crewBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // project_DBDataSet2
            // 
            this.project_DBDataSet2.DataSetName = "Project_DBDataSet2";
            this.project_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewBindingSource
            // 
            this.crewBindingSource.DataMember = "Crew";
            this.crewBindingSource.DataSource = this.project_DBDataSet2;
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // crewIdDataGridViewTextBoxColumn
            // 
            this.crewIdDataGridViewTextBoxColumn.DataPropertyName = "CrewId";
            this.crewIdDataGridViewTextBoxColumn.HeaderText = "CrewId";
            this.crewIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crewIdDataGridViewTextBoxColumn.Name = "crewIdDataGridViewTextBoxColumn";
            this.crewIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.crewIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // project__DBDataSet4
            // 
            this.project__DBDataSet4.DataSetName = "Project__DBDataSet4";
            this.project__DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewBindingSource1
            // 
            this.crewBindingSource1.DataMember = "Crew";
            this.crewBindingSource1.DataSource = this.project__DBDataSet4;
            // 
            // crewTableAdapter1
            // 
            this.crewTableAdapter1.ClearBeforeFill = true;
            // 
            // Crew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Crew";
            this.Text = "Crew";
            this.Load += new System.EventHandler(this.Crew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet2 project_DBDataSet2;
        private System.Windows.Forms.BindingSource crewBindingSource;
        private Project_DBDataSet2TableAdapters.CrewTableAdapter crewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet4 project__DBDataSet4;
        private System.Windows.Forms.BindingSource crewBindingSource1;
        private Project__DBDataSet4TableAdapters.CrewTableAdapter crewTableAdapter1;
    }

    internal class Project__DBDataSet4TableAdapters
    {
        internal class CrewTableAdapter
        {
            public CrewTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }

    internal class Project__DBDataSet4
    {
        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        public string DataSetName { get; internal set; }
    }
}