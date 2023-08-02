using HardwareMgmtSystem.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem
{
    public partial class LoginForm : Form
    {
        Database _database;
        public LoginForm()
        {

            InitializeComponent();
            _database = new Database("users");
        }
      

        

        private void label2_Click(object sender, EventArgs e)
        {
            email.Text = "";
            password.Text = "";

        }

        public bool validateForm()
        {
            if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role");
                cmbRole.Focus();
                return false;


            }

            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
                email.Focus();
                return false;

            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {

                // MessageBox.Show(Auth.authenticate(email.Text, password.Text, cmbRole.Text).ToString());
                Auth.authenticate(email.Text, password.Text, cmbRole.Text);
                // MessageBox.Show(Auth.isAuthenticated.ToString());
                if (Auth.isAuthenticated)
                {
                    frmApp app = new frmApp();
                    app.Show();
                    this.Hide();
                }
                else
                {

                    throw new Exception("Authentication failed please check login details.");
                    cmbRole.Focus();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           // cmbRole.Text = "Admin";
           // email.Text = "ram@gmail.com";
           // password.Text = "123";
        }
    }
}
    

