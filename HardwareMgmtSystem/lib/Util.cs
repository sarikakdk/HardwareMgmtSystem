using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HardwareMgmtSystem.lib
{
    internal static class Util
    {
        public static void restrictFormAccessIfNotLogined(Form sourceForm)
        {
            if(!Auth.isAuthenticated)
            {
                sourceForm.Hide();
                new LoginForm().Show();

            }
        }
        public static Dictionary<string,string> getNextBillNo()
        {
            string billNo=null;
            int maxbillno=0;
            int nextMaxBillNo=0;
            string sqlQuery = "select isnull(t1.maxbno,0) as maxbillno from (select max(bill_max_no) as maxbno from bills) as t1;";
            DataTable dt=new Database().ExecuteSelectQuery(sqlQuery);
           // MessageBox.Show(dt.Rows[0]["maxbillno"].ToString());
            if (dt.Rows.Count > 0 )
            {
               // MessageBox.Show(dt.Rows[0]["maxbillno"].ToString());
                 maxbillno = int.Parse(dt.Rows[0]["maxbillno"].ToString());
                nextMaxBillNo = maxbillno + 1;
                //MessageBox.Show(maxbillno.ToString());
                billNo = "HMS-"+DateTime.Today.Year+DateTime.Today.Month + DateTime.Today.Day + "-"+ nextMaxBillNo;
               // MessageBox.Show(billNo);
            }
            Dictionary<string,string> billInfo=new Dictionary<string, string>();
            billInfo.Add("nextMaxBillNo",nextMaxBillNo.ToString());
            billInfo.Add("billNo", billNo);


            return billInfo;
        }
    }
}
