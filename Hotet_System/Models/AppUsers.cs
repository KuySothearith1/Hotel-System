using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Models
{
    public class AppUsers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AppUserGet",
            HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }
        public static AppUser Get(int userid)
        {
            AppUser appuser = null;
            OracleCommand command = new OracleCommand("AppUserGet",
            HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", userid);
            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
                appuser.Username = reader["UserName"].ToString();
                appuser.Password = reader["Password"].ToString();
                appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
            }
            return appuser;
        }
        public static void Add(AppUser user)
        {
            try
            {

                OracleCommand command = new OracleCommand("AppUserAdd",
                HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_UserName", user.Username);
                command.Parameters.Add("P_Password", user.Password);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        public static void Update(AppUser user)
        {
            try
            {
                OracleCommand command = new OracleCommand("AppUserUpdate",
                HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AppUserId", user.AppUserId);
                command.Parameters.Add("P_UserName", user.Username);
                command.Parameters.Add("P_Password", user.Password);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public static void Delete(int userid)
        {
            try
            {
                OracleCommand command = new OracleCommand("AppUserDelete",
                HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AppUserId", OracleDbType.Int32);
                command.Parameters["P_AppUserId"].Value = userid;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public static AppUser Login(string username, string password)
        {
            AppUser appuser = null;
            OracleCommand command = new OracleCommand("AppUserLogin", HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_UserName", username);
            command.Parameters.Add("P_Password", password);
            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                appuser.Username = reader["UserName"].ToString();
                appuser.Password = reader["Password"].ToString();
                appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
            }
            return appuser;
        }
    }
}
