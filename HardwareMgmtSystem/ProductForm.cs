using HardwareMgmtSystem.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem
{
    public partial class ProductForm : Form
    {
        Database _database;
        public ProductForm()
        {
            Util.restrictFormAccessIfNotLogined(this);
            InitializeComponent();
            _database=new Database("products");
        }
          

        private void ProductForm_Load(object sender, EventArgs e)
        {
            Populate();
            fillcombo();

        }
        private void Populate()
        {
            DataTable dt = _database.ExecuteSelectQuery("select distinct p.category_id, c.name as category_name,p.id, p.name, p.description,p.price,p.qty from products as p, categories as c where p.category_id=c.id");
            DGVprod.DataSource = dt;
        

        }
        private void fillcombo()
        {
            
            DataTable dt = _database.selectRecordAsKeyValue("id", "name","categories");
            //this method will bind the combobox with database
            cmbCategory.ValueMember = "id";
            cmbCategory.DisplayMember = "name";
            cmbCategory.DataSource = dt;
          
            //MessageBox.Show(dt.Rows[0]["name"].ToString());
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm user = new UserForm();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm category = new CategoryForm();
            category.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "insert into products(category_id,name,description,price,qty) values('" + cmbCategory.SelectedValue + "','" + name.Text + "','" + description.Text + "','" + price.Text + "','" + qty.Text +"' )";
                int rowAffected=_database.ExecuteNonSelectQuery(query);
                if(rowAffected>0)
                {
                    Populate();
                    MessageBox.Show("Product successfully inserted");

                }
                else
                {
                    MessageBox.Show("Product insert failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Catcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "-") throw new Exception("Please select product to update from table");
                string query = String.Format("update products set category_id='{0}', name='{1}', description='{2}', price='{3}', qty='{4}' where id='{5}' ",cmbCategory.SelectedValue.ToString(),name.Text,description.Text,price.Text,qty.Text,lblId.Text);

               // MessageBox.Show(query);
                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("Product successfully updated");

                }
                else
                {
                    MessageBox.Show("Product update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "-") throw new Exception("Please select product to delete from table");

                string query = String.Format("delete from products where id='{0}' ", lblId.Text);


                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("Product successfully updated");

                }
                else
                {
                    MessageBox.Show("Product update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            name.Text = "";
            description.Text = "";
            price.Text = "";
            qty.Text = "";
            lblId.Text = "-";
            name.Focus();
        }

     

        private void DGVprod_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DGVprod.SelectedRows[0];
                name.Text = row.Cells["name"].Value.ToString();
                description.Text = row.Cells["description"].Value.ToString();
                price.Text = row.Cells["price"].Value.ToString();
                qty.Text = row.Cells["qty"].Value.ToString();
                lblId.Text = row.Cells["id"].Value.ToString();
                cmbCategory.SelectedValue = row.Cells["category_id"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
