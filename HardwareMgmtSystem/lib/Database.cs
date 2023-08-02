using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMgmtSystem.lib
{
    internal class Database
    {
        private String _connectionString = "Data Source=DESKTOP-QI6H2EA\\SQLEXPRESS;Initial Catalog=newhardware_db;Integrated Security=True";
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private String _tablename;
        
        public Database()
        {
            _conn = new SqlConnection(this._connectionString);
           
          

        }
        public Database(String tableName)
        {
            this._tablename = tableName;
            _conn = new SqlConnection(this._connectionString);
           

        }

        public int ExecuteNonSelectQuery(string nonSelectSqlQuery,bool returnInsertId=false)
        {
            int rowAffected=0,insertId=0;
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            _cmd =_conn.CreateCommand();
           _cmd.CommandType = CommandType.Text;
          
          
            if(returnInsertId)
            {
               // MessageBox.Show(nonSelectSqlQuery + ";SELECT scope_identity() AS insertId");
                
                _cmd.CommandText = nonSelectSqlQuery+ "; SELECT SCOPE_IDENTITY()";
               
                insertId =int.Parse(_cmd.ExecuteScalar().ToString());
                if (_conn.State == ConnectionState.Open) _conn.Close();
                return insertId;
            }
            else
            {
                _cmd.CommandText = nonSelectSqlQuery;
                rowAffected = _cmd.ExecuteNonQuery();
                if (_conn.State == ConnectionState.Open) _conn.Close();
                return rowAffected;
            }

          
        }

        public DataTable ExecuteSelectQuery(string selectSqlQuery)
        {

           if(_conn.State==ConnectionState.Closed) _conn.Open();
            _cmd = _conn.CreateCommand();
            _cmd.CommandType = CommandType.Text;
            _cmd.CommandText = selectSqlQuery;
            _cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            da.Fill(dt);
            if (_conn.State == ConnectionState.Open) _conn.Close() ;
            return dt;  
        }

        public DataTable selectRecordAsKeyValue( string keyColumn, string valueColumn, string tablename=null, string filterColumn=null, string filterColumnValue = null)
        {
            if(String.IsNullOrEmpty(tablename)) tablename = _tablename;

            string selectQuery = String.Format("select {0},{1} from {2}",keyColumn,valueColumn,tablename);
            if(filterColumn!=null && filterColumnValue!=null)
            {
                selectQuery += String.Format(" where {0}={1} ",filterColumn,filterColumnValue);
            }
        
           // MessageBox.Show(selectQuery);
            DataTable dt = this.ExecuteSelectQuery(selectQuery);
            return dt;
          
        }

        public  string getLastQueryInsertId()
        {
            DataTable dt = this.ExecuteSelectQuery("select SCOPE_IDENTITY() as insertId;");
            if(dt.Rows.Count > 0)
            {
                string insertId = dt.Rows[0][0].ToString();
                return insertId;
            }
            return null;
        }

    }
}
