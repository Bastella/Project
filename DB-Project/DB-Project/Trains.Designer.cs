namespace DB_Project
{
    partial class Trains
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
            this.project_DBDataSet5 = new DB_Project.Project_DBDataSet5();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new DB_Project.Project_DBDataSet5TableAdapters.TrainsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.routeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.project__DBDataSet1 = new DB_Project.Project__DBDataSet1();
            this.trainsTableAdapter1 = new DB_Project.Project__DBDataSet1TableAdapters.TrainsTableAdapter();
            this.project__DBDataSet2 = new DB_Project.Project__DBDataSet2();
            this.trainsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter2 = new DB_Project.Project__DBDataSet2TableAdapters.TrainsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // project_DBDataSet5
            // 
            this.project_DBDataSet5.DataSetName = "Project_DBDataSet5";
            this.project_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "Trains";
            this.trainsBindingSource.DataSource = this.project_DBDataSet5;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainIdDataGridViewTextBoxColumn,
            this.trainNameDataGridViewTextBoxColumn,
            this.seatsDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn,
            this.routeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(270, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 235);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainIdDataGridViewTextBoxColumn
            // 
            this.trainIdDataGridViewTextBoxColumn.DataPropertyName = "TrainId";
            this.trainIdDataGridViewTextBoxColumn.HeaderText = "TrainId";
            this.trainIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainIdDataGridViewTextBoxColumn.Name = "trainIdDataGridViewTextBoxColumn";
            this.trainIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainNameDataGridViewTextBoxColumn
            // 
            this.trainNameDataGridViewTextBoxColumn.DataPropertyName = "TrainName";
            this.trainNameDataGridViewTextBoxColumn.HeaderText = "TrainName";
            this.trainNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainNameDataGridViewTextBoxColumn.Name = "trainNameDataGridViewTextBoxColumn";
            this.trainNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatsDataGridViewTextBoxColumn
            // 
            this.seatsDataGridViewTextBoxColumn.DataPropertyName = "Seats";
            this.seatsDataGridViewTextBoxColumn.HeaderText = "Seats";
            this.seatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatsDataGridViewTextBoxColumn.Name = "seatsDataGridViewTextBoxColumn";
            this.seatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "Type";
            this.typeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // routeIdDataGridViewTextBoxColumn
            // 
            this.routeIdDataGridViewTextBoxColumn.DataPropertyName = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.HeaderText = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIdDataGridViewTextBoxColumn.Name = "routeIdDataGridViewTextBoxColumn";
            this.routeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainsBindingSource1
            // 
            this.trainsBindingSource1.DataMember = "Trains";
            this.trainsBindingSource1.DataSource = this.project__DBDataSet1;
            // 
            // project__DBDataSet1
            // 
            this.project__DBDataSet1.DataSetName = "Project__DBDataSet1";
            this.project__DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsTableAdapter1
            // 
            this.trainsTableAdapter1.ClearBeforeFill = true;
            // 
            // project__DBDataSet2
            // 
            this.project__DBDataSet2.DataSetName = "Project__DBDataSet2";
            this.project__DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainsBindingSource2
            // 
            this.trainsBindingSource2.DataMember = "Trains";
            this.trainsBindingSource2.DataSource = this.project__DBDataSet2;
            // 
            // trainsTableAdapter2
            // 
            this.trainsTableAdapter2.ClearBeforeFill = true;
            // 
            // Trains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Trains";
            this.Text = "Trains";
            this.Load += new System.EventHandler(this.Trains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Project_DBDataSet5 project_DBDataSet5;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private Project_DBDataSet5TableAdapters.TrainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Project__DBDataSet1 project__DBDataSet1;
        private System.Windows.Forms.BindingSource trainsBindingSource1;
        private Project__DBDataSet1TableAdapters.TrainsTableAdapter trainsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn;
        private Project__DBDataSet2 project__DBDataSet2;
        private System.Windows.Forms.BindingSource trainsBindingSource2;
        private Project__DBDataSet2TableAdapters.TrainsTableAdapter trainsTableAdapter2;
    }
}