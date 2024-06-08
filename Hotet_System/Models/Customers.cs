using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Hotet_System.Models
{
    public class Customers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("CustomerGet", HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }
        public static Customer Get(int customerid)
        {
            Customer customer = null;

            OracleCommand command = new OracleCommand("CustomerGet",
             HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CustomerId", customerid);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customer = new Customer();
                customer.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
               // customer.IsHidden = Convert.ToBoolean(reader["IsHidden"]);
                customer.CustomerCode = reader["CustomerCode"].ToString();
                customer.CustomerType =reader["CustomerType"].ToString();
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.Sex = reader["Sex"].ToString();
                customer.Dob = reader["Dob"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.PassportNumber = reader["PassportNumber"].ToString();
                customer.Country = reader["Country"].ToString();
               
            }
            return customer;
        }

        public static void Add(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerAdd", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add("P_IsHidden", customer.IsHidden);
                command.Parameters.Add("P_CustomerCode", customer.CustomerCode);
                command.Parameters.Add("P_CustomerType", customer.CustomerType);
                command.Parameters.Add("P_CustomerName", customer.CustomerName);
                command.Parameters.Add("P_Sex", customer.Sex);
                command.Parameters.Add("P_Dob", customer.Dob);
                command.Parameters.Add("P_Phone", customer.Phone);
                command.Parameters.Add("P_PasssportNumber", customer.PassportNumber);
                command.Parameters.Add("P_Country", customer.Country);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerUpdate",
                 HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add("P_IsHidden", customer.IsHidden);
                command.Parameters.Add("P_CustomerId", customer.CustomerId);
                command.Parameters.Add("P_CustomerCode", customer.CustomerCode);
                command.Parameters.Add("P_CustomerType", customer.CustomerType);
                command.Parameters.Add("P_CustomerName", customer.CustomerName);
                command.Parameters.Add("P_Sex", customer.Sex);
                command.Parameters.Add("P_Dob", customer.Dob);
                command.Parameters.Add("P_Phone", customer.Phone);
                command.Parameters.Add("P_PasssportNumber", customer.PassportNumber);
                command.Parameters.Add("P_Country", customer.Country);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public static void Delete(int customerid)
        {
            try

            {
                OracleCommand command = new OracleCommand("CustomerDelete",
                 HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_CustomerId", customerid);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
