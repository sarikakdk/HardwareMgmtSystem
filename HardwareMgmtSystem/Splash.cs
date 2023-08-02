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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;




        private void Splash_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer2.Stop();
                LoginForm log = new LoginForm();
                this.Hide();
                log.Show();
            }
        }
    }
}
    

