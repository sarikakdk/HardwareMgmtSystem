namespace HardwareMgmtSystem
{
    partial class BillTbl
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
            this.newhardware_dbDataSet1 = new HardwareMgmtSystem.newhardware_dbDataSet1();
            this.newhardwaredbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newhardware_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhardwaredbDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.newhardwaredbDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HardwareMgmtSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 385);
            this.reportViewer1.TabIndex = 0;
            // 
            // newhardware_dbDataSet1
            // 
            this.newhardware_dbDataSet1.DataSetName = "newhardware_dbDataSet1";
            this.newhardware_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newhardwaredbDataSet1BindingSource
            // 
            this.newhardwaredbDataSet1BindingSource.DataSource = this.newhardware_dbDataSet1;
            this.newhardwaredbDataSet1BindingSource.Position = 0;
            // 
            // BillTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BillTbl";
            this.Text = "BillTbl";
            this.Load += new System.EventHandler(this.BillTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newhardware_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhardwaredbDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource newhardwaredbDataSet1BindingSource;
        private newhardware_dbDataSet1 newhardware_dbDataSet1;
    }
}