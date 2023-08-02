using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem.lib
{
    internal static class Auth
    {
        public static bool isAuthenticated=false;
        public static DataTable authUser;
        public static Database db;

       

        public static bool authenticate(String email, String password, String role)
        {
            
            db= new Database();
            string authQ = String.Format("select * from users where email='{0}' and password='{1}' and role='{2}' ", email, password, role);
            //MessageBox.Show(authQ);
            DataTable dt = db.ExecuteSelectQuery(authQ);
            //MessageBox.Show(dt.Rows.Count+"---"+dt.Rows[0]["email"].ToString());
            if(dt.Rows.Count  > 0 )
            {
                isAuthenticated = true;
                authUser = dt;
               
            }
            return isAuthenticated;  
        }
    }
}
