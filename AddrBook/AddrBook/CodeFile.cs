using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Collections;

namespace AddrBook
{
    class Common_DB
    {
        public static OleDbConnection DBConnection()
        {
            OleDbConnection Conn;

            string ConStr = "Provider=OraOLEDB.Oracle; data source=topcredu;User ID=scott;Password=tiger";

            Conn = new OleDbConnection(ConStr);
            return Conn;
        }

        public static OleDbDataReader DataSelect(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                return myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                Log.WriteLine("CodeFile", ex.Message);
                MessageBox.Show(sql + "\n" + ex.Message, "DataSelect");
                return null;
            }
            finally
            {

            }
        }

        public static bool DataManupulation(string sql, OleDbConnection Conn)
        {
            try
            {
                OleDbCommand myCommand = new OleDbCommand(sql, Conn);
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Log.WriteLine("CodeFile", ex.Message);
                MessageBox.Show(sql + "\n" + ex.Message, "DataManupulation");
                return false;
            }
            finally
            {

            }
        }
    }
}
