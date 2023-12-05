namespace DB_Project
{
    partial class Routes
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
            this.project_DBDataSet = new DB_Project.Project_DBDataSet();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new DB_Project.Project_DBDataSetTableAdapters.RoutesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.routeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.project_DBDataSet;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routeIdDataGridViewTextBoxColumn1,
            this.routeNameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.routesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1051, 341);
            this.dataGridView2.TabIndex = 1;
            // 
            // routeIdDataGridViewTextBoxColumn1
            // 
            this.routeIdDataGridViewTextBoxColumn1.DataPropertyName = "RouteId";
            this.routeIdDataGridViewTextBoxColumn1.HeaderText = "RouteId";
            this.routeIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.routeIdDataGridViewTextBoxColumn1.Name = "routeIdDataGridViewTextBoxColumn1";
            this.routeIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // routeNameDataGridViewTextBoxColumn1
            // 
            this.routeNameDataGridViewTextBoxColumn1.DataPropertyName = "RouteName";
            this.routeNameDataGridViewTextBoxColumn1.HeaderText = "RouteName";
            this.routeNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.routeNameDataGridViewTextBoxColumn1.Name = "routeNameDataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Routes";
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private Project_DBDataSetTableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}