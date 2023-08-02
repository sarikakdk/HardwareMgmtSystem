using HardwareMgmtSystem.lib;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HardwareMgmtSystem
{
    public partial class SellingForm : Form
    {
        Database _database;
        Dictionary<string, string> billInfo;
        public SellingForm()
        {
            Util.restrictFormAccessIfNotLogined(this);
            InitializeComponent();
            _database = new Database("");
        }
        private void fillcombo()
        {

            DataTable dt = _database.selectRecordAsKeyValue("id", "name", "categories");
           cmbCategory.ValueMember = "id";
            cmbCategory.DisplayMember = "name";
            cmbCategory.DataSource = dt;
            

        }
        private void fillcombo2(String categoryId)
        {
            DataTable dt = _database.selectRecordAsKeyValue("id","name","products","category_id",categoryId.ToString());
            cmbProducts.ValueMember = "id";
            cmbProducts.DisplayMember = "name";
           cmbProducts.DataSource = dt;
           


        }
        
        private void fillcombo3( )
        {
            try
            {
                int selectedValueId = Convert.ToInt32(cmbProducts.SelectedValue);
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=newhardware_db;Integrated Security=True" ))
                {
                    string query = "SELECT price from products where id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", selectedValueId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        product_price.Text = dt.Rows[0]["price"].ToString();
                    }
                    else
                    {
                        product_price.Text = "No Data Found";
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void setUpNewBill()
        {
            Clear();
             billInfo= Util.getNextBillNo();
            billno.Text = billInfo["billNo"];

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            setUpNewBill();
            fillcombo();

            bill_date.Text = DateTime.Today.Month.ToString() + " / " + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        

        private void clear_Click(object sender, EventArgs e)
        {
            setUpNewBill();
        }
        private void Clear()
        {
            DGVsales.Rows.Clear();
            DGVsales.Refresh();
            
          
            customer_name.Text = "";
            totalAmt.Text = "";
            discper.Text = "";
            discountGiven.Text = "";
            net_total.Text = "";
            
           
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcombo2(cmbCategory.SelectedValue.ToString());

        }
       

        private void bill_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into bills(user_id,user_name,customer_name,bill_date,total,discount,net_total,billno,bill_max_no) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
               Auth.authUser.Rows[0]["id"], Auth.authUser.Rows[0]["name"], customer_name.Text,
               bill_date.Text, totalAmt.Text, discountGiven.Text, net_total.Text, billno.Text, billInfo["nextMaxBillNo"]);
                //customer_name.Text = query;
                int insertId = _database.ExecuteNonSelectQuery(query, true);

                if (insertId > 0)
                {
                    // MessageBox.Show("Insert Id:"+insertId.ToString());
                    insertBillLineItemsFromDgv(insertId);
                    Clear();
                    MessageBox.Show("Bill successfully created");

                }
                else
                {
                    MessageBox.Show("Bill creation failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("eror" + ex);
            }
           
        }

        private void insertBillLineItemsFromDgv(int billId)
        {
            var dgvRows = DGVsales.Rows;
            foreach (DataGridViewRow row in dgvRows)
            {
                string prodQty= row.Cells["qty"].Value.ToString();
                string productId = row.Cells["product_id"].Value.ToString();
                //MessageBox.Show("productid:" + row.Cells["product_id"].ToString(), "bill_id:" +billId);
                string dgvRowQuery = string.Format("insert into bill_line_items(bill_id,product_id,product_name,price,qty,total) values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    billId, productId, row.Cells["product_name"].Value.ToString(), row.Cells["price"].Value.ToString(), prodQty, row.Cells["total"].Value.ToString());

                //customer_name.Text = dgvRowQuery;
                _database.ExecuteNonSelectQuery(dgvRowQuery);
                decreaseProductStockBy(productId,prodQty);
            }

        }

        private void decreaseProductStockBy(string productId,string productQty)
        {
            DataTable dt = _database.ExecuteSelectQuery("select qty from products where id=" + productId);
            if(dt.Rows.Count > 0)
            {
                int currentStock = int.Parse(dt.Rows[0]["qty"].ToString());
                int qty = int.Parse(productQty);
                string newStock = (currentStock - qty).ToString();

                _database.ExecuteNonSelectQuery("update products set qty='" + newStock + "' where id='"+ productId+"'");
            }

        }
        

        private void product_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcombo3();

        }
        Decimal Grdtotal = 0, n = 0;

        private void discper_TextChanged(object sender, EventArgs e)
        {
            if (totalAmt.Text.Length<1)
            {
               // MessageBox.Show("Missing Data");
                return;
            }
            double netTot,discount, disPer, totAmt = double.Parse(totalAmt.Text);
            if(discper.Text.Length<1)
            {
                discper.Text = "0";
                return;
            }
            disPer= double.Parse(discper.Text);



            discount = (totAmt * disPer) / 100;
            netTot = totAmt - discount;
            discountGiven.Text = discount.ToString();

            net_total.Text=netTot.ToString();
            

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (cmbCategory.Text == " " || product_qty.Text == " ")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
               decimal total = Convert.ToDecimal(product_price.Text) * Convert.ToDecimal(product_qty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVsales);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = cmbProducts.Text;
                newRow.Cells[2].Value = product_price.Text;
                newRow.Cells[3].Value = product_qty.Text;
                newRow.Cells[4].Value = Convert.ToDecimal(product_price.Text) * Convert.ToDecimal(product_qty.Text);
                newRow.Cells[5].Value = billno.Text;
               newRow.Cells[6].Value = cmbProducts.SelectedValue.ToString();
               

                DGVsales.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                totalAmt.Text = Grdtotal.ToString();
            }
            


        }
    }
}
