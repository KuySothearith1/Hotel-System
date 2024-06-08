using Hotet_System.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    public partial class FormDashBoard : Form
    {
        FormMain formMain;
        public FormDashBoard(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {

           

            string connectionString = "Data Source=192.168.56.1:1521/XEPDB1;User Id=MyHotelData; Password=12345;";
            string Customer = "Customer";
            string Room = "Room";
            string Reservation = "Reservation";
            string AppUser = "AppUser";


            int rowCount = 0;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Customer}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }


            lblCustomer.Text = rowCount.ToString();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Room}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }


            lblRoom.Text = rowCount.ToString();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {Reservation}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }
            lblReservation.Text = rowCount.ToString();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string sql = $"SELECT COUNT(*) AS row_count FROM {AppUser}";
                OracleCommand command = new OracleCommand(sql, connection);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rowCount = Convert.ToInt32(reader["row_count"]);
                    }
                }
            }
            lblAppUser.Text = rowCount.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void myButton9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void myButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clock_Tick(object sender, EventArgs e)
        {
             
        }
    }
}
