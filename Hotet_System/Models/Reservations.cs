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
    public class Reservations
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("ReservationGet",
            HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }

        public static Reservation Get(int reservationid)
        {
            Reservation reservation = null;
            OracleCommand command = new OracleCommand("ReservationGet",
            HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_ReservationId", reservationid);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                reservation = new Reservation();
                reservation.ReservationId = Convert.ToInt32(reader["ReservationId"].ToString());
                reservation.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                reservation.CheckInDate = Convert.ToDateTime(reader["CheckInDate"].ToString());
                reservation.IsCheckIn = reader["IsCheckIn"].ToString();
                reservation.NumberOfDay = Convert.ToInt32(reader["NumberofDay"].ToString());
                reservation.NumberOfAdult = Convert.ToInt32(reader["NumberofAdult"].ToString());
                reservation.NumberOfChildrens = Convert.ToInt32(reader["NumberofChildrens"].ToString());
                reservation.Memo = reader["Memo"].ToString();
                reservation.CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"].ToString());
                reservation.IsPay = reader["IsPay"].ToString();
                reservation.IsCheckOut = reader["IsCheckOut"].ToString();
                if (!Convert.IsDBNull(reader["AppUserId"]))
                    reservation.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
            }
            return reservation;
        }
        public static int Add(Reservation reservation)
        {
            int reservationid = 0;
            try
            {
                OracleCommand command = new OracleCommand("ReservationAdd", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_CustomerId", OracleDbType.Varchar2).Value =
                reservation.CustomerId;
                command.Parameters.Add("P_CheckInDate", OracleDbType.Date).Value =
                reservation.CheckInDate;
                command.Parameters.Add("P_IsCheckIn", OracleDbType.Varchar2).Value =
                reservation.IsCheckIn;
                command.Parameters.Add("P_NumberOfDay", OracleDbType.Decimal).Value =
                reservation.NumberOfDay;
                command.Parameters.Add("P_NumberOfAdult", OracleDbType.Decimal).Value =
                reservation.NumberOfAdult;
                command.Parameters.Add("P_NumberOfChildrens", OracleDbType.Decimal).Value =
                reservation.NumberOfChildrens;
                command.Parameters.Add("P_Memo", OracleDbType.Varchar2).Value =
                reservation.Memo;
                command.Parameters.Add("P_CheckOutDate", OracleDbType.Date).Value =
                reservation.CheckOutDate;
                command.Parameters.Add("P_IsPay", OracleDbType.Varchar2).Value =
                reservation.IsPay;
                command.Parameters.Add("P_IsCheckOut", OracleDbType.Varchar2).Value =
                reservation.IsCheckOut;
                command.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value =
                DBNull.Value;
                command.Parameters.Add("P_ReservationId", OracleDbType.Int32).Direction =
                ParameterDirection.Output;
                command.ExecuteNonQuery();
                reservationid = Convert.ToInt32(command.Parameters["P_ReservationId"].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return reservationid;
        }
        public static void Update(Reservation reservation)

        {
            
            try
            {
                OracleCommand command = new OracleCommand("ReservationUpdate",
               HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_ReservationId", OracleDbType.Int32).Value = reservation.ReservationId;
                command.Parameters.Add("P_CustomerId", OracleDbType.Int32).Value =
                 reservation.CustomerId;
                command.Parameters.Add("P_CheckInDate", OracleDbType.Date).Value =
                reservation.CheckInDate;
                command.Parameters.Add("P_IsCheckIn", OracleDbType.Varchar2).Value =
                reservation.IsCheckIn;
                command.Parameters.Add("P_NumberOfDay", OracleDbType.Decimal).Value =
                reservation.NumberOfDay;
                command.Parameters.Add("P_NumberOfAdult", OracleDbType.Decimal).Value =
                reservation.NumberOfAdult;
                command.Parameters.Add("P_NumberOfChildrens", OracleDbType.Decimal).Value =
                reservation.NumberOfChildrens;
                command.Parameters.Add("P_Memo", OracleDbType.Varchar2).Value =
                reservation.Memo;
                command.Parameters.Add("P_CheckOutDate", OracleDbType.Date).Value =
                reservation.CheckOutDate;
                command.Parameters.Add("P_IsPay", OracleDbType.Varchar2).Value =
                reservation.IsPay;
                command.Parameters.Add("P_IsCheckOut", OracleDbType.Varchar2).Value =
                reservation.IsCheckOut;
                command.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value =
                DBNull.Value;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
        }

        public static void Delete(int reservationid)
        {
            try
            {
                OracleCommand command = new OracleCommand("ReservationDelete", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_ReservationId", OracleDbType.Int32);
                command.Parameters["P_ReservationId"].Value = reservationid;
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

