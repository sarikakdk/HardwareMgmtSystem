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
    public partial class UserForm : Form
    {
        Database _database;
        public UserForm()
        {
            Util.restrictFormAccessIfNotLogined(this);
            InitializeComponent();
            _database = new Database("products");
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Populate();
        }
        private void Populate() {
            DataTable dt = _database.ExecuteSelectQuery("select distinct u.id, u.name, u.age,u.phone,u.password,u.email,u.role from users as u");
            DGVUser.DataSource = dt;

        }

       

        private void DGVUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = DGVUser.SelectedRows[0];
                name.Text = row.Cells["name"].Value.ToString();
                userId.Text = row.Cells["id"].Value.ToString();
                age.Text = row.Cells["age"].Value.ToString();
                phone.Text = row.Cells["phone"].Value.ToString();
                password.Text = row.Cells["password"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                cmbRole.Text = row.Cells["row"].Value.ToString();
                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm product = new ProductForm();
            product.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm category = new CategoryForm();
            category.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                try
                {

                    string query = "insert into users(name,age,phone,password,email,role) values('" + name.Text + "','" + age.Text + "','" + phone.Text + "','" + password.Text + "','" + email.Text + "','"+cmbRole.Text+"' )";
                    int rowAffected = _database.ExecuteNonSelectQuery(query);
                    if (rowAffected > 0)
                    {
                        Populate();
                        clear();
                        MessageBox.Show("User successfully inserted");

                    }
                    else
                    {
                        MessageBox.Show("User insert failed");
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
            age.Text = "";
            phone.Text = "";
            password.Text = "";
            email.Text = "";
            userId.Text = "-";
            name.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (userId.Text == "-") throw new Exception("Please select user to update from table");
               
                string query = String.Format("update users set name='{0}', age='{1}',phone='{2}', password='{3}',email='{4}',role={5} where id='{6}'", name.Text, age.Text, phone.Text, password.Text, email.Text,cmbRole.Text);

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
                    MessageBox.Show("Category Update Failed");
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
                if (userId.Text == "-") throw new Exception("Please select user to delete from table");

                string query = String.Format("delete from users where id='{0}' ", userId.Text);
                int rowAffected = _database.ExecuteNonSelectQuery(query);
                if (rowAffected > 0)
                {
                    Populate();
                    clear();
                    MessageBox.Show("User Successfully Deleted");

                }
                else
                {
                    MessageBox.Show("User Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
