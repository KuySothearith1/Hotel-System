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
    public class Rooms
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("RoomGet", HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter dapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            dapter.Fill(table);
            return table;
        }
        public static Room Get(int roomid)
        {
            Room room = null;

            OracleCommand command = new OracleCommand("RoomGet",
             HotelContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_RoomId", roomid);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                room = new Room();
                room.RoomId = Convert.ToInt32(reader["RoomId"].ToString());
                room.RoomName =reader["RoomName"].ToString();
                room.RoomType = reader["RoomType"].ToString();
                room.Status = reader["Status"].ToString();
                room.Quantity = Convert.IsDBNull(reader["Quantity"]) ? 0 : Convert.ToDouble(reader["Quantity"]);
                room.Price = Convert.IsDBNull(reader["Price"]) ? 0 : Convert.ToDouble(reader["Price"]);
                
                if (!Convert.IsDBNull(reader["Image"]))
                {
                    room.Image = (byte[])reader["Image"];
                }
                else
                {
                    room.Image = null;
                }
               
            }


            return room;
        }

        public static void Add(Room room)
        {
            try
            {
                OracleCommand command = new OracleCommand("RoomAdd", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_RoomName", room.RoomName);
                command.Parameters.Add("P_RoomType", room.RoomType);
                command.Parameters.Add("P_Status", room.Status);
                command.Parameters.Add("P_Quantity", room.Quantity);
                command.Parameters.Add("P_Price", room.Price);
                command.Parameters.Add("P_Image", OracleDbType.Blob).Value = room.Image;
                
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Room room)
        {
            try
            {
                OracleCommand command = new OracleCommand("RoomUpdate", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_RoomId", room.RoomId);
                command.Parameters.Add("P_RoomName", room.RoomName);
                command.Parameters.Add("P_RoomType", room.RoomType);
                command.Parameters.Add("P_Status", room.Status);
                command.Parameters.Add("P_Quantity", room.Quantity);
                command.Parameters.Add("P_Price", room.Price);
                command.Parameters.Add("P_Image", OracleDbType.Blob).Value = room.Image;
                
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int roomid)
        {
            try
            {
                OracleCommand command = new OracleCommand("RoomDelete", HotelContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_RoomId", OracleDbType.Int32);
                command.Parameters["P_RoomId"].Value = roomid;

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
