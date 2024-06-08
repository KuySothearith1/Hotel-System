using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotet_System.Models
{
    public class HotelContext
    {
        static OracleConnection db;
        public static void OpenConnection()
        {
            if (db == null)
            {
                db = new OracleConnection();
                db.ConnectionString = "Data Source=192.168.56.1:1521/XEPDB1;User Id=MyHotelData; Password=12345;";
                db.Open();
            }
        }
        public static OracleConnection GetConnection()
        {
            if (db == null)
            {
                OpenConnection();
            }
            return db;
        }
        public static void CloseConnection()
        {
            if (db != null)
            {
                db.Close();
            }
            db = null;
        }
    }
}
