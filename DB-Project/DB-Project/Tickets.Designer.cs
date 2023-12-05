using System.Data;

namespace DB_Project
{
    partial class Tickets
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
            this.project_DBDataSet3 = new DB_Project.Project_DBDataSet3();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new DB_Project.Project_DBDataSet3TableAdapters.TicketsTableAdapter();
            this.ticketIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapartureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.project__DBDataSet10 = new DB_Project.Project__DBDataSet10();
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter1 = new DB_Project.Project__DBDataSet10TableAdapters.TicketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIdDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.dapartureTimeDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.seatNumDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.stationIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // project_DBDataSet3
            // 
            this.project_DBDataSet3.DataSetName = "Project_DBDataSet3";
            this.project_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.project_DBDataSet3;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // ticketIdDataGridViewTextBoxColumn
            // 
            this.ticketIdDataGridViewTextBoxColumn.DataPropertyName = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.HeaderText = "TicketId";
            this.ticketIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIdDataGridViewTextBoxColumn.Name = "ticketIdDataGridViewTextBoxColumn";
            this.ticketIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dapartureTimeDataGridViewTextBoxColumn
            // 
            this.dapartureTimeDataGridViewTextBoxColumn.DataPropertyName = "DapartureTime";
            this.dapartureTimeDataGridViewTextBoxColumn.HeaderText = "DapartureTime";
            this.dapartureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapartureTimeDataGridViewTextBoxColumn.Name = "dapartureTimeDataGridViewTextBoxColumn";
            this.dapartureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatNumDataGridViewTextBoxColumn
            // 
            this.seatNumDataGridViewTextBoxColumn.DataPropertyName = "SeatNum";
            this.seatNumDataGridViewTextBoxColumn.HeaderText = "SeatNum";
            this.seatNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatNumDataGridViewTextBoxColumn.Name = "seatNumDataGridViewTextBoxColumn";
            this.seatNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stationIdDataGridViewTextBoxColumn
            // 
            this.stationIdDataGridViewTextBoxColumn.DataPropertyName = "StationId";
            this.stationIdDataGridViewTextBoxColumn.HeaderText = "StationId";
            this.stationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stationIdDataGridViewTextBoxColumn.Name = "stationIdDataGridViewTextBoxColumn";
            this.stationIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // project__DBDataSet10
            // 
            this.project__DBDataSet10.DataSetName = "Project__DBDataSet10";
            this.project__DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.project__DBDataSet10;
            // 
            // ticketsTableAdapter1
            // 
            this.ticketsTableAdapter1.ClearBeforeFill = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project__DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet3 project_DBDataSet3;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private Project_DBDataSet3TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapartureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private Project__DBDataSet10 project__DBDataSet10;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private Project__DBDataSet10TableAdapters.TicketsTableAdapter ticketsTableAdapter1;
    }

    internal class Project__DBDataSet10TableAdapters
    {
        internal class TicketsTableAdapter
        {
            public TicketsTableAdapter()
            {
            }

            public bool ClearBeforeFill { get; internal set; }
        }
    }

    internal class Project__DBDataSet10
    {
        public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        public string DataSetName { get; internal set; }
    }
}