using HardwareMgmtSystem.lib;
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
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userFrom = new UserForm();
            userFrom.MdiParent = this;
            userFrom.StartPosition = FormStartPosition.CenterScreen;
            userFrom.Show();
        }

        private void tsBtnNewUsers_Click(object sender, EventArgs e)
        {
            UserForm userFrom = new UserForm();
            userFrom.MdiParent = this;
            userFrom.StartPosition = FormStartPosition.CenterScreen;
            userFrom.Show();
            
        }

        

       

        private void tsBtnNewCategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.MdiParent = this;
            category.StartPosition = FormStartPosition.CenterScreen;
            category.Show();
        }

        private void tsBtnNewProducts_ButtonClick(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.MdiParent = this;
            product.StartPosition = FormStartPosition.CenterScreen;
            product.Show();
        }

        private void productCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.MdiParent = this;
            category.StartPosition = FormStartPosition.CenterScreen;
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.MdiParent = this;
            product.StartPosition = FormStartPosition.CenterScreen;
            product.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void tsButtonNewSelling_Click(object sender, EventArgs e)
        {

            SellingForm selling = new SellingForm();
            selling.MdiParent = this;
            selling.StartPosition = FormStartPosition.CenterScreen;
            selling.Show();
        }

        private void newBilltsp_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.MdiParent = this;
            selling.StartPosition = FormStartPosition.CenterScreen;
            selling.Show();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            if (Auth.authUser.Rows[0]["role"].ToString()!="Admin")
            {
                masterToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible=false;
                tsBtnNewUsers.Visible=false;
                tsBtnNewCategory.Visible=false;
                tsBtnNewProducts.Visible=false;
            }
        }

        private void billLineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBillLine reportbill = new ReportBillLine();
            reportbill.MdiParent = this;
            reportbill.StartPosition= FormStartPosition.CenterScreen;
            reportbill.Show();

        }

        private void billsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillTbl bill = new BillTbl();
            bill.MdiParent = this;
            bill.StartPosition = FormStartPosition.CenterScreen;
           bill.Show();
        }
    }
}
