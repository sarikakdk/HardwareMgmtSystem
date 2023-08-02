using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem
{
    public partial class ReportBillLine : Form
    {
        public ReportBillLine()
        {
            InitializeComponent();
        }

        private void ReportBillLine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newhardware_dbDataSet.bill_line_items' table. You can move, or remove it, as needed.
            this.bill_line_itemsTableAdapter.Fill(this.newhardware_dbDataSet.bill_line_items);

            this.reportViewer1.RefreshReport();
        }
    }
}
