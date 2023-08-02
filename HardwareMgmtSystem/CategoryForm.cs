using HardwareMgmtSystem.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem
{
    public partial class CategoryForm : Form
    {
        Database _database;
        public CategoryForm()
        {
            Util.restrictFormAccessIfNotLogined(this);
            InitializeComponent();
            _database = new Database("categories");
           
        
    }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate()
        {
            DataTable dt = _database.ExecuteSelectQuery("select distinct c.id, c.name, c.description from categories as c");
            DGVcat.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm product = new ProductForm();
            product.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm user = new UserForm();
            user.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  try
            {

                string query = "insert into categories(name,description) values('" + name.Text + "','" + description.Text + "' )";
                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("Category successfully inserted");

                }
                else
                {
                    MessageBox.Show("Category insert failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (catId.Text == "-") throw new Exception("Please select category to update from table");
                // if (lblId.Text == "-") throw new Exception("Please select product to update from table");
                string query = String.Format("update categories set name='{0}', description='{1}' where id='{2}'", name.Text, description.Text,catId.Text);

                // MessageBox.Show(query);
                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("Category successfully updated");

                }
                else
                {
                    MessageBox.Show("Category update failed");
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
            catId.Text = "-";
            name.Focus();
        }

        private void DGVcat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DGVcat.SelectedRows[0];
                name.Text = row.Cells["name"].Value.ToString();
                catId.Text = row.Cells["id"].Value.ToString();
                description.Text = row.Cells["description"].Value.ToString();
               


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
                if (catId.Text == "-") throw new Exception("Please select category to delete from table");

                string query = String.Format("delete from categories where id='{0}' ", catId.Text);
                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("Category successfully updated");

                }
                else
                {
                    MessageBox.Show("Category update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
