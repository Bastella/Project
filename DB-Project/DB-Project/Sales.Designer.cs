using System.Data;

namespace DB_Project
{
    partial class Sales
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
            this.projectDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.project_DBDataSet1 = new DB_Project.Project_DBDataSet1();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new DB_Project.Project_DBDataSet1TableAdapters.SalesTableAdapter();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet8 = new DB_Project.Project__DBDataSet8();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter1 = new DB_Project.Project__DBDataSet8TableAdapters.SalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDBDataSetBindingSource
            // 
            this.projectDBDataSetBindingSource.DataSource = this.project_DBDataSet;
            this.projectDBDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.ticketIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // project_DBDataSet1
            // 
            this.project_DBDataSet1.DataSetName = "Project_DBDataSet1";
            this.project_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.project_DBDataSet1;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // project__DBDataSet8
            // 
            this.project__DBDataSet8.DataSetName = "Project__DBDataSet8";
            this.project__DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.project__DBDataSet8;
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource projectDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet1 project_DBDataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private Project_DBDataSet1TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet8 project__DBDataSet8;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private Project__DBDataSet8TableAdapters.SalesTableAdapter salesTableAdapter1;
    }

    internal class Project__DBDataSet8TableAdapters
    {
        internal class SalesTableAdapter
        {
            public SalesTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }

    internal class Project__DBDataSet8
    {
        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        public string DataSetName { get; internal set; }
    }
}