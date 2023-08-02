namespace HardwareMgmtSystem
{
    partial class ReportBillLine
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.newhardware_dbDataSet = new HardwareMgmtSystem.newhardware_dbDataSet();
            this.newhardwaredbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billlineitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_line_itemsTableAdapter = new HardwareMgmtSystem.newhardware_dbDataSetTableAdapters.bill_line_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.newhardware_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhardwaredbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.billlineitemsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HardwareMgmtSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // newhardware_dbDataSet
            // 
            this.newhardware_dbDataSet.DataSetName = "newhardware_dbDataSet";
            this.newhardware_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newhardwaredbDataSetBindingSource
            // 
            this.newhardwaredbDataSetBindingSource.DataSource = this.newhardware_dbDataSet;
            this.newhardwaredbDataSetBindingSource.Position = 0;
            // 
            // billlineitemsBindingSource
            // 
            this.billlineitemsBindingSource.DataMember = "bill_line_items";
            this.billlineitemsBindingSource.DataSource = this.newhardwaredbDataSetBindingSource;
            // 
            // bill_line_itemsTableAdapter
            // 
            this.bill_line_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBillLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBillLine";
            this.Text = "ReportBillLine";
            this.Load += new System.EventHandler(this.ReportBillLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newhardware_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhardwaredbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineitemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private newhardware_dbDataSet newhardware_dbDataSet;
        private System.Windows.Forms.BindingSource newhardwaredbDataSetBindingSource;
        private System.Windows.Forms.BindingSource billlineitemsBindingSource;
        private newhardware_dbDataSetTableAdapters.bill_line_itemsTableAdapter bill_line_itemsTableAdapter;
    }
}