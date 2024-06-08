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
    public class ReservationDetails
    {
        public static DataTable Get(int reservationid)
        {
            OracleCommand command = new OracleCommand("ReservationDetailGet",
            HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_ReservationId", reservationid);
            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }

        public static void Add(ReservationDetail reservationdetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("ReservationDetailAdd",
                HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_ReservationId", OracleDbType.Int32).Value =
               reservationdetail.ReservationId;
                command.Parameters.Add("P_RoomId", OracleDbType.Int32).Value =
                reservationdetail.RoomId;
                command.Parameters.Add("P_RoomType", OracleDbType.Varchar2).Value =
                reservationdetail.RoomType;
                command.Parameters.Add("P_Status", OracleDbType.Varchar2).Value =
                reservationdetail.Status;
                command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value =
                reservationdetail.Quantity;
                command.Parameters.Add("P_Price", OracleDbType.Decimal).Value =
                reservationdetail.Price;
               

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        public static void Update(ReservationDetail reservationdetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("ReservationDetailUpdate",
                HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_ReservationDetailId", OracleDbType.Int32).Value =
                reservationdetail.ReservationDetailId;
                command.Parameters.Add("P_ReservationId", OracleDbType.Int32).Value =
               reservationdetail.ReservationId;
                command.Parameters.Add("P_RoomId", OracleDbType.Int32).Value =
                reservationdetail.RoomId;
                command.Parameters.Add("P_RoomType", OracleDbType.Varchar2).Value =
                reservationdetail.RoomType;
                command.Parameters.Add("P_Status", OracleDbType.Varchar2).Value =
                reservationdetail.Status;
                command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value =
                reservationdetail.Quantity;
                command.Parameters.Add("P_Price", OracleDbType.Decimal).Value =
                reservationdetail.Price;
               

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
                OracleCommand command = new OracleCommand("ReservationDetailDelete",
               HotelContext.GetConnection());
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
