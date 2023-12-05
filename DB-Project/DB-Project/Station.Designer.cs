namespace DB_Project
{
    partial class Station
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
            this.project_DBDataSet4 = new DB_Project.Project_DBDataSet4();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new DB_Project.Project_DBDataSet4TableAdapters.StationTableAdapter();
            this.stationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet9 = new DB_Project.Project__DBDataSet1();
            this.stationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter1 = new DB_Project.Project__DBDataSet1TableAdapters.StationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stationIdDataGridViewTextBoxColumn,
            this.stationNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn,
            this.routeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // project_DBDataSet4
            // 
            this.project_DBDataSet4.DataSetName = "Project_DBDataSet4";
            this.project_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.project_DBDataSet4;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // stationIdDataGridViewTextBoxColumn
            // 
            this.stationIdDataGridViewTextBoxColumn.DataPropertyName = "StationId";
            this.stationIdDataGridViewTextBoxColumn.HeaderText = "StationId";
            this.stationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationIdDataGridViewTextBoxColumn.Name = "stationIdDataGridViewTextBoxColumn";
            this.stationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stationNameDataGridViewTextBoxColumn
            // 
            this.stationNameDataGridViewTextBoxColumn.DataPropertyName = "StationName";
            this.stationNameDataGridViewTextBoxColumn.HeaderText = "StationName";
            this.stationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationNameDataGridViewTextBoxColumn.Name = "stationNameDataGridViewTextBoxColumn";
            this.stationNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Zone";
            this.zoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeIdDataGridViewTextBoxColumn
            // 
            this.routeIdDataGridViewTextBoxColumn.DataPropertyName = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.HeaderText = "RouteId";
            this.routeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.routeIdDataGridViewTextBoxColumn.Name = "routeIdDataGridViewTextBoxColumn";
            this.routeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // project__DBDataSet9
            // 
            this.project__DBDataSet9.DataSetName = "Project__DBDataSet9";
            this.project__DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource1
            // 
            this.stationBindingSource1.DataMember = "Station";
            this.stationBindingSource1.DataSource = this.project__DBDataSet9;
            // 
            // stationTableAdapter1
            // 
            this.stationTableAdapter1.ClearBeforeFill = true;
            // 
            // Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Station";
            this.Text = "Station";
            this.Load += new System.EventHandler(this.Station_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet4 project_DBDataSet4;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private Project_DBDataSet4TableAdapters.StationTableAdapter stationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet1 project__DBDataSet9;
        private System.Windows.Forms.BindingSource stationBindingSource1;
        private Project__DBDataSet1TableAdapters.StationTableAdapter stationTableAdapter1;
    }
}